#pragma checksum "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\salesforce\crt-251\checkbox.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1c2be4f1d444fc8ce4475df9e9ab7887b3d1828"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_salesforce_crt_251_checkbox), @"mvc.1.0.view", @"/Views/salesforce/crt-251/checkbox.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/salesforce/crt-251/checkbox.cshtml", typeof(AspNetCore.Views_salesforce_crt_251_checkbox))]
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
#line 1 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\_ViewImports.cshtml"
using Exam_answerWeb;

#line default
#line hidden
#line 2 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\_ViewImports.cshtml"
using Exam_answerWeb.Models;

#line default
#line hidden
#line 3 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\_ViewImports.cshtml"
using Exam_answerWeb.Infrastructure;

#line default
#line hidden
#line 4 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\_ViewImports.cshtml"
using Kendo.Mvc.UI.Fluent;

#line default
#line hidden
#line 5 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\_ViewImports.cshtml"
using Kendo.Mvc.UI;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1c2be4f1d444fc8ce4475df9e9ab7887b3d1828", @"/Views/salesforce/crt-251/checkbox.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bee3447070987ca46eb03bbeb43d7bf40055dde5", @"/Views/_ViewImports.cshtml")]
    public class Views_salesforce_crt_251_checkbox : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 111, true);
            WriteLiteral("<ul class=\"panelbar\">\r\n    <li class=\"k-state-active\">\r\n        <span class=\"k-link k-state-selected\">Question ");
            EndContext();
            BeginContext(112, 9, false);
#line 3 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\salesforce\crt-251\checkbox.cshtml"
                                                  Write(Model?.Id);

#line default
#line hidden
            EndContext();
            BeginContext(121, 57, true);
            WriteLiteral("</span>\r\n        <div>\r\n            <p>\r\n                ");
            EndContext();
            BeginContext(179, 25, false);
#line 6 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\salesforce\crt-251\checkbox.cshtml"
           Write(Html.Raw(Model.H1OpenTag));

#line default
#line hidden
            EndContext();
            BeginContext(204, 116, true);
            WriteLiteral("\r\n                Universal Containers’ current solution for managing its forecasts is cumbersome.\r\n                ");
            EndContext();
            BeginContext(321, 26, false);
#line 8 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\salesforce\crt-251\checkbox.cshtml"
           Write(Html.Raw(Model.H1CloseTag));

#line default
#line hidden
            EndContext();
            BeginContext(347, 53, true);
            WriteLiteral("\r\n            </p>\r\n            <p>\r\n                ");
            EndContext();
            BeginContext(401, 25, false);
#line 11 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\salesforce\crt-251\checkbox.cshtml"
           Write(Html.Raw(Model.H2OpenTag));

#line default
#line hidden
            EndContext();
            BeginContext(426, 148, true);
            WriteLiteral("\r\n                The sales managers do NOT have visibility into their teams’ forecasts and are NOT able to update the forecasts. \r\n                ");
            EndContext();
            BeginContext(575, 26, false);
#line 13 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\salesforce\crt-251\checkbox.cshtml"
           Write(Html.Raw(Model.H2CloseTag));

#line default
#line hidden
            EndContext();
            BeginContext(601, 627, true);
            WriteLiteral(@"
            </p>
            <p>
                As a result, the managers are continually asking their sales representatives to provide updated forecast data via email or phone.
            </p>
            <p>
                Which two solutions should a consultant recommend to help Universal Containers improve the management of their forecasts? (Choose two.)
            </p>
        </div>
    </li>
    <li class=""k-state-active"">
        Answers
        <div>
            <p>
                <ul class=""fieldlist"">
                    <li class=""correct"">
                        <input type=""checkbox""");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1228, "\"", 1252, 1);
#line 29 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\salesforce\crt-251\checkbox.cshtml"
WriteAttributeValue("", 1233, Html.GetNextId(), 1233, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1253, 77, true);
            WriteLiteral(" class=\"k-checkbox\">\r\n                        <label class=\"k-checkbox-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 1330, "\"", 1359, 1);
#line 30 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\salesforce\crt-251\checkbox.cshtml"
WriteAttributeValue("", 1336, Html.GetNextId(true), 1336, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1360, 227, true);
            WriteLiteral(">\r\n                            Enable override forecast permission in the Manager\'s profile.\r\n                        </label>\r\n                    </li>\r\n                    <li>\r\n                        <input type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1587, "\"", 1611, 1);
#line 35 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\salesforce\crt-251\checkbox.cshtml"
WriteAttributeValue("", 1592, Html.GetNextId(), 1592, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1612, 77, true);
            WriteLiteral(" class=\"k-checkbox\">\r\n                        <label class=\"k-checkbox-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 1689, "\"", 1718, 1);
#line 36 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\salesforce\crt-251\checkbox.cshtml"
WriteAttributeValue("", 1695, Html.GetNextId(true), 1695, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1719, 276, true);
            WriteLiteral(@">
                            Configure weekly customized forecast reports and dashboards to be emailed to sales management.
                        </label>
                    </li>
                    <li class=""correct"">
                        <input type=""checkbox""");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1995, "\"", 2019, 1);
#line 41 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\salesforce\crt-251\checkbox.cshtml"
WriteAttributeValue("", 2000, Html.GetNextId(), 2000, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2020, 77, true);
            WriteLiteral(" class=\"k-checkbox\">\r\n                        <label class=\"k-checkbox-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 2097, "\"", 2126, 1);
#line 42 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\salesforce\crt-251\checkbox.cshtml"
WriteAttributeValue("", 2103, Html.GetNextId(true), 2103, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2127, 243, true);
            WriteLiteral(">\r\n                            Create a forecast hierarchy and assign managers to the forecast manager role.\r\n                        </label>\r\n                    </li>\r\n                    <li>\r\n                        <input type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2370, "\"", 2394, 1);
#line 47 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\salesforce\crt-251\checkbox.cshtml"
WriteAttributeValue("", 2375, Html.GetNextId(), 2375, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2395, 77, true);
            WriteLiteral(" class=\"k-checkbox\">\r\n                        <label class=\"k-checkbox-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 2472, "\"", 2501, 1);
#line 48 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\salesforce\crt-251\checkbox.cshtml"
WriteAttributeValue("", 2478, Html.GetNextId(true), 2478, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2502, 261, true);
            WriteLiteral(@">
                            Create forecast Chatter groups where sales representatives can post and share their forecasts.
                        </label>
                    </li>
                </ul>
            </p>
        </div>
    </li>
</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
