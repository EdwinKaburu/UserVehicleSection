#pragma checksum "C:\Users\edwinPC\source\repos\UserVehicleSection\Views\Account\_Model.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97667c12b8fa6ab9aa12b9408a7069df9f05ad5a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account__Model), @"mvc.1.0.view", @"/Views/Account/_Model.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97667c12b8fa6ab9aa12b9408a7069df9f05ad5a", @"/Views/Account/_Model.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f3d06e771c0613178fdf6fab0d640c967e6bd81", @"/Views/_ViewImports.cshtml")]
    public class Views_Account__Model : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ListView>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\edwinPC\source\repos\UserVehicleSection\Views\Account\_Model.cshtml"
   
    foreach(var item in Model.Results)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>");
#nullable restore
#line 6 "C:\Users\edwinPC\source\repos\UserVehicleSection\Views\Account\_Model.cshtml"
      Write(item.MakeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 7 "C:\Users\edwinPC\source\repos\UserVehicleSection\Views\Account\_Model.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Partial View : ");
#nullable restore
#line 8 "C:\Users\edwinPC\source\repos\UserVehicleSection\Views\Account\_Model.cshtml"
                  Write(Model.VehModel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ListView> Html { get; private set; }
    }
}
#pragma warning restore 1591
