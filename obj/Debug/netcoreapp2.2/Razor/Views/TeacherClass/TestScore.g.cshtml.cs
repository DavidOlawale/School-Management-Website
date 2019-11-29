#pragma checksum "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\TestScore.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3072a185627d0a621777fe8430dffcffe06a5515"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TeacherClass_TestScore), @"mvc.1.0.view", @"/Views/TeacherClass/TestScore.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TeacherClass/TestScore.cshtml", typeof(AspNetCore.Views_TeacherClass_TestScore))]
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
#line 1 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\_ViewImports.cshtml"
using School;

#line default
#line hidden
#line 2 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\_ViewImports.cshtml"
using School.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3072a185627d0a621777fe8430dffcffe06a5515", @"/Views/TeacherClass/TestScore.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4035b931494fa1549d6ea6f2e0dd8aa05ecfb9a6", @"/Views/_ViewImports.cshtml")]
    public class Views_TeacherClass_TestScore : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<School.Models.Dtos.AllDepartmentsTests>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\TestScore.cshtml"
  
    ViewData["Title"] = "ExamScore";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(139, 502, true);
            WriteLiteral(@"
<ul class=""nav nav-tabs"" role=""tablist"">
    <li class=""nav-item"">
        <a class=""nav-link active"" data-toggle=""tab"" href=""#science"">Science</a>
    </li>
    <li class=""nav-item"">
        <a class=""nav-link"" data-toggle=""tab"" href=""#commercial"">Commercial</a>
    </li>
    <li class=""nav-item"">
        <a class=""nav-link"" data-toggle=""tab"" href=""#art"">Art</a>
    </li>
</ul>

<!-- Tab panes -->
<div class=""tab-content"">
    <div id=""science"" class=""container tab-pane active"">
");
            EndContext();
#line 22 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\TestScore.cshtml"
         if (Model.ScienceTests[0].Tests.Count == 0)
        {

#line default
#line hidden
            BeginContext(706, 89, true);
            WriteLiteral("            <h2 class=\"text-center opacity-50 p-t-3em\">Test score not yet uploaded</h2>\r\n");
            EndContext();
#line 25 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\TestScore.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(831, 204, true);
            WriteLiteral("            <h1 class=\"text-center p-t-3em\">Exam Scores</h1>\r\n            <table class=\"table table-responsive\">\r\n                <thead>\r\n                    <tr>\r\n                        <td>Name</td>\r\n");
            EndContext();
#line 33 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\TestScore.cshtml"
                         foreach (var test in Model.ScienceTests[0].Tests)
                        {

#line default
#line hidden
            BeginContext(1138, 32, true);
            WriteLiteral("                            <td>");
            EndContext();
            BeginContext(1171, 35, false);
#line 35 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\TestScore.cshtml"
                           Write(test.DepartmentSubject.Subject.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1206, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 36 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\TestScore.cshtml"
                        }

#line default
#line hidden
            BeginContext(1240, 78, true);
            WriteLiteral("                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
            EndContext();
#line 40 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\TestScore.cshtml"
                     foreach (var StudentTest in Model.ScienceTests)
                    {

#line default
#line hidden
            BeginContext(1411, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(1474, 23, false);
#line 43 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\TestScore.cshtml"
                           Write(StudentTest.StudentName);

#line default
#line hidden
            EndContext();
            BeginContext(1497, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 44 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\TestScore.cshtml"
                             foreach (var test in StudentTest.Tests)
                            {

#line default
#line hidden
            BeginContext(1605, 36, true);
            WriteLiteral("                                <td>");
            EndContext();
            BeginContext(1642, 10, false);
#line 46 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\TestScore.cshtml"
                               Write(test.Score);

#line default
#line hidden
            EndContext();
            BeginContext(1652, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 47 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\TestScore.cshtml"
                            }

#line default
#line hidden
            BeginContext(1690, 31, true);
            WriteLiteral("                        </tr>\r\n");
            EndContext();
#line 49 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\TestScore.cshtml"
                    }

#line default
#line hidden
            BeginContext(1744, 48, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n");
            EndContext();
#line 52 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\TestScore.cshtml"
        }

#line default
#line hidden
            BeginContext(1803, 73, true);
            WriteLiteral("\r\n    </div>\r\n    <div id=\"commercial\" class=\"container tab-pane fade\">\r\n");
            EndContext();
#line 56 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\TestScore.cshtml"
         if (Model.CommercialTests[0].Tests.Count == 0)
        {

#line default
#line hidden
            BeginContext(1944, 89, true);
            WriteLiteral("            <h2 class=\"text-center opacity-50 p-t-3em\">Test score not yet uploaded</h2>\r\n");
            EndContext();
#line 59 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\TestScore.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(2069, 204, true);
            WriteLiteral("            <h2 class=\"text-center p-t-3em\">Exam Scores</h2>\r\n            <table class=\"table table-responsive\">\r\n                <thead>\r\n                    <tr>\r\n                        <td>Name</td>\r\n");
            EndContext();
#line 67 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\TestScore.cshtml"
                         foreach (var test in Model.CommercialTests[0].Tests)
                        {

#line default
#line hidden
            BeginContext(2379, 32, true);
            WriteLiteral("                            <td>");
            EndContext();
            BeginContext(2412, 35, false);
#line 69 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\TestScore.cshtml"
                           Write(test.DepartmentSubject.Subject.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2447, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 70 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\TestScore.cshtml"
                        }

#line default
#line hidden
            BeginContext(2481, 78, true);
            WriteLiteral("                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
            EndContext();
#line 74 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\TestScore.cshtml"
                     foreach (var CommercialTest in Model.CommercialTests)
                    {

#line default
#line hidden
            BeginContext(2658, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(2721, 26, false);
#line 77 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\TestScore.cshtml"
                           Write(CommercialTest.StudentName);

#line default
#line hidden
            EndContext();
            BeginContext(2747, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 78 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\TestScore.cshtml"
                             foreach (var test in CommercialTest.Tests)
                            {

#line default
#line hidden
            BeginContext(2858, 36, true);
            WriteLiteral("                                <td>");
            EndContext();
            BeginContext(2895, 10, false);
#line 80 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\TestScore.cshtml"
                               Write(test.Score);

#line default
#line hidden
            EndContext();
            BeginContext(2905, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 81 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\TestScore.cshtml"
                            }

#line default
#line hidden
            BeginContext(2943, 31, true);
            WriteLiteral("                        </tr>\r\n");
            EndContext();
#line 83 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\TestScore.cshtml"
                    }

#line default
#line hidden
            BeginContext(2997, 48, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n");
            EndContext();
#line 86 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\TestScore.cshtml"
        }

#line default
#line hidden
            BeginContext(3056, 66, true);
            WriteLiteral("\r\n    </div>\r\n    <div id=\"art\" class=\"container tab-pane fade\">\r\n");
            EndContext();
#line 90 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\TestScore.cshtml"
         if (Model.ArtTests[0].Tests.Count == 0)
        {

#line default
#line hidden
            BeginContext(3183, 89, true);
            WriteLiteral("            <h2 class=\"text-center opacity-50 p-t-3em\">Test score not yet uploaded</h2>\r\n");
            EndContext();
#line 93 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\TestScore.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(3308, 196, true);
            WriteLiteral("            <h1 class=\"text-center\">Exam Scores</h1>\r\n            <table class=\"table table-responsive\">\r\n                <thead>\r\n                    <tr>\r\n                        <td>Name</td>\r\n");
            EndContext();
#line 101 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\TestScore.cshtml"
                         foreach (var test in Model.ArtTests[0].Tests)
                        {

#line default
#line hidden
            BeginContext(3603, 32, true);
            WriteLiteral("                            <td>");
            EndContext();
            BeginContext(3636, 35, false);
#line 103 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\TestScore.cshtml"
                           Write(test.DepartmentSubject.Subject.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3671, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 104 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\TestScore.cshtml"
                        }

#line default
#line hidden
            BeginContext(3705, 78, true);
            WriteLiteral("                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
            EndContext();
#line 108 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\TestScore.cshtml"
                     foreach (var ArtTest in Model.ArtTests)
                    {

#line default
#line hidden
            BeginContext(3868, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(3931, 19, false);
#line 111 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\TestScore.cshtml"
                           Write(ArtTest.StudentName);

#line default
#line hidden
            EndContext();
            BeginContext(3950, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 112 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\TestScore.cshtml"
                             foreach (var test in ArtTest.Tests)
                            {

#line default
#line hidden
            BeginContext(4054, 36, true);
            WriteLiteral("                                <td>");
            EndContext();
            BeginContext(4091, 10, false);
#line 114 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\TestScore.cshtml"
                               Write(test.Score);

#line default
#line hidden
            EndContext();
            BeginContext(4101, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 115 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\TestScore.cshtml"
                            }

#line default
#line hidden
            BeginContext(4139, 31, true);
            WriteLiteral("                        </tr>\r\n");
            EndContext();
#line 117 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\TestScore.cshtml"
                    }

#line default
#line hidden
            BeginContext(4193, 48, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n");
            EndContext();
#line 120 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\TestScore.cshtml"
        }

#line default
#line hidden
            BeginContext(4252, 20, true);
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<School.Models.Dtos.AllDepartmentsTests> Html { get; private set; }
    }
}
#pragma warning restore 1591