using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UserVehicleSection.Models;
using UserVehicleSection.Services;
using UserVehicleSection.ViewModels;

namespace UserVehicleSection.Controllers
{
    public class AccountsController : Controller
    {
        private UserManager<UserDb> userManager;
        private SignInManager<UserDb> signInManager;

        private IUserServices _repo;

        public AccountsController(UserManager<UserDb> userMgr, SignInManager<UserDb> signInMgr, IUserServices repository)
        {
            userManager = userMgr;
            signInManager = signInMgr;
            _repo = repository;
        }



        public IActionResult AccountManagement()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> _RegisterSection(RegiserModel model)
        {
            if (ModelState.IsValid)
            {

                UserImgDb userImg = new UserImgDb();
                using (var memoryStream = new MemoryStream())
                {
                    await model.ImgPic.CopyToAsync(memoryStream);

                    userImg.UserImg = memoryStream.ToArray();
                }

                bool result = await _repo.CreateUserImgAsync(userImg);

                if (result)
                {
                    UserDb user = new UserDb
                    {
                        UserName = model.AccountName,
                        UserEmail = model.AccountEmail,
                        UserAddress = model.AccountAddress,
                        UserCity = model.AccountCity,
                        UserCountry = model.AccountCountry,
                        UserDescription = model.AccountDescription,
                        ImageId = userImg.ImageId
                    };

                    if (model.IsShop)
                    {
                        user.IsShop = true;
                    }

                    var identityResult = await userManager.CreateAsync(user, model.AccountPassword);

                    if (identityResult.Succeeded)
                    {
                        ViewBag.Set = "You are all Set to LogIn";
                        // return Request.
                        // return RedirectToAction("Index", "Account");
                    }
                    else
                    {
                        foreach (IdentityError error in identityResult.Errors)
                        {
                            ModelState.AddModelError("", error.Description);
                        }
                    }

                }


            }

            //return PartialView(""model);
           // return View("AccountManagement", model);

           return View("AccountManagement", new AccountPort { RegiserModel = model });

           //return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> _LogInSection(SignInModel details) // This was the LogInModel
        {
            if (ModelState.IsValid)
            {

                UserDb user = await userManager.FindByNameAsync(details.UserName);

                if (user != null)
                {
                    await signInManager.SignOutAsync();

                    Microsoft.AspNetCore.Identity.SignInResult result = await signInManager.PasswordSignInAsync(user, details.Password, false, false);

                    if (result.Succeeded)
                    {
                        Response.Cookies.Append("UserID", user.UserId.ToString());
                        Response.Cookies.Append("UserName", user.UserName);
                        Response.Cookies.Append("UserImage", user.ImageId.ToString());
                        Response.Cookies.Append("IsShop", user.IsShop.ToString());

                        // return RedirectToAction("Vehicle", "Account",new {id = user.UserId });
                        if (user.IsShop == true)
                        {
                            return RedirectToAction("ShopPortfolio", "Account", new { id = user.UserId, status = user.IsShop });
                        }
                        else
                        {
                            return RedirectToAction("UserPortfolio", "UserPort", new { id = user.UserId, status = user.IsShop });
                        }

                    }
                }
                ModelState.AddModelError(nameof(SignInModel.UserName), "Invalid user or password");

            }

            return View("AccountManagement", new AccountPort { SignIn = details });


            //return View("AccountManagement", details);
            //return RedirectToAction("AccountManagement", details);
            //return View(details);
            //return PartialView(details);
            //return PartialView("_LogInSection", details);

        }


    }
}
