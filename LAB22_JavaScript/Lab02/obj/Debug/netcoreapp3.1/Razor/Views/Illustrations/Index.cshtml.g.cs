#pragma checksum "C:\Users\majas\OneDrive\ElectricalEnginering\7_semester\GUI - GUI Programering\GUI_2020_Exercises\LAB22_JavaScript\Lab02\Views\Illustrations\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8af9bb1e7dd05d5ba338278deecdd07008656b95"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Illustrations_Index), @"mvc.1.0.view", @"/Views/Illustrations/Index.cshtml")]
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
#line 1 "C:\Users\majas\OneDrive\ElectricalEnginering\7_semester\GUI - GUI Programering\GUI_2020_Exercises\LAB22_JavaScript\Lab02\Views\_ViewImports.cshtml"
using Lab02;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\majas\OneDrive\ElectricalEnginering\7_semester\GUI - GUI Programering\GUI_2020_Exercises\LAB22_JavaScript\Lab02\Views\_ViewImports.cshtml"
using Lab02.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8af9bb1e7dd05d5ba338278deecdd07008656b95", @"/Views/Illustrations/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"259858fe82e1b7b6a42c3f31195dabd25904ef77", @"/Views/_ViewImports.cshtml")]
    public class Views_Illustrations_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Lab02.Models.Illustration>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Illustration.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("as-append-version", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\majas\OneDrive\ElectricalEnginering\7_semester\GUI - GUI Programering\GUI_2020_Exercises\LAB22_JavaScript\Lab02\Views\Illustrations\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<p href=\"#\" data-toggle=\"tooltip\" title=\"Hooray!\"> When a mind has begun to wander, let it go and look downunder. For then you might find a thing that takes you on and on again.</p>\r\n");
#nullable restore
#line 9 "C:\Users\majas\OneDrive\ElectricalEnginering\7_semester\GUI - GUI Programering\GUI_2020_Exercises\LAB22_JavaScript\Lab02\Views\Illustrations\Index.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>");
#nullable restore
#line 11 "C:\Users\majas\OneDrive\ElectricalEnginering\7_semester\GUI - GUI Programering\GUI_2020_Exercises\LAB22_JavaScript\Lab02\Views\Illustrations\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <p class=\"details\">\r\n        <a");
            BeginWriteAttribute("id", " id=\"", 400, "\"", 455, 1);
#nullable restore
#line 13 "C:\Users\majas\OneDrive\ElectricalEnginering\7_semester\GUI - GUI Programering\GUI_2020_Exercises\LAB22_JavaScript\Lab02\Views\Illustrations\Index.cshtml"
WriteAttributeValue("", 405, Html.DisplayFor(modelItem => item.IllustrationId), 405, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 456, "\"", 507, 1);
#nullable restore
#line 13 "C:\Users\majas\OneDrive\ElectricalEnginering\7_semester\GUI - GUI Programering\GUI_2020_Exercises\LAB22_JavaScript\Lab02\Views\Illustrations\Index.cshtml"
WriteAttributeValue("", 463, Html.DisplayFor(modelItem => item.ImageUrl), 463, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> <img");
            BeginWriteAttribute("src", " src=\"", 514, "\"", 564, 1);
#nullable restore
#line 13 "C:\Users\majas\OneDrive\ElectricalEnginering\7_semester\GUI - GUI Programering\GUI_2020_Exercises\LAB22_JavaScript\Lab02\Views\Illustrations\Index.cshtml"
WriteAttributeValue("", 520, Html.DisplayFor(modelItem => item.ImageUrl), 520, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"312\" height=\"192\" alt=\"lady\" /></a>\r\n        <br>\r\n        ");
#nullable restore
#line 15 "C:\Users\majas\OneDrive\ElectricalEnginering\7_semester\GUI - GUI Programering\GUI_2020_Exercises\LAB22_JavaScript\Lab02\Views\Illustrations\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n");
#nullable restore
#line 17 "C:\Users\majas\OneDrive\ElectricalEnginering\7_semester\GUI - GUI Programering\GUI_2020_Exercises\LAB22_JavaScript\Lab02\Views\Illustrations\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("<script>\r\n    $(document).ready(function () {\r\n        $(\'[data-toggle=\"tooltip\"]\').tooltip();\r\n    });\r\n</script>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8af9bb1e7dd05d5ba338278deecdd07008656b957570", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Lab02.Models.Illustration>> Html { get; private set; }
    }
}
#pragma warning restore 1591
