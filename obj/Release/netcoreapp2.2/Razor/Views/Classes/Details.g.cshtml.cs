#pragma checksum "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\Classes\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e59cc3297178e7950fe5318070d225c072491f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Classes_Details), @"mvc.1.0.view", @"/Views/Classes/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Classes/Details.cshtml", typeof(AspNetCore.Views_Classes_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e59cc3297178e7950fe5318070d225c072491f4", @"/Views/Classes/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4035b931494fa1549d6ea6f2e0dd8aa05ecfb9a6", @"/Views/_ViewImports.cshtml")]
    public class Views_Classes_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<School.Models.ViewModels.ClassDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Students", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\Classes\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#line 6 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\Classes\Details.cshtml"
  
    string TeacherFullName;
    if (Model.Teacher == null)
    {
        TeacherFullName = "No Teacher";
    }
    else
    {
        TeacherFullName = Model.Teacher.FullName;
    }

#line default
#line hidden
            BeginContext(343, 24, true);
            WriteLiteral("<h1 class=\"text-center\">");
            EndContext();
            BeginContext(368, 16, false);
#line 17 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\Classes\Details.cshtml"
                   Write(Model.Class.Name);

#line default
#line hidden
            EndContext();
            BeginContext(384, 204, true);
            WriteLiteral("</h1>\r\n<div class=\"row\">\r\n    <div class=\"row justify-content-around col-md-8 mb-2\">\r\n        <div class=\"col-4\">\r\n            <div class=\"m-1 jumbotron2 bg-white class-details-item\">\r\n                <p>");
            EndContext();
            BeginContext(589, 15, false);
#line 22 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\Classes\Details.cshtml"
              Write(TeacherFullName);

#line default
#line hidden
            EndContext();
            BeginContext(604, 193, true);
            WriteLiteral("</p>\r\n                <p>Teacher</p>\r\n            </div>\r\n        </div>\r\n        <div class=\"col-4\">\r\n            <div class=\"m-1 jumbotron2 bg-white class-details-item\">\r\n                <h1>");
            EndContext();
            BeginContext(798, 22, false);
#line 28 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\Classes\Details.cshtml"
               Write(Model.NumberOfStudents);

#line default
#line hidden
            EndContext();
            BeginContext(820, 231, true);
            WriteLiteral("</h1>\r\n                <p>Numer of students</p>\r\n            </div>\r\n        </div>\r\n        <div class=\"col-4\">\r\n            <div class=\"m-1 jumbotron2 bg-white class-details-item \">\r\n                <h1 class=\"font-weight-bold \">");
            EndContext();
            BeginContext(1052, 16, false);
#line 34 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\Classes\Details.cshtml"
                                         Write(Model.AverageAge);

#line default
#line hidden
            EndContext();
            BeginContext(1068, 376, true);
            WriteLiteral(@"</h1>
                <p>Average Age</p>
            </div>
        </div>
    </div>
    <div class=""col-12 col-md-4 student-side"">
        <h2>Students</h2>
        <table class=""table table-stripped table-hover table-bordered"" id=""students"">
            <tr id=""head"">
                <th>Student Name</th>
                <th>Attendance</th>
            </tr>
");
            EndContext();
#line 46 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\Classes\Details.cshtml"
             foreach (var student in Model.Students)
            {

#line default
#line hidden
            BeginContext(1513, 19, true);
            WriteLiteral("                <tr");
            EndContext();
            BeginWriteAttribute("studentid", " studentid=\"", 1532, "\"", 1555, 1);
#line 48 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\Classes\Details.cshtml"
WriteAttributeValue("", 1544, student.Id, 1544, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1556, 27, true);
            WriteLiteral(">\r\n                    <td>");
            EndContext();
            BeginContext(1583, 98, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e59cc3297178e7950fe5318070d225c072491f48076", async() => {
                BeginContext(1661, 16, false);
#line 49 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\Classes\Details.cshtml"
                                                                                                Write(student.FullName);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 49 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\Classes\Details.cshtml"
                                                                            WriteLiteral(student.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1681, 61, true);
            WriteLiteral("</td>\r\n                    <td></td>\r\n                </tr>\r\n");
            EndContext();
#line 52 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\Classes\Details.cshtml"
            }

#line default
#line hidden
            BeginContext(1757, 42, true);
            WriteLiteral("\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(1816, 1163, true);
                WriteLiteral(@"
    <script>
        const loadAttendance = function () {
            const trs = document.querySelectorAll('#students tr');
            $('#test').innerHTML = location.hostname;
            trs.forEach((tr) => {
                if (tr.id == 'head') return;
                const id = tr.getAttribute('studentid');

                $.ajax({
                    method: 'GET',
                    url: location.origin + '/api/attendances/getattendancetoday/' + id,
                    statusCode: {
                        ""200"": function (data, textStatus, jqXHR) {
                            if (data.present)
                                tr.children[1].innerHTML = 'Present';
                            else
                                tr.children[1].innerHTML = 'Absent';
                        },
                        ""204"": function (data, textStatus, jqXHR) {
                            tr.children[1].innerHTML = 'No attendance taken';
                        }
                  ");
                WriteLiteral("  }\r\n                });\r\n            });\r\n        };\r\n        $(function () {\r\n            loadAttendance();\r\n        });\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(2980, 1, true);
            WriteLiteral(" ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<School.Models.ViewModels.ClassDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591