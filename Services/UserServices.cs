using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using UserVehicleSection.Models;
using UserVehicleSection.Models.APIAcess;

namespace UserVehicleSection.Services
{
    public class UserServices : IUserServices
    {

        public UserVehicleSectionContext context;

        public UserServices(UserVehicleSectionContext ctx)
        {
            context = ctx;
        }

        public IQueryable<UserImgDb> GetUserImgs => context.UserImgDb;

        public IQueryable<UserVehDb> GetUserVehs => context.UserVehDb;

        public IQueryable<ShopServicesDb> GetShopServices => context.ShopServicesDb;

        public IQueryable<ShopTechDb> GetShopTeches => context.ShopTechDb;

        public IQueryable<MessageDb> GetMessages => context.MessageDb;

        public IQueryable<ServicedHistDb> GetServicedHists => context.ServicedHistDb;

        public IQueryable<UserDb> GetUserDbs => context.UserDb;

        public IQueryable<ShopTechDb> GetTechDbs => context.ShopTechDb;

        public IQueryable<ShopServicesDb> GetShopServicesDbs => context.ShopServicesDb;

        public IQueryable<AssignedTechDb> GetAssignedTechDbs => context.AssignedTechDb;

        public IQueryable<VehReqDb> GetVehReqs => context.VehReqDb;

        public IQueryable<ServiceReqDb> GetServiceReqs => context.ServiceReqDb;


        //Vehicle Makes
        public async Task<List<Result>> GetVehichleMakesAsync()
        {
            //GetAllMakes getAllMakes = new GetAllMakes();

            Task<List<Result>> results = Task.Factory.StartNew<List<Result>>(() =>
            {
                GetAllMakes getAllMakes = new GetAllMakes();

                HttpWebRequest myReq = (HttpWebRequest)WebRequest.Create("https://vpic.nhtsa.dot.gov/api/vehicles/getallmakes?format=json");

                WebResponse webResponse = myReq.GetResponse();

                using (Stream dataStream = webResponse.GetResponseStream())
                {
                    // Open the stream using a StreamReader for easy access.
                    StreamReader reader = new StreamReader(dataStream);

                    getAllMakes = JsonConvert.DeserializeObject<GetAllMakes>(reader.ReadToEnd());
                    // Read the content.
                    // string responseFromServer = reader.ReadToEnd();
                    // Display the content.
                    //  Console.WriteLine(responseFromServer);
                }

                webResponse.Close();

                return getAllMakes.Results;

            });

            await results;

            return results.Result;

        }

        public async Task<bool> DelMessageObject(MessageDb messageDb)
        {
            context.Remove(messageDb);

            await context.SaveChangesAsync();

            return await Task.FromResult(true);
        }

        public async Task<bool> DelServiceReqObject(ServiceReqDb serviceReq)
        {
            context.Remove(serviceReq);

            await context.SaveChangesAsync();

            return await Task.FromResult(true);
        }

        public async Task<bool> CreateUserImgAsync(UserImgDb userImg)
        {
            await context.AddAsync(userImg);
            await context.SaveChangesAsync();

            return await Task.FromResult(true);
        }

        public async Task<bool> CreateUserVeh(UserVehDb userVeh)
        {
            await context.AddAsync(userVeh);
            await context.SaveChangesAsync();

            return await Task.FromResult(true);
        }

        public async Task<bool> CreateShopServices(ShopServicesDb shopServices)
        {
            await context.AddAsync(shopServices);
            await context.SaveChangesAsync();

            return await Task.FromResult(true);
        }

        public async Task<bool> CreateShopTeches(ShopTechDb shopTeches)
        {
            await context.AddAsync(shopTeches);
            await context.SaveChangesAsync();

            return await Task.FromResult(true);
        }

        public async Task<bool> CreateAssignedTech(AssignedTechDb assignedTech)
        {
            await context.AddAsync(assignedTech);
            await context.SaveChangesAsync();

            return await Task.FromResult(true);
        }

        public async Task<bool> CreateVehReq(VehReqDb vehReq)
        {
            await context.AddAsync(vehReq);
            await context.SaveChangesAsync();

            return await Task.FromResult(true);
        }

        public async Task<bool> CreateServiceReq(ServiceReqDb serviceReq)
        {
            await context.AddAsync(serviceReq);
            await context.SaveChangesAsync();

            return await Task.FromResult(true);
        }

        public async Task<bool> CreateServiceHist(ServicedHistDb servicedHist)
        {
            await context.AddAsync(servicedHist);
            await context.SaveChangesAsync();

            return await Task.FromResult(true);
        }

        public async Task<bool> CreateMessage(MessageDb message)
        {
            await context.AddAsync(message);
            await context.SaveChangesAsync();

            return await Task.FromResult(true);
        }
    }
}
