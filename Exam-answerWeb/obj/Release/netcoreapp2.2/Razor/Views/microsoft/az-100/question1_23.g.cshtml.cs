#pragma checksum "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question1_23.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b92f621bb08af14c80c4e5d4fb661faca0d6f933"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_microsoft_az_100_question1_23), @"mvc.1.0.view", @"/Views/microsoft/az-100/question1_23.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/microsoft/az-100/question1_23.cshtml", typeof(AspNetCore.Views_microsoft_az_100_question1_23))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b92f621bb08af14c80c4e5d4fb661faca0d6f933", @"/Views/microsoft/az-100/question1_23.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bee3447070987ca46eb03bbeb43d7bf40055dde5", @"/Views/_ViewImports.cshtml")]
    public class Views_microsoft_az_100_question1_23 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 111, true);
            WriteLiteral("<ul class=\"panelbar\">\r\n    <li class=\"k-state-active\">\r\n        <span class=\"k-link k-state-selected\">Question ");
            EndContext();
            BeginContext(112, 9, false);
#line 3 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question1_23.cshtml"
                                                  Write(Model?.Id);

#line default
#line hidden
            EndContext();
            BeginContext(121, 57, true);
            WriteLiteral("</span>\r\n        <div>\r\n            <p>\r\n                ");
            EndContext();
            BeginContext(179, 25, false);
#line 6 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question1_23.cshtml"
           Write(Html.Raw(Model.H1OpenTag));

#line default
#line hidden
            EndContext();
            BeginContext(204, 272, true);
            WriteLiteral(@"
                Your company has a line-of-business (LOB) application that uses Azure SQL Database for storing transactional information. The LOB application also uses Windows and Linux virtual machines for business and presentation application layers.
                ");
            EndContext();
            BeginContext(477, 26, false);
#line 8 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question1_23.cshtml"
           Write(Html.Raw(Model.H1CloseTag));

#line default
#line hidden
            EndContext();
            BeginContext(503, 53, true);
            WriteLiteral("\r\n            </p>\r\n            <p>\r\n                ");
            EndContext();
            BeginContext(557, 25, false);
#line 11 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question1_23.cshtml"
           Write(Html.Raw(Model.H2OpenTag));

#line default
#line hidden
            EndContext();
            BeginContext(582, 87, true);
            WriteLiteral("\r\n                Some users are reporting errors in the application.\r\n                ");
            EndContext();
            BeginContext(670, 26, false);
#line 13 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question1_23.cshtml"
           Write(Html.Raw(Model.H2CloseTag));

#line default
#line hidden
            EndContext();
            BeginContext(696, 605, true);
            WriteLiteral(@"
            </p>
            <p>
                You need to be alerted every time that an exception arises in any part of the application. Your solution should require the minimal administrative effort.
            </p>
            <p>
                Which two actions should you perform? Each correct answer presents part of the solution.
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
            BeginWriteAttribute("id", " id=\"", 1301, "\"", 1325, 1);
#line 29 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question1_23.cshtml"
WriteAttributeValue("", 1306, Html.GetNextId(), 1306, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1326, 77, true);
            WriteLiteral(" class=\"k-checkbox\">\r\n                        <label class=\"k-checkbox-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 1403, "\"", 1432, 1);
#line 30 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question1_23.cshtml"
WriteAttributeValue("", 1409, Html.GetNextId(true), 1409, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1433, 248, true);
            WriteLiteral(">\r\n                            Create an alert using a search query that looks for exceptions in Windows servers.\r\n                        </label>\r\n                    </li>\r\n                    <li>\r\n                        <input type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1681, "\"", 1705, 1);
#line 35 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question1_23.cshtml"
WriteAttributeValue("", 1686, Html.GetNextId(), 1686, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1706, 77, true);
            WriteLiteral(" class=\"k-checkbox\">\r\n                        <label class=\"k-checkbox-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 1783, "\"", 1812, 1);
#line 36 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question1_23.cshtml"
WriteAttributeValue("", 1789, Html.GetNextId(true), 1789, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1813, 281, true);
            WriteLiteral(@">
                            Create an alert using a search query that looks for exceptions in business and presentation layer virtual machines.
                        </label>
                    </li>
                    <li>
                        <input type=""checkbox""");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2094, "\"", 2118, 1);
#line 41 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question1_23.cshtml"
WriteAttributeValue("", 2099, Html.GetNextId(), 2099, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2119, 77, true);
            WriteLiteral(" class=\"k-checkbox\">\r\n                        <label class=\"k-checkbox-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 2196, "\"", 2225, 1);
#line 42 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question1_23.cshtml"
WriteAttributeValue("", 2202, Html.GetNextId(true), 2202, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2226, 258, true);
            WriteLiteral(@">
                            Create an alert using a search query that looks for exceptions in application layer servers.
                        </label>
                    </li>
                    <li>
                        <input type=""checkbox""");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2484, "\"", 2508, 1);
#line 47 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question1_23.cshtml"
WriteAttributeValue("", 2489, Html.GetNextId(), 2489, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2509, 77, true);
            WriteLiteral(" class=\"k-checkbox\">\r\n                        <label class=\"k-checkbox-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 2586, "\"", 2615, 1);
#line 48 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question1_23.cshtml"
WriteAttributeValue("", 2592, Html.GetNextId(true), 2592, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2616, 271, true);
            WriteLiteral(@">
                            Create an alert using a search query that looks for exceptions in business layer servers.
                        </label>
                    </li>
                    <li class=""correct"">
                        <input type=""checkbox""");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2887, "\"", 2911, 1);
#line 53 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question1_23.cshtml"
WriteAttributeValue("", 2892, Html.GetNextId(), 2892, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2912, 77, true);
            WriteLiteral(" class=\"k-checkbox\">\r\n                        <label class=\"k-checkbox-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 2989, "\"", 3018, 1);
#line 54 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question1_23.cshtml"
WriteAttributeValue("", 2995, Html.GetNextId(true), 2995, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3019, 2700, true);
            WriteLiteral(@">
                            Create an alert using a search query that looks for exceptions in Linux servers.
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
                You should create an alert using a search query that looks for exceptions in Windows servers. You need to use Log Analytics or Application Insight resource types and Log signal types. Then you can write a search query that gets all messages from Windows Events that contains the word ""Exception"".
            </p>
            <p>
                You should also create an alert using a search query that looks for exceptions in Linux servers. You use the same configuration as for Windows Events, but you will use Syslog messages.
            </p>
            <p>
                You should not create an alert using a search query that looks for exceptions in business and presentation layer virt");
            WriteLiteral(@"ual machines. When creating an alert, you can only select one target type. This means that you can only get information from Windows Events or Syslog, so you will not be able to query both data sources at the same time.
            </p>
            <p>
                You should not create an alert using a search query that looks for exceptions in application layer servers or in the business layer. You need to query for specific log data sources. Application and business layers is a concept of a design pattern for applications that can be compound of Windows, Linux virtual machines, or other Azure services.
            </p>
        </div>
    </li>
    <li>
        References
        <div>
            <p>
                <a href=""https://docs.microsoft.com/en-us/azure/azure-monitor/log-query/get-started-portal"" target=""_blank"" rel=""noopener"">Get started with Log Analytics in the Azure portal</a>
            </p>
            <p>
                <a href=""https://docs.microsoft.com/en-us/azure/moni");
            WriteLiteral(@"toring-and-diagnostics/monitor-alerts-unified-usage"" target=""_blank"" rel=""noopener"">Create, view, and manage alerts using Azure Monitor</a>
            </p>
            <p>
                <a href=""https://docs.microsoft.com/en-us/azure/log-analytics/log-analytics-data-sources-windows-events"" target=""_blank"" rel=""noopener"">Windows event log data sources in Log Analytics</a>
            </p>
            <p>
                <a href=""https://docs.microsoft.com/en-us/azure/log-analytics/log-analytics-data-sources-syslog"" target=""_blank"" rel=""noopener"">Syslog data sources in Log Analytics</a>
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
