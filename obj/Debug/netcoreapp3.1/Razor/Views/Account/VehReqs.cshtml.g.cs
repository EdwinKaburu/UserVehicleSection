#pragma checksum "C:\Users\edwinPC\Documents\ProjectDraft\Dark Theme\DarkThemProject\UserVehicleSection\Views\Account\VehReqs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d244a653009250d21e1358c1558e279f2ce6dc7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_VehReqs), @"mvc.1.0.view", @"/Views/Account/VehReqs.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d244a653009250d21e1358c1558e279f2ce6dc7", @"/Views/Account/VehReqs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f3d06e771c0613178fdf6fab0d640c967e6bd81", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_VehReqs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VehicleReqModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CheckBoxTester", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\edwinPC\Documents\ProjectDraft\Dark Theme\DarkThemProject\UserVehicleSection\Views\Account\VehReqs.cshtml"
  
    ViewData["Title"] = "VehReqs";
    Layout = "~/Views/Shared/_Layout.cshtml";

    string alert = ViewBag.RequestSent;

    if (alert != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"callout success\" data-closable>\r\n            <h3>");
#nullable restore
#line 11 "C:\Users\edwinPC\Documents\ProjectDraft\Dark Theme\DarkThemProject\UserVehicleSection\Views\Account\VehReqs.cshtml"
           Write(alert);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <button class=\"close-button\" aria-label=\"Dismiss alert\" type=\"button\" data-close>\r\n                <span aria-hidden=\"true\">&times;</span>\r\n            </button>\r\n        </div>\r\n");
#nullable restore
#line 16 "C:\Users\edwinPC\Documents\ProjectDraft\Dark Theme\DarkThemProject\UserVehicleSection\Views\Account\VehReqs.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 19 "C:\Users\edwinPC\Documents\ProjectDraft\Dark Theme\DarkThemProject\UserVehicleSection\Views\Account\VehReqs.cshtml"
Write(Model.GetUser.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n");
            WriteLiteral("\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d244a653009250d21e1358c1558e279f2ce6dc76573", async() => {
                WriteLiteral("\r\n    <div class=\"grid-container fluid\">\r\n        <div class=\"grid-x grid-margin-x\">\r\n\r\n            <div class=\"cell small-6\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d244a653009250d21e1358c1558e279f2ce6dc76987", async() => {
                    WriteLiteral("\r\n                    Enter Request Name\r\n                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6d244a653009250d21e1358c1558e279f2ce6dc77316", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 43 "C:\Users\edwinPC\Documents\ProjectDraft\Dark Theme\DarkThemProject\UserVehicleSection\Views\Account\VehReqs.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.VehReqName);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 41 "C:\Users\edwinPC\Documents\ProjectDraft\Dark Theme\DarkThemProject\UserVehicleSection\Views\Account\VehReqs.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.VehReqName);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"cell small-6\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d244a653009250d21e1358c1558e279f2ce6dc710304", async() => {
                    WriteLiteral("\r\n                    Enter A Requested Date\r\n                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6d244a653009250d21e1358c1558e279f2ce6dc710638", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 50 "C:\Users\edwinPC\Documents\ProjectDraft\Dark Theme\DarkThemProject\UserVehicleSection\Views\Account\VehReqs.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.VehdateTime);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 48 "C:\Users\edwinPC\Documents\ProjectDraft\Dark Theme\DarkThemProject\UserVehicleSection\Views\Account\VehReqs.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.VehdateTime);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"cell small-6\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d244a653009250d21e1358c1558e279f2ce6dc713629", async() => {
                    WriteLiteral("\r\n                    Send Request Message\r\n                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d244a653009250d21e1358c1558e279f2ce6dc713961", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
#nullable restore
#line 57 "C:\Users\edwinPC\Documents\ProjectDraft\Dark Theme\DarkThemProject\UserVehicleSection\Views\Account\VehReqs.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.VehMessage);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 55 "C:\Users\edwinPC\Documents\ProjectDraft\Dark Theme\DarkThemProject\UserVehicleSection\Views\Account\VehReqs.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.VehMessage);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            </div>

            <div class=""cell small-6"">
                <button type=""submit"" class=""button"">Send Request</button>
            </div>

            <div class=""cell small-6"">
                <fieldset class=""fieldset"">
                    <legend>Select Your Service</legend>
");
#nullable restore
#line 68 "C:\Users\edwinPC\Documents\ProjectDraft\Dark Theme\DarkThemProject\UserVehicleSection\Views\Account\VehReqs.cshtml"
                     foreach (var items in Model.AssignedTeches)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <label>\r\n                            Assigned Technician : ");
#nullable restore
#line 71 "C:\Users\edwinPC\Documents\ProjectDraft\Dark Theme\DarkThemProject\UserVehicleSection\Views\Account\VehReqs.cshtml"
                                             Write(items.Technician.TechnicianName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            Service Name : ");
#nullable restore
#line 72 "C:\Users\edwinPC\Documents\ProjectDraft\Dark Theme\DarkThemProject\UserVehicleSection\Views\Account\VehReqs.cshtml"
                                      Write(items.Service.ServiceName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            <input id=\"checkbox\" name=\"Blanks\"");
                BeginWriteAttribute("value", " value=\"", 2466, "\"", 2489, 1);
#nullable restore
#line 73 "C:\Users\edwinPC\Documents\ProjectDraft\Dark Theme\DarkThemProject\UserVehicleSection\Views\Account\VehReqs.cshtml"
WriteAttributeValue("", 2474, items.AssignId, 2474, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"checkbox\" />\r\n                        </label>\r\n");
#nullable restore
#line 75 "C:\Users\edwinPC\Documents\ProjectDraft\Dark Theme\DarkThemProject\UserVehicleSection\Views\Account\VehReqs.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </fieldset>\r\n            </div>\r\n\r\n\r\n        </div>\r\n    </div>\r\n\r\n");
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-shopID", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 36 "C:\Users\edwinPC\Documents\ProjectDraft\Dark Theme\DarkThemProject\UserVehicleSection\Views\Account\VehReqs.cshtml"
                                                                 WriteLiteral(Model.UserID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["shopID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-shopID", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["shopID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 36 "C:\Users\edwinPC\Documents\ProjectDraft\Dark Theme\DarkThemProject\UserVehicleSection\Views\Account\VehReqs.cshtml"
                                                                                                 WriteLiteral(Model.VehicleID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["vehID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-vehID", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["vehID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
