#pragma checksum "C:\Projects\toolsfornet\Exam-answerWeb\Views\Shared\_ProgressPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d96ad41d9c353e53cf62e411e3fd12d3be08bc71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ProgressPartial), @"mvc.1.0.view", @"/Views/Shared/_ProgressPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_ProgressPartial.cshtml", typeof(AspNetCore.Views_Shared__ProgressPartial))]
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
#line 1 "C:\Projects\toolsfornet\Exam-answerWeb\Views\_ViewImports.cshtml"
using Exam_answerWeb;

#line default
#line hidden
#line 2 "C:\Projects\toolsfornet\Exam-answerWeb\Views\_ViewImports.cshtml"
using Exam_answerWeb.Models;

#line default
#line hidden
#line 3 "C:\Projects\toolsfornet\Exam-answerWeb\Views\_ViewImports.cshtml"
using Exam_answerWeb.Infrastructure;

#line default
#line hidden
#line 4 "C:\Projects\toolsfornet\Exam-answerWeb\Views\_ViewImports.cshtml"
using Kendo.Mvc.UI.Fluent;

#line default
#line hidden
#line 5 "C:\Projects\toolsfornet\Exam-answerWeb\Views\_ViewImports.cshtml"
using Kendo.Mvc.UI;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d96ad41d9c353e53cf62e411e3fd12d3be08bc71", @"/Views/Shared/_ProgressPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bee3447070987ca46eb03bbeb43d7bf40055dde5", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ProgressPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Projects\toolsfornet\Exam-answerWeb\Views\Shared\_ProgressPartial.cshtml"
   if (ViewData["current"] != null || ViewData["max"] != null)
    {

#line default
#line hidden
            BeginContext(71, 309, true);
            WriteLiteral(@"    <div style=""text-align:center"">
        <div class=""az-100"" style=""width:200px""></div>
        <script>
            $(document).ready(function () {
                var pb = $(""div.az-100"").kendoProgressBar({
                    type: ""percent"",
                    min: 1,
                    max: ");
            EndContext();
            BeginContext(382, 15, false);
#line 10 "C:\Projects\toolsfornet\Exam-answerWeb\Views\Shared\_ProgressPartial.cshtml"
                     Write(ViewData["max"]);

#line default
#line hidden
            EndContext();
            BeginContext(398, 30, true);
            WriteLiteral(",\r\n                    value: ");
            EndContext();
            BeginContext(430, 19, false);
#line 11 "C:\Projects\toolsfornet\Exam-answerWeb\Views\Shared\_ProgressPartial.cshtml"
                       Write(ViewData["current"]);

#line default
#line hidden
            EndContext();
            BeginContext(450, 95, true);
            WriteLiteral("\r\n            }).data(\"kendoProgressBar\");\r\n\r\n                pb.progressStatus.text(\"Question ");
            EndContext();
            BeginContext(547, 19, false);
#line 14 "C:\Projects\toolsfornet\Exam-answerWeb\Views\Shared\_ProgressPartial.cshtml"
                                             Write(ViewData["current"]);

#line default
#line hidden
            EndContext();
            BeginContext(567, 3, true);
            WriteLiteral(" / ");
            EndContext();
            BeginContext(572, 15, false);
#line 14 "C:\Projects\toolsfornet\Exam-answerWeb\Views\Shared\_ProgressPartial.cshtml"
                                                                      Write(ViewData["max"]);

#line default
#line hidden
            EndContext();
            BeginContext(588, 53, true);
            WriteLiteral("\");\r\n            });\r\n        </script>\r\n    </div>\r\n");
            EndContext();
#line 18 "C:\Projects\toolsfornet\Exam-answerWeb\Views\Shared\_ProgressPartial.cshtml"
    }

#line default
#line hidden
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