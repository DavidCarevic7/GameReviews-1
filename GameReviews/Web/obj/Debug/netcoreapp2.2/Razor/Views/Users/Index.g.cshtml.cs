#pragma checksum "E:\Fax\Programiranje\C#\GameReviews\Web\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03886f53c27172db3957e96074854695f98ff0fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Index), @"mvc.1.0.view", @"/Views/Users/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/Index.cshtml", typeof(AspNetCore.Views_Users_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03886f53c27172db3957e96074854695f98ff0fc", @"/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b0619e1a302f0598271da1847e697c39d57b88", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Application.DTO.GetUserDto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Fax\Programiranje\C#\GameReviews\Web\Views\Users\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(91, 18, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n");
            EndContext();
#line 8 "E:\Fax\Programiranje\C#\GameReviews\Web\Views\Users\Index.cshtml"
 if (TempData["Error"] != null)
{

#line default
#line hidden
            BeginContext(145, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(149, 17, false);
#line 10 "E:\Fax\Programiranje\C#\GameReviews\Web\Views\Users\Index.cshtml"
Write(TempData["Error"]);

#line default
#line hidden
            EndContext();
            BeginContext(166, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 11 "E:\Fax\Programiranje\C#\GameReviews\Web\Views\Users\Index.cshtml"
}

#line default
#line hidden
            BeginContext(175, 11, true);
            WriteLiteral("\r\n<p>\r\n    ");
            EndContext();
            BeginContext(186, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03886f53c27172db3957e96074854695f98ff0fc4500", async() => {
                BeginContext(209, 10, true);
                WriteLiteral("Create New");
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
            BeginContext(223, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(316, 38, false);
#line 20 "E:\Fax\Programiranje\C#\GameReviews\Web\Views\Users\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(354, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(410, 41, false);
#line 23 "E:\Fax\Programiranje\C#\GameReviews\Web\Views\Users\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(451, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(507, 45, false);
#line 26 "E:\Fax\Programiranje\C#\GameReviews\Web\Views\Users\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(552, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(608, 44, false);
#line 29 "E:\Fax\Programiranje\C#\GameReviews\Web\Views\Users\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(652, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(708, 42, false);
#line 32 "E:\Fax\Programiranje\C#\GameReviews\Web\Views\Users\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RoleId));

#line default
#line hidden
            EndContext();
            BeginContext(750, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(806, 45, false);
#line 35 "E:\Fax\Programiranje\C#\GameReviews\Web\Views\Users\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CreatedOn));

#line default
#line hidden
            EndContext();
            BeginContext(851, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(907, 46, false);
#line 38 "E:\Fax\Programiranje\C#\GameReviews\Web\Views\Users\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ModifiedOn));

#line default
#line hidden
            EndContext();
            BeginContext(953, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1009, 44, false);
#line 41 "E:\Fax\Programiranje\C#\GameReviews\Web\Views\Users\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RoleName));

#line default
#line hidden
            EndContext();
            BeginContext(1053, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 47 "E:\Fax\Programiranje\C#\GameReviews\Web\Views\Users\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1188, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1249, 37, false);
#line 51 "E:\Fax\Programiranje\C#\GameReviews\Web\Views\Users\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1286, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1354, 40, false);
#line 54 "E:\Fax\Programiranje\C#\GameReviews\Web\Views\Users\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1394, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1462, 44, false);
#line 57 "E:\Fax\Programiranje\C#\GameReviews\Web\Views\Users\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(1506, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1574, 43, false);
#line 60 "E:\Fax\Programiranje\C#\GameReviews\Web\Views\Users\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(1617, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1685, 41, false);
#line 63 "E:\Fax\Programiranje\C#\GameReviews\Web\Views\Users\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.RoleId));

#line default
#line hidden
            EndContext();
            BeginContext(1726, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1794, 44, false);
#line 66 "E:\Fax\Programiranje\C#\GameReviews\Web\Views\Users\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CreatedOn));

#line default
#line hidden
            EndContext();
            BeginContext(1838, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1906, 45, false);
#line 69 "E:\Fax\Programiranje\C#\GameReviews\Web\Views\Users\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ModifiedOn));

#line default
#line hidden
            EndContext();
            BeginContext(1951, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2019, 43, false);
#line 72 "E:\Fax\Programiranje\C#\GameReviews\Web\Views\Users\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.RoleName));

#line default
#line hidden
            EndContext();
            BeginContext(2062, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2130, 53, false);
#line 75 "E:\Fax\Programiranje\C#\GameReviews\Web\Views\Users\Index.cshtml"
               Write(Html.ActionLink("Edit", "Edit", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(2183, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(2208, 59, false);
#line 76 "E:\Fax\Programiranje\C#\GameReviews\Web\Views\Users\Index.cshtml"
               Write(Html.ActionLink("Details", "Details", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(2267, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(2292, 57, false);
#line 77 "E:\Fax\Programiranje\C#\GameReviews\Web\Views\Users\Index.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(2349, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 80 "E:\Fax\Programiranje\C#\GameReviews\Web\Views\Users\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2404, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Application.DTO.GetUserDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
