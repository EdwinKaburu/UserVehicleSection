#pragma checksum "C:\Users\edwinPC\source\repos\UserVehicleSection\Views\Account\VehReq.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7925e0252104794868d860ee6430a2d9c23ff70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_VehReq), @"mvc.1.0.view", @"/Views/Account/VehReq.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\edwinPC\source\repos\UserVehicleSection\Views\_ViewImports.cshtml"
using UserVehicleSection;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\edwinPC\source\repos\UserVehicleSection\Views\_ViewImports.cshtml"
using UserVehicleSection.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\edwinPC\source\repos\UserVehicleSection\Views\_ViewImports.cshtml"
using UserVehicleSection.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\edwinPC\source\repos\UserVehicleSection\Views\_ViewImports.cshtml"
using UserVehicleSection.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7925e0252104794868d860ee6430a2d9c23ff70", @"/Views/Account/VehReq.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f3d06e771c0613178fdf6fab0d640c967e6bd81", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_VehReq : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VehicleReqModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "VehReqs", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\edwinPC\source\repos\UserVehicleSection\Views\Account\VehReq.cshtml"
  
    ViewData["Title"] = "VehReq";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>VehReq</h1>\r\n<div class=\"grid-container fluid\">\r\n    <div class=\"grid-x grid-padding-x\">\r\n");
#nullable restore
#line 10 "C:\Users\edwinPC\source\repos\UserVehicleSection\Views\Account\VehReq.cshtml"
         foreach (var item in Model.Shoppers)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"cell small-6\">\r\n                <div class=\"card\">\r\n                    <div class=\"card-divider\">\r\n                        <h4>");
#nullable restore
#line 16 "C:\Users\edwinPC\source\repos\UserVehicleSection\Views\Account\VehReq.cshtml"
                       Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                    </div>
                    <img src=""http://getwallpapers.com/wallpaper/full/6/9/0/157759.jpg"">
                    <div class=""card-section"">

                        <div class=""grid-container fluid"">
                            <div class=""grid-x grid-margin-x"">

                                <div class=""cell small-6"">
                                    <p>Name : ");
#nullable restore
#line 25 "C:\Users\edwinPC\source\repos\UserVehicleSection\Views\Account\VehReq.cshtml"
                                         Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <p>Email : ");
#nullable restore
#line 26 "C:\Users\edwinPC\source\repos\UserVehicleSection\Views\Account\VehReq.cshtml"
                                          Write(item.UserEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </div>\r\n                                <div class=\"cell small-6\">\r\n                                    <p>Address : ");
#nullable restore
#line 29 "C:\Users\edwinPC\source\repos\UserVehicleSection\Views\Account\VehReq.cshtml"
                                            Write(item.UserAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <p>Address : ");
#nullable restore
#line 30 "C:\Users\edwinPC\source\repos\UserVehicleSection\Views\Account\VehReq.cshtml"
                                            Write(item.UserCity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <p>Address : ");
#nullable restore
#line 31 "C:\Users\edwinPC\source\repos\UserVehicleSection\Views\Account\VehReq.cshtml"
                                            Write(item.UserCountry);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </div>\r\n                                <div class=\"cell small-6\">\r\n                                    <p> Description : ");
#nullable restore
#line 34 "C:\Users\edwinPC\source\repos\UserVehicleSection\Views\Account\VehReq.cshtml"
                                                 Write(item.UserDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </div>\r\n                                <div class=\"cell small-6\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7925e0252104794868d860ee6430a2d9c23ff708140", async() => {
                WriteLiteral("\r\n\r\n                                        <button type=\"submit\" class=\"button\">Submit Request</button>\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-vehID", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 37 "C:\Users\edwinPC\source\repos\UserVehicleSection\Views\Account\VehReq.cshtml"
                                                                                             WriteLiteral(Model.VehicleID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["vehID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-vehID", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["vehID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 37 "C:\Users\edwinPC\source\repos\UserVehicleSection\Views\Account\VehReq.cshtml"
                                                                                                                                 WriteLiteral(item.UserId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["shopID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-shopID", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["shopID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("                                                                       \r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 48 "C:\Users\edwinPC\source\repos\UserVehicleSection\Views\Account\VehReq.cshtml"

            
            
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VehicleReqModel> Html { get; private set; }
    }
}
#pragma warning restore 1591