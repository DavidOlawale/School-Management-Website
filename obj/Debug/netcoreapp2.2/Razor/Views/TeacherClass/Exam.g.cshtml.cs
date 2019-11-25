#pragma checksum "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\Exam.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6144a01add0abd569e2f6bead224d8a03463cd8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TeacherClass_Exam), @"mvc.1.0.view", @"/Views/TeacherClass/Exam.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TeacherClass/Exam.cshtml", typeof(AspNetCore.Views_TeacherClass_Exam))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6144a01add0abd569e2f6bead224d8a03463cd8", @"/Views/TeacherClass/Exam.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4035b931494fa1549d6ea6f2e0dd8aa05ecfb9a6", @"/Views/_ViewImports.cshtml")]
    public class Views_TeacherClass_Exam : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<School.Models.ViewModels.ScoreRecordViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/VanillaToasts/vanillatoasts.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/VanillaToasts/vanillatoasts.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\Exam.cshtml"
  
    ViewData["Title"] = "Exam";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(141, 519, true);
            WriteLiteral(@"
<h1>Exam Score</h1>
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

<div class=""tab-content"">
    <div id=""science"" class=""tab-pane active"">
        <h3>Science</h3>
");
            EndContext();
#line 23 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\Exam.cshtml"
         if (Model.ScienceSubjectsScoreIsUploaded)
        {

#line default
#line hidden
            BeginContext(723, 37, true);
            WriteLiteral("            <h2>Score uploaded</h2>\r\n");
            EndContext();
#line 26 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\Exam.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(796, 167, true);
            WriteLiteral("            <table class=\"table thead-dark table-responsive\" id=\"Science\">\r\n                <thead>\r\n                    <tr>\r\n                        <td>Names</td>\r\n");
            EndContext();
#line 33 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\Exam.cshtml"
                         foreach (var subject in Model.ScienceSubjects)
                        {

#line default
#line hidden
            BeginContext(1063, 32, true);
            WriteLiteral("                            <td>");
            EndContext();
            BeginContext(1096, 12, false);
#line 35 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\Exam.cshtml"
                           Write(subject.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1108, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 36 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\Exam.cshtml"
                        }

#line default
#line hidden
            BeginContext(1142, 80, true);
            WriteLiteral("\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
            EndContext();
#line 41 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\Exam.cshtml"
                     foreach (var student in Model.ScienceStudents)
                    {

#line default
#line hidden
            BeginContext(1314, 27, true);
            WriteLiteral("                        <tr");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1341, "\"", 1357, 1);
#line 43 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\Exam.cshtml"
WriteAttributeValue("", 1346, student.Id, 1346, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1358, 35, true);
            WriteLiteral(">\r\n                            <td>");
            EndContext();
            BeginContext(1394, 16, false);
#line 44 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\Exam.cshtml"
                           Write(student.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(1410, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 45 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\Exam.cshtml"
                             foreach (var subject in Model.ScienceSubjects)
                            {

#line default
#line hidden
            BeginContext(1525, 35, true);
            WriteLiteral("                                <td");
            EndContext();
            BeginWriteAttribute("subjectId", " subjectId=\"", 1560, "\"", 1583, 1);
#line 47 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\Exam.cshtml"
WriteAttributeValue("", 1572, subject.Id, 1572, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1584, 57, true);
            WriteLiteral("><input type=\"number\" size=\"3\" max=\"60\" min=\"0\" /></td>\r\n");
            EndContext();
#line 48 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\Exam.cshtml"
                            }

#line default
#line hidden
            BeginContext(1672, 31, true);
            WriteLiteral("                        </tr>\r\n");
            EndContext();
#line 50 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\Exam.cshtml"

                    }

#line default
#line hidden
            BeginContext(1728, 137, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n            <button class=\"btn btn-primary\" onclick=\"record(\'Science\')\">Submit</button>\r\n");
            EndContext();
#line 55 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\Exam.cshtml"
        }

#line default
#line hidden
            BeginContext(1876, 92, true);
            WriteLiteral("\r\n    </div>\r\n    <div id=\"commercial\" class=\"tab-pane fade\">\r\n        <h3>Commercial</h3>\r\n");
            EndContext();
#line 60 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\Exam.cshtml"
         if (Model.CommercialSubjectsScoreIsUploaded)
        {

#line default
#line hidden
            BeginContext(2034, 37, true);
            WriteLiteral("            <h2>Score uploaded</h2>\r\n");
            EndContext();
#line 63 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\Exam.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(2107, 170, true);
            WriteLiteral("            <table class=\"table table-responsive thead-dark\" id=\"Commercial\">\r\n                <thead>\r\n                    <tr>\r\n                        <td>Names</td>\r\n");
            EndContext();
#line 70 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\Exam.cshtml"
                         foreach (var subject in Model.CommercialSubjects)
                        {

#line default
#line hidden
            BeginContext(2380, 32, true);
            WriteLiteral("                            <td>");
            EndContext();
            BeginContext(2413, 12, false);
#line 72 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\Exam.cshtml"
                           Write(subject.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2425, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 73 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\Exam.cshtml"
                        }

#line default
#line hidden
            BeginContext(2459, 80, true);
            WriteLiteral("\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
            EndContext();
#line 78 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\Exam.cshtml"
                     foreach (var student in Model.CommercialStudents)
                    {

#line default
#line hidden
            BeginContext(2634, 27, true);
            WriteLiteral("                        <tr");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2661, "\"", 2677, 1);
#line 80 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\Exam.cshtml"
WriteAttributeValue("", 2666, student.Id, 2666, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2678, 35, true);
            WriteLiteral(">\r\n                            <td>");
            EndContext();
            BeginContext(2714, 16, false);
#line 81 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\Exam.cshtml"
                           Write(student.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(2730, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 82 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\Exam.cshtml"
                             foreach (var subject in Model.CommercialSubjects)
                            {

#line default
#line hidden
            BeginContext(2848, 35, true);
            WriteLiteral("                                <td");
            EndContext();
            BeginWriteAttribute("subjectId", " subjectId=\"", 2883, "\"", 2906, 1);
#line 84 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\Exam.cshtml"
WriteAttributeValue("", 2895, subject.Id, 2895, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2907, 57, true);
            WriteLiteral("><input type=\"number\" size=\"3\" max=\"60\" min=\"0\" /></td>\r\n");
            EndContext();
#line 85 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\Exam.cshtml"
                            }

#line default
#line hidden
            BeginContext(2995, 31, true);
            WriteLiteral("                        </tr>\r\n");
            EndContext();
#line 87 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\Exam.cshtml"

                    }

#line default
#line hidden
            BeginContext(3051, 140, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n            <button class=\"btn btn-primary\" onclick=\"record(\'Commercial\')\">Submit</button>\r\n");
            EndContext();
#line 92 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\Exam.cshtml"
        }

#line default
#line hidden
            BeginContext(3202, 78, true);
            WriteLiteral("\r\n    </div>\r\n    <div id=\"art\" class=\"tab-pane fade\">\r\n        <h3>Art</h3>\r\n");
            EndContext();
#line 97 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\Exam.cshtml"
         if (Model.ArtSubjectsScoreIsUploaded)
        {

#line default
#line hidden
            BeginContext(3339, 37, true);
            WriteLiteral("            <h2>Score uploaded</h2>\r\n");
            EndContext();
#line 100 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\Exam.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(3412, 163, true);
            WriteLiteral("            <table class=\"table table-responsive thead-dark\" id=\"Art\">\r\n                <thead>\r\n                    <tr>\r\n                        <td>Names</td>\r\n");
            EndContext();
#line 107 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\Exam.cshtml"
                         foreach (var subject in Model.ArtSubjects)
                        {

#line default
#line hidden
            BeginContext(3671, 32, true);
            WriteLiteral("                            <td>");
            EndContext();
            BeginContext(3704, 12, false);
#line 109 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\Exam.cshtml"
                           Write(subject.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3716, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 110 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\Exam.cshtml"
                        }

#line default
#line hidden
            BeginContext(3750, 80, true);
            WriteLiteral("\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
            EndContext();
#line 115 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\Exam.cshtml"
                     foreach (var student in Model.ArtStudents)
                    {

#line default
#line hidden
            BeginContext(3918, 27, true);
            WriteLiteral("                        <tr");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3945, "\"", 3961, 1);
#line 117 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\Exam.cshtml"
WriteAttributeValue("", 3950, student.Id, 3950, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3962, 35, true);
            WriteLiteral(">\r\n                            <td>");
            EndContext();
            BeginContext(3998, 16, false);
#line 118 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\Exam.cshtml"
                           Write(student.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(4014, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 119 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\Exam.cshtml"
                             foreach (var subject in Model.ArtSubjects)
                            {

#line default
#line hidden
            BeginContext(4125, 35, true);
            WriteLiteral("                                <td");
            EndContext();
            BeginWriteAttribute("subjectId", " subjectId=\"", 4160, "\"", 4183, 1);
#line 121 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\Exam.cshtml"
WriteAttributeValue("", 4172, subject.Id, 4172, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4184, 57, true);
            WriteLiteral("><input type=\"number\" size=\"3\" max=\"60\" min=\"0\" /></td>\r\n");
            EndContext();
#line 122 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\Exam.cshtml"
                            }

#line default
#line hidden
            BeginContext(4272, 31, true);
            WriteLiteral("                        </tr>\r\n");
            EndContext();
#line 124 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\Exam.cshtml"

                    }

#line default
#line hidden
            BeginContext(4328, 133, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n            <button class=\"btn btn-primary\" onclick=\"record(\'Art\')\">Submit</button>\r\n");
            EndContext();
#line 129 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\Exam.cshtml"
        }

#line default
#line hidden
            BeginContext(4472, 24, true);
            WriteLiteral("\r\n    </div>\r\n\r\n</div>\r\n");
            EndContext();
            DefineSection("styles", async() => {
                BeginContext(4512, 7, true);
                WriteLiteral(" \r\n    ");
                EndContext();
                BeginContext(4519, 70, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a6144a01add0abd569e2f6bead224d8a03463cd821685", async() => {
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
                EndContext();
                BeginContext(4589, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            DefineSection("scripts", async() => {
                BeginContext(4611, 7, true);
                WriteLiteral(" \r\n    ");
                EndContext();
                BeginContext(4618, 60, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6144a01add0abd569e2f6bead224d8a03463cd823219", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4678, 1287, true);
                WriteLiteral(@"
    <script>
        function record(deptName) {
            let table = document.getElementById(deptName)
            let rows = table.children[1].children //tbody > tr
            let exams = []
            Array.from(rows).forEach(row => {
                studentId = row.id
                tableDatas = Array.from(row.children).filter(td => td != row.children[0])
                tableDatas.forEach(td => {
                    let exam = {
                        studentId,
                        departmentSubjectSubjecttId: td.getAttribute('subjectId'),
                        score: td.children[0].value
                    }
                    exams.push(exam)
                })
            })
            console.table(exams)
            let data = {
                exams,
                departmentName: deptName
            }
            $.post({
                url: `${location.origin}/api/exams/postexam`,
                contentType: 'application/json',
                data: ");
                WriteLiteral(@"JSON.stringify(data),
                statusCode: {
                    '201': function (data, textStatus, XHR) {
                        VanillaToasts.create({
                            title: 'Scores Saved',
                            text: `Scores for ");
                EndContext();
                BeginContext(5966, 16, false);
#line 169 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\TeacherClass\Exam.cshtml"
                                         Write(Model.Class.Name);

#line default
#line hidden
                EndContext();
                BeginContext(5982, 215, true);
                WriteLiteral(" ${deptName} saved`,\r\n                        type: \'success\',\r\n                        timeout: \'5000\',\r\n                    });\r\n                    }\r\n                }\r\n            })\r\n        }\r\n    </script>\r\n");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<School.Models.ViewModels.ScoreRecordViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
