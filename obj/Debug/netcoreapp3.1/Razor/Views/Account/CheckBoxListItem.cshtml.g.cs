#pragma checksum "C:\Users\edwinPC\Documents\ProjectDraft\Dark Theme\DarkThemProject\UserVehicleSection\Views\Account\CheckBoxListItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c7a461af02599245e46a91282b567b834600423"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_CheckBoxListItem), @"mvc.1.0.view", @"/Views/Account/CheckBoxListItem.cshtml")]
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
#line 1 "C:\Users\edwinPC\Documents\ProjectDraft\Dark Theme\DarkThemProject\UserVehicleSection\Views\_ViewImports.cshtml"
using UserVehicleSection;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\edwinPC\Documents\ProjectDraft\Dark Theme\DarkThemProject\UserVehicleSection\Views\_ViewImports.cshtml"
using UserVehicleSection.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\edwinPC\Documents\ProjectDraft\Dark Theme\DarkThemProject\UserVehicleSection\Views\_ViewImports.cshtml"
using UserVehicleSection.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\edwinPC\Documents\ProjectDraft\Dark Theme\DarkThemProject\UserVehicleSection\Views\_ViewImports.cshtml"
using UserVehicleSection.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c7a461af02599245e46a91282b567b834600423", @"/Views/Account/CheckBoxListItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f3d06e771c0613178fdf6fab0d640c967e6bd81", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_CheckBoxListItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CheckBoxItem>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\edwinPC\Documents\ProjectDraft\Dark Theme\DarkThemProject\UserVehicleSection\Views\Account\CheckBoxListItem.cshtml"
Write(Html.HiddenFor(x => x.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\edwinPC\Documents\ProjectDraft\Dark Theme\DarkThemProject\UserVehicleSection\Views\Account\CheckBoxListItem.cshtml"
Write(Html.CheckBoxFor(x => x.IsChecked));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\edwinPC\Documents\ProjectDraft\Dark Theme\DarkThemProject\UserVehicleSection\Views\Account\CheckBoxListItem.cshtml"
Write(Html.LabelFor(x => x.IsChecked, Model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CheckBoxItem> Html { get; private set; }
    }
}
#pragma warning restore 1591
