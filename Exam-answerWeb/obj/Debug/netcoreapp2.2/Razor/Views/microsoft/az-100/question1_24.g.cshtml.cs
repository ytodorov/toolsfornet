#pragma checksum "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_24.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7422b74a7602e6297addae5d30e9bb3f91ed0d37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_microsoft_az_100_question1_24), @"mvc.1.0.view", @"/Views/microsoft/az-100/question1_24.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/microsoft/az-100/question1_24.cshtml", typeof(AspNetCore.Views_microsoft_az_100_question1_24))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7422b74a7602e6297addae5d30e9bb3f91ed0d37", @"/Views/microsoft/az-100/question1_24.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bee3447070987ca46eb03bbeb43d7bf40055dde5", @"/Views/_ViewImports.cshtml")]
    public class Views_microsoft_az_100_question1_24 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 111, true);
            WriteLiteral("<ul class=\"panelbar\">\r\n    <li class=\"k-state-active\">\r\n        <span class=\"k-link k-state-selected\">Question ");
            EndContext();
            BeginContext(112, 9, false);
#line 3 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_24.cshtml"
                                                  Write(Model?.Id);

#line default
#line hidden
            EndContext();
            BeginContext(121, 57, true);
            WriteLiteral("</span>\r\n        <div>\r\n            <p>\r\n                ");
            EndContext();
            BeginContext(179, 25, false);
#line 6 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_24.cshtml"
           Write(Html.Raw(Model.H1OpenTag));

#line default
#line hidden
            EndContext();
            BeginContext(204, 110, true);
            WriteLiteral("\r\n                You have a Microsoft Azure subscription that has 8 virtual machines (VMs).\r\n                ");
            EndContext();
            BeginContext(315, 26, false);
#line 8 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_24.cshtml"
           Write(Html.Raw(Model.H1CloseTag));

#line default
#line hidden
            EndContext();
            BeginContext(341, 53, true);
            WriteLiteral("\r\n            </p>\r\n            <p>\r\n                ");
            EndContext();
            BeginContext(395, 25, false);
#line 11 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_24.cshtml"
           Write(Html.Raw(Model.H2OpenTag));

#line default
#line hidden
            EndContext();
            BeginContext(420, 249, true);
            WriteLiteral("\r\n                You need to configure monitoring such that when either CPU usage or available memory reaches a threshold value, Azure both notifies administrators via email and creates a new issue in your corporate issue tracker.\r\n                ");
            EndContext();
            BeginContext(670, 26, false);
#line 13 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_24.cshtml"
           Write(Html.Raw(Model.H2CloseTag));

#line default
#line hidden
            EndContext();
            BeginContext(696, 401, true);
            WriteLiteral(@"
            </p>
            <p>
                What is the minimum number of Azure alerts and action groups you need to meet these requirements?
            </p>
        </div>
    </li>
    <li class=""k-state-active"">
        Answers
        <div>
            <p>
                <ul class=""fieldlist"">
                    <li>
                        <input type=""radio"" name=""group""");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1097, "\"", 1121, 1);
#line 26 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_24.cshtml"
WriteAttributeValue("", 1102, Html.GetNextId(), 1102, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1122, 71, true);
            WriteLiteral(" class=\"k-radio\">\r\n                        <label class=\"k-radio-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 1193, "\"", 1222, 1);
#line 27 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_24.cshtml"
WriteAttributeValue("", 1199, Html.GetNextId(true), 1199, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1223, 210, true);
            WriteLiteral(">\r\n                            Eight alerts and one action group.\r\n                        </label>\r\n                    </li>\r\n                    <li>\r\n                        <input type=\"radio\" name=\"group\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1433, "\"", 1457, 1);
#line 32 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_24.cshtml"
WriteAttributeValue("", 1438, Html.GetNextId(), 1438, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1458, 71, true);
            WriteLiteral(" class=\"k-radio\">\r\n                        <label class=\"k-radio-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 1529, "\"", 1558, 1);
#line 33 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_24.cshtml"
WriteAttributeValue("", 1535, Html.GetNextId(true), 1535, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1559, 225, true);
            WriteLiteral(">\r\n                            Two alerts and two action groups.\r\n                        </label>\r\n                    </li>\r\n                    <li class=\"correct\">\r\n                        <input type=\"radio\" name=\"group\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1784, "\"", 1808, 1);
#line 38 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_24.cshtml"
WriteAttributeValue("", 1789, Html.GetNextId(), 1789, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1809, 71, true);
            WriteLiteral(" class=\"k-radio\">\r\n                        <label class=\"k-radio-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 1880, "\"", 1909, 1);
#line 39 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_24.cshtml"
WriteAttributeValue("", 1886, Html.GetNextId(true), 1886, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1910, 207, true);
            WriteLiteral(">\r\n                            One alert and one action group.\r\n                        </label>\r\n                    </li>\r\n                    <li>\r\n                        <input type=\"radio\" name=\"group\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2117, "\"", 2141, 1);
#line 44 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_24.cshtml"
WriteAttributeValue("", 2122, Html.GetNextId(), 2122, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2142, 71, true);
            WriteLiteral(" class=\"k-radio\">\r\n                        <label class=\"k-radio-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 2213, "\"", 2242, 1);
#line 45 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_24.cshtml"
WriteAttributeValue("", 2219, Html.GetNextId(true), 2219, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2243, 1984, true);
            WriteLiteral(@">
                            One alert and two action groups.
                        </label>
                    </li>
                </ul>
            </p>
        </div>
    </li>
    <li>
        Explanation
        <div>
            <p>
                You should create one alert and one action group. A single alert can contain more than one metric-based condition. By contrast, if you needed alert conditions based on Activity Log events, as of this writing a single alert can contain no more than one Activity Log condition.
            </p>
            <p>
                A single action group can contain more than one notification or remediation step. An action group is a sequence of actions that Azure takes in response to an alert condition. The Azure ITSM connector links Azure Monitor to your Information Technology Service Management (ITSM) solution to allow Azure to create issue tickets automatically.
            </p>
        </div>
    </li>
    <li>
        References
       ");
            WriteLiteral(@" <div>
            <p>
                <a href=""https://docs.microsoft.com/en-us/azure/monitoring-and-diagnostics/monitoring-overview-alerts"" target=""_blank"" rel=""noopener"">Overview of alerts in Microsoft Azure</a>
            </p>
            <p>
                <a href=""https://docs.microsoft.com/en-us/azure/monitoring-and-diagnostics/monitoring-action-groups"" target=""_blank"" rel=""noopener"">Create and manage action groups in the Azure portal</a>
            </p>
            <p>
                <a href=""https://docs.microsoft.com/en-us/azure/monitoring-and-diagnostics/alert-metric"" target=""_blank"" rel=""noopener"">Create, view, and manage metric alerts using Azure Monitor</a>
            </p>
            <p>
                <a href=""https://docs.microsoft.com/en-us/azure/monitoring-and-diagnostics/monitoring-activity-log-alerts"" target=""_blank"" rel=""noopener"">Alerts on activity log</a>
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
