#pragma checksum "C:\Users\elegam\Desktop\InstagramPoll\Views\ManageAccount\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e70a2173cff5534cd0f211c02b12abc91004f46"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ManageAccount_Index), @"mvc.1.0.view", @"/Views/ManageAccount/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ManageAccount/Index.cshtml", typeof(AspNetCore.Views_ManageAccount_Index))]
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
#line 1 "C:\Users\elegam\Desktop\InstagramPoll\Views\_ViewImports.cshtml"
using InstagramPoll;

#line default
#line hidden
#line 2 "C:\Users\elegam\Desktop\InstagramPoll\Views\_ViewImports.cshtml"
using InstagramPoll.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e70a2173cff5534cd0f211c02b12abc91004f46", @"/Views/ManageAccount/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e2652d117608570c87b79a390225dbfeae50a88", @"/Views/_ViewImports.cshtml")]
    public class Views_ManageAccount_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\elegam\Desktop\InstagramPoll\Views\ManageAccount\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_NewLayout.cshtml";

#line default
#line hidden
            BeginContext(93, 8, true);
            WriteLiteral("\r\n\r\n    ");
            EndContext();
            BeginContext(101, 773, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e70a2173cff5534cd0f211c02b12abc91004f463949", async() => {
                BeginContext(126, 41, true);
                WriteLiteral("\r\n        <span class=\"text text-danger\">");
                EndContext();
                BeginContext(168, 24, false);
#line 9 "C:\Users\elegam\Desktop\InstagramPoll\Views\ManageAccount\Index.cshtml"
                                  Write(ViewData["ErrorMessage"]);

#line default
#line hidden
                EndContext();
                BeginContext(192, 178, true);
                WriteLiteral("</span>\r\n        <div class=\"form-group\">\r\n            <label for=\"username\">نام کاربری</label>\r\n            <input type=\"text\" class=\"form-control\" id=\"username\" name=\"username\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 370, "\"", 399, 1);
#line 12 "C:\Users\elegam\Desktop\InstagramPoll\Views\ManageAccount\Index.cshtml"
WriteAttributeValue("", 378, ViewData["Username"], 378, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(400, 256, true);
                WriteLiteral(@">
            <span id=""username"" class=""text text-danger""></span>
        </div>
        <div class=""form-group"">
            <label for=""password"">رمز عبور</label>
            <input type=""password"" class=""form-control"" id=""password"" name=""password""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 656, "\"", 685, 1);
#line 17 "C:\Users\elegam\Desktop\InstagramPoll\Views\ManageAccount\Index.cshtml"
WriteAttributeValue("", 664, ViewData["Password"], 664, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(686, 181, true);
                WriteLiteral(">\r\n            <span id=\"password\" class=\"text text-danger\"></span>\r\n        </div>\r\n        <button type=\"submit\" id=\"btnSubmit\" class=\"btn btn-success mt-0\">ورود </button>\r\n\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(874, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(897, 42, true);
                WriteLiteral(" \r\n    <script>\r\n        \r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(942, 2, true);
            WriteLiteral("\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
