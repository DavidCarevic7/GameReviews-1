#pragma checksum "E:\Fax\Programiranje\C#\GameReviews\Web\Views\Posts\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3989470d5ac0357b6873b669cd030c45090eba97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Posts_Details), @"mvc.1.0.view", @"/Views/Posts/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Posts/Details.cshtml", typeof(AspNetCore.Views_Posts_Details))]
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
#line 1 "E:\Fax\Programiranje\C#\GameReviews\Web\Views\_ViewImports.cshtml"
using Web;

#line default
#line hidden
#line 2 "E:\Fax\Programiranje\C#\GameReviews\Web\Views\_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3989470d5ac0357b6873b669cd030c45090eba97", @"/Views/Posts/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b0619e1a302f0598271da1847e697c39d57b88", @"/Views/_ViewImports.cshtml")]
    public class Views_Posts_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Application.DTO.GetOnePostDto>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Fax\Programiranje\C#\GameReviews\Web\Views\Posts\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(83, 114, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>GetOnePostDto</h4>\r\n    <hr />\r\n    <div class=\"text-center\">\r\n\r\n        <h3>");
            EndContext();
            BeginContext(198, 37, false);
#line 14 "E:\Fax\Programiranje\C#\GameReviews\Web\Views\Posts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(235, 41, true);
            WriteLiteral("</h3>\r\n        <p class=\"text-info\">By:  ");
            EndContext();
            BeginContext(277, 37, false);
#line 15 "E:\Fax\Programiranje\C#\GameReviews\Web\Views\Posts\Details.cshtml"
                             Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(314, 14, true);
            WriteLiteral("</p>\r\n        ");
            EndContext();
            BeginContext(328, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3989470d5ac0357b6873b669cd030c45090eba974744", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 338, "~/PostImages/", 338, 13, true);
#line 16 "E:\Fax\Programiranje\C#\GameReviews\Web\Views\Posts\Details.cshtml"
AddHtmlAttributeValue("", 351, Html.DisplayFor(model => model.ImageName), 351, 42, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(397, 20, true);
            WriteLiteral("\r\n\r\n\r\n\r\n        <p> ");
            EndContext();
            BeginContext(418, 43, false);
#line 20 "E:\Fax\Programiranje\C#\GameReviews\Web\Views\Posts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(461, 31, true);
            WriteLiteral("</p>\r\n\r\n\r\n\r\n        <p>Rating: ");
            EndContext();
            BeginContext(493, 38, false);
#line 24 "E:\Fax\Programiranje\C#\GameReviews\Web\Views\Posts\Details.cshtml"
              Write(Html.DisplayFor(model => model.Rating));

#line default
#line hidden
            EndContext();
            BeginContext(531, 50, true);
            WriteLiteral("</p>\r\n\r\n        <br/>\r\n        <h4>Comments</h4>\r\n");
            EndContext();
#line 28 "E:\Fax\Programiranje\C#\GameReviews\Web\Views\Posts\Details.cshtml"
         foreach (var c in Model.Comments)
        {

#line default
#line hidden
            BeginContext(636, 69, true);
            WriteLiteral("            <div class=\"row\">\r\n                <p class=\"text-info\"> ");
            EndContext();
            BeginContext(706, 11, false);
#line 31 "E:\Fax\Programiranje\C#\GameReviews\Web\Views\Posts\Details.cshtml"
                                 Write(c.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(717, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(719, 10, false);
#line 31 "E:\Fax\Programiranje\C#\GameReviews\Web\Views\Posts\Details.cshtml"
                                              Write(c.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(729, 15, true);
            WriteLiteral(" </p>:&nbsp;<p>");
            EndContext();
            BeginContext(745, 6, false);
#line 31 "E:\Fax\Programiranje\C#\GameReviews\Web\Views\Posts\Details.cshtml"
                                                                        Write(c.Text);

#line default
#line hidden
            EndContext();
            BeginContext(751, 48, true);
            WriteLiteral("</p>\r\n\r\n            </div>\r\n            <hr />\r\n");
            EndContext();
#line 35 "E:\Fax\Programiranje\C#\GameReviews\Web\Views\Posts\Details.cshtml"
        }

#line default
#line hidden
            BeginContext(810, 35, true);
            WriteLiteral("\r\n\r\n    </div>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(846, 68, false);
#line 41 "E:\Fax\Programiranje\C#\GameReviews\Web\Views\Posts\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(914, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(922, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3989470d5ac0357b6873b669cd030c45090eba979237", async() => {
                BeginContext(944, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(960, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Application.DTO.GetOnePostDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
