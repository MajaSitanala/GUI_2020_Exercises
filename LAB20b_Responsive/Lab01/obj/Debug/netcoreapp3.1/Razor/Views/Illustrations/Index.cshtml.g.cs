#pragma checksum "C:\Users\majas\OneDrive\ElectricalEnginering\7_semester\GUI - GUI Programering\GUI_2020_Exercises\LAB20b_Responsive\Lab01\Views\Illustrations\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ad1f641074959fbdd0ad128dbeef64e909e4ed8"
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
#line 1 "C:\Users\majas\OneDrive\ElectricalEnginering\7_semester\GUI - GUI Programering\GUI_2020_Exercises\LAB20b_Responsive\Lab01\Views\_ViewImports.cshtml"
using Lab01;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\majas\OneDrive\ElectricalEnginering\7_semester\GUI - GUI Programering\GUI_2020_Exercises\LAB20b_Responsive\Lab01\Views\_ViewImports.cshtml"
using Lab01.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ad1f641074959fbdd0ad128dbeef64e909e4ed8", @"/Views/Illustrations/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9ffc6741a75fda2a4fbfa7539e966ba63cc15f0", @"/Views/_ViewImports.cshtml")]
    public class Views_Illustrations_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Lab01.Models.Illustration>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\majas\OneDrive\ElectricalEnginering\7_semester\GUI - GUI Programering\GUI_2020_Exercises\LAB20b_Responsive\Lab01\Views\Illustrations\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_IlustrationView.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<d> When a mind has begun to wander, let it go and look downunder. For then you might find a thing that takes you on and on again.</d>\r\n");
#nullable restore
#line 8 "C:\Users\majas\OneDrive\ElectricalEnginering\7_semester\GUI - GUI Programering\GUI_2020_Exercises\LAB20b_Responsive\Lab01\Views\Illustrations\Index.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>");
#nullable restore
#line 10 "C:\Users\majas\OneDrive\ElectricalEnginering\7_semester\GUI - GUI Programering\GUI_2020_Exercises\LAB20b_Responsive\Lab01\Views\Illustrations\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <p class=\"details\">\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 405, "\"", 456, 1);
#nullable restore
#line 12 "C:\Users\majas\OneDrive\ElectricalEnginering\7_semester\GUI - GUI Programering\GUI_2020_Exercises\LAB20b_Responsive\Lab01\Views\Illustrations\Index.cshtml"
WriteAttributeValue("", 412, Html.DisplayFor(modelItem => item.ImageUrl), 412, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> <img");
            BeginWriteAttribute("src", " src=\"", 463, "\"", 513, 1);
#nullable restore
#line 12 "C:\Users\majas\OneDrive\ElectricalEnginering\7_semester\GUI - GUI Programering\GUI_2020_Exercises\LAB20b_Responsive\Lab01\Views\Illustrations\Index.cshtml"
WriteAttributeValue("", 469, Html.DisplayFor(modelItem => item.ImageUrl), 469, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"312\" height=\"192\" alt=\"lady\" /></a>\r\n        <br>");
#nullable restore
#line 13 "C:\Users\majas\OneDrive\ElectricalEnginering\7_semester\GUI - GUI Programering\GUI_2020_Exercises\LAB20b_Responsive\Lab01\Views\Illustrations\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n");
#nullable restore
#line 15 "C:\Users\majas\OneDrive\ElectricalEnginering\7_semester\GUI - GUI Programering\GUI_2020_Exercises\LAB20b_Responsive\Lab01\Views\Illustrations\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Lab01.Models.Illustration>> Html { get; private set; }
    }
}
#pragma warning restore 1591
