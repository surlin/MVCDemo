#pragma checksum "C:\Users\Kaushal\source\repos\CourseCatalogueMVCDemo\CourseCatalogueMVCDemo\Views\Course\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "607a3045d2dbd11620daea2974fe1125a4ad7264"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_List), @"mvc.1.0.view", @"/Views/Course/List.cshtml")]
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
#line 1 "C:\Users\Kaushal\source\repos\CourseCatalogueMVCDemo\CourseCatalogueMVCDemo\Views\_ViewImports.cshtml"
using CourseCatalogueMVCDemo.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"607a3045d2dbd11620daea2974fe1125a4ad7264", @"/Views/Course/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6a6fd51ff84aeaae97e468b47008c008a4cd8df", @"/Views/_ViewImports.cshtml")]
    public class Views_Course_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CourseListVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    <h1>");
#nullable restore
#line 5 "C:\Users\Kaushal\source\repos\CourseCatalogueMVCDemo\CourseCatalogueMVCDemo\Views\Course\List.cshtml"
   Write(Model.SeletedCategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<hr />\r\n\r\n");
#nullable restore
#line 8 "C:\Users\Kaushal\source\repos\CourseCatalogueMVCDemo\CourseCatalogueMVCDemo\Views\Course\List.cshtml"
     foreach (var course in Model.Courses)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card\" style=\"width:18rem;\">\r\n            <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 332, "\"", 354, 1);
#nullable restore
#line 11 "C:\Users\Kaushal\source\repos\CourseCatalogueMVCDemo\CourseCatalogueMVCDemo\Views\Course\List.cshtml"
WriteAttributeValue("", 338, course.ImageUrl, 338, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 355, "\"", 374, 1);
#nullable restore
#line 11 "C:\Users\Kaushal\source\repos\CourseCatalogueMVCDemo\CourseCatalogueMVCDemo\Views\Course\List.cshtml"
WriteAttributeValue("", 361, course.Title, 361, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\">");
#nullable restore
#line 13 "C:\Users\Kaushal\source\repos\CourseCatalogueMVCDemo\CourseCatalogueMVCDemo\Views\Course\List.cshtml"
                                  Write(course.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <h6 class=\"card-subtitle\">");
#nullable restore
#line 14 "C:\Users\Kaushal\source\repos\CourseCatalogueMVCDemo\CourseCatalogueMVCDemo\Views\Course\List.cshtml"
                                     Write(course.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                <p class=\"card-text\">");
#nullable restore
#line 15 "C:\Users\Kaushal\source\repos\CourseCatalogueMVCDemo\CourseCatalogueMVCDemo\Views\Course\List.cshtml"
                                Write(course.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <a href=\"#\" class=\"btn btn-primary\">Add to Cart</a>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 19 "C:\Users\Kaushal\source\repos\CourseCatalogueMVCDemo\CourseCatalogueMVCDemo\Views\Course\List.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CourseListVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
