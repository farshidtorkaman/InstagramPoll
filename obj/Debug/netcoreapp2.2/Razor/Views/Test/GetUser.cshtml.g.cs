#pragma checksum "C:\Users\elegam\Desktop\InstagramPoll\Views\Test\GetUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab5cad51f8fa93486802187c0a79d7bddefe3c03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Test_GetUser), @"mvc.1.0.view", @"/Views/Test/GetUser.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Test/GetUser.cshtml", typeof(AspNetCore.Views_Test_GetUser))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab5cad51f8fa93486802187c0a79d7bddefe3c03", @"/Views/Test/GetUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e2652d117608570c87b79a390225dbfeae50a88", @"/Views/_ViewImports.cshtml")]
    public class Views_Test_GetUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("https://api.instagram.com/oauth/access_token"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\elegam\Desktop\InstagramPoll\Views\Test\GetUser.cshtml"
  
    ViewData["Title"] = "GetUser";
    Layout = "~/Views/Shared/_NewLayout.cshtml";

#line default
#line hidden
            BeginContext(95, 22, true);
            WriteLiteral("\r\n<h1>GetUser</h1>\r\n\r\n");
            EndContext();
            BeginContext(117, 629, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab5cad51f8fa93486802187c0a79d7bddefe3c034292", async() => {
                BeginContext(191, 455, true);
                WriteLiteral(@"
    <input type=""hidden"" value=""75649c4f3a28422dae507dddf35e1505"" name=""client_id"" class=""form-control"" />
    <input type=""hidden"" value=""087ba8dabeea40c09139379527c8f20e"" name=""client_secret"" class=""form-control"" />
    <input type=""hidden"" value=""authorization_code"" name=""grant_type"" class=""form-control"" />
    <input type=""hidden"" value=""http://localhost:52899/Test/GetUser"" name=""redirect_uri"" class=""form-control"" />
    <input type=""hidden""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 646, "\"", 671, 1);
#line 14 "C:\Users\elegam\Desktop\InstagramPoll\Views\Test\GetUser.cshtml"
WriteAttributeValue("", 654, ViewData["Code"], 654, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(672, 67, true);
                WriteLiteral(" name=\"code\" class=\"form-control\" />\r\n    <input type=\"submit\" />\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(746, 427, true);
            WriteLiteral(@"

<div class=""server-results"">

</div>

<script>
    $.ajax({
        url: ""https://api.instagram.com/oauth/access_token"",
        type: ""post"",
        data: {
            client_id: ""75649c4f3a28422dae507dddf35e1505"",
            client_secret: ""087ba8dabeea40c09139379527c8f20e"",
            grant_type: ""authorization_code"",
            redirect_uri: ""http://localhost:52899/Test/GetUser"",
            code: ");
            EndContext();
            BeginContext(1174, 16, false);
#line 31 "C:\Users\elegam\Desktop\InstagramPoll\Views\Test\GetUser.cshtml"
             Write(ViewData["Code"]);

#line default
#line hidden
            EndContext();
            BeginContext(1190, 101, true);
            WriteLiteral("\r\n        }\r\n\t}).done(function(response){ //\r\n\t\t$(\"#server-results\").html(response);\r\n\t});\r\n</script>");
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
