#pragma checksum "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\AcademicSections\AddAcademicSection.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "200f2deb8fddfd221405c8a46338a4e5d339fe36"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AcademicSections_AddAcademicSection), @"mvc.1.0.view", @"/Views/AcademicSections/AddAcademicSection.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AcademicSections/AddAcademicSection.cshtml", typeof(AspNetCore.Views_AcademicSections_AddAcademicSection))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"200f2deb8fddfd221405c8a46338a4e5d339fe36", @"/Views/AcademicSections/AddAcademicSection.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4035b931494fa1549d6ea6f2e0dd8aa05ecfb9a6", @"/Views/_ViewImports.cshtml")]
    public class Views_AcademicSections_AddAcademicSection : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("academic-section-form p-3 align-self-center col-12 col-md-8"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/VanillaToasts/vanillatoasts.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/VanillaToasts/vanillatoasts.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\olaniran olawale\Documents\Visual Studio 2019\Projects\School\School-Management-Website\Views\AcademicSections\AddAcademicSection.cshtml"
  
    ViewData["Title"] = "AddAcademicSection";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(103, 164, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-12 col-sm-8 offset-sm-2 d-flex flex-column\">\r\n        <h1 class=\"text-center dark-blue\">Add Academic Section</h1>\r\n        ");
            EndContext();
            BeginContext(267, 2190, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "200f2deb8fddfd221405c8a46338a4e5d339fe366175", async() => {
                BeginContext(351, 2099, true);
                WriteLiteral(@"
            <h2>Section</h2>
            <div class=""form-group form-inline"" style=""padding-bottom: 1em;"">
                <label class=""mr-2"">start Date</label>
                <input class=""form-control"" type=""date"" name=""startDate"">
            </div>
            <div class=""form-group form-inline"" style=""padding-bottom: 1em;"">
                <label class=""mr-2"">End Date</label>
                <input class=""form-control"" type=""date"" name=""endDate"">
            </div>

            <h2>First Term</h2>
            <div class=""form-group form-inline"" style=""padding-bottom: 1em;"">
                <label class=""mr-2"">start Date</label>
                <input class=""form-control"" type=""date"" name=""firstTermStartDate"">
            </div>
            <div class=""form-group form-inline"" style=""padding-bottom: 1em;"">
                <label class=""mr-2"">End Date</label>
                <input class=""form-control"" type=""date"" name=""firstTermEndDate"">
            </div>

            <h2>Second Te");
                WriteLiteral(@"rm</h2>
            <div class=""form-group form-inline"" style=""padding-bottom: 1em;"">
                <label class=""mr-2"">start Date</label>
                <input class=""form-control"" type=""date"" name=""secondTermStartDate"">
            </div>
            <div class=""form-group form-inline"" style=""padding-bottom: 1em;"">
                <label class=""mr-2"">End Date</label>
                <input class=""form-control"" type=""date"" name=""secondTermEndDate"">
            </div>

            <h2>Third Term</h2>
            <div class=""form-group form-inline"" style=""padding-bottom: 1em;"">
                <label class=""mr-2"">start Date</label>
                <input class=""form-control"" type=""date"" name=""thirdTermStartDate"">
            </div>
            <div class=""form-group form-inline"" style=""padding-bottom: 1em;"">
                <label class=""mr-2"">End Date</label>
                <input class=""form-control"" type=""date"" name=""thirdTermEndDate"">
            </div>
            <button id=""submit");
                WriteLiteral("\" class=\"btn btn-primary\">Submit</button>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
            BeginContext(2457, 24, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("styles", async() => {
                BeginContext(2497, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2503, 70, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "200f2deb8fddfd221405c8a46338a4e5d339fe3610267", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2573, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            DefineSection("scripts", async() => {
                BeginContext(2595, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2601, 60, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "200f2deb8fddfd221405c8a46338a4e5d339fe3611800", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2661, 2479, true);
                WriteLiteral(@"
    <script>
        $(function () {
            $('#submit').click(() => {
                let form = document.getElementById('form');
                let startDate = form.startDate.value;
                let endDate = form.endDate.value;
                if (startDate == """" || endDate == """") {
                    let toast = VanillaToasts.create({
                                title: 'Fill dated',
                                text: 'Enter both start and end date',
                                type: 'warning',
                                timeout: 5000
                    });
                    return false;
                }
                let data = {
                    startDate,
                    endDate,
                    firstTerm: {
                        startDate: form.firstTermStartDate.value,
                        endDate: form.firstTermEndDate.value,

                    },
                    secondTerm: {
                        startDate: form.seco");
                WriteLiteral(@"ndTermStartDate.value,
                        endDate: form.secondTermEndDate.value,
                    },
                    thirdTerm: {
                        startDate: form.thirdTermStartDate.value,
                        endDate: form.thirdTermEndDate.value,
                    }

                }
                $.post({
                    contentType: 'application/json',
                    url: `${location.origin}/api/academicsections`,
                    data: JSON.stringify( data),
                    statusCode: {
                        ""400"": (data, textStatus, jqXHR) => {
                            let toast = VanillaToasts.create({
                                title: 'Error',
                                text: data.responseText,
                                type: 'error',
                                timeout: 6000
                            });
                        },
                        ""201"": () => {
                            let toast = ");
                WriteLiteral(@"VanillaToasts.create({
                                title: 'Successful',
                                text: 'Academic section created succesfully',
                                type: 'success',
                                timeout: 5000
                            });
                        }
                    }
                })
                return false;
            })
        })
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
