#pragma checksum "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_20.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4791e50d629d1bef14211b317cbe6afec1a9c7b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_microsoft_az_100_question1_20), @"mvc.1.0.view", @"/Views/microsoft/az-100/question1_20.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/microsoft/az-100/question1_20.cshtml", typeof(AspNetCore.Views_microsoft_az_100_question1_20))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4791e50d629d1bef14211b317cbe6afec1a9c7b5", @"/Views/microsoft/az-100/question1_20.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bee3447070987ca46eb03bbeb43d7bf40055dde5", @"/Views/_ViewImports.cshtml")]
    public class Views_microsoft_az_100_question1_20 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 111, true);
            WriteLiteral("<ul class=\"panelbar\">\r\n    <li class=\"k-state-active\">\r\n        <span class=\"k-link k-state-selected\">Question ");
            EndContext();
            BeginContext(112, 9, false);
#line 3 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_20.cshtml"
                                                  Write(Model?.Id);

#line default
#line hidden
            EndContext();
            BeginContext(121, 57, true);
            WriteLiteral("</span>\r\n        <div>\r\n            <p>\r\n                ");
            EndContext();
            BeginContext(179, 25, false);
#line 6 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_20.cshtml"
           Write(Html.Raw(Model.H1OpenTag));

#line default
#line hidden
            EndContext();
            BeginContext(204, 192, true);
            WriteLiteral("\r\n                Your company is developing a line-of-business (LOB) application that uses the Azure IoT Hub for gathering information from Internet of things (IoT) devices.\r\n                ");
            EndContext();
            BeginContext(397, 26, false);
#line 8 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_20.cshtml"
           Write(Html.Raw(Model.H1CloseTag));

#line default
#line hidden
            EndContext();
            BeginContext(423, 53, true);
            WriteLiteral("\r\n            </p>\r\n            <p>\r\n                ");
            EndContext();
            BeginContext(477, 25, false);
#line 11 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_20.cshtml"
           Write(Html.Raw(Model.H2OpenTag));

#line default
#line hidden
            EndContext();
            BeginContext(502, 127, true);
            WriteLiteral("\r\n                The LOB application uses the IoT Hub Service SDK to read device telemetry from the IoT Hub.\r\n                ");
            EndContext();
            BeginContext(630, 26, false);
#line 13 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_20.cshtml"
           Write(Html.Raw(Model.H2CloseTag));

#line default
#line hidden
            EndContext();
            BeginContext(656, 553, true);
            WriteLiteral(@"
            </p>
            <p>
                You need to monitor device telemetry and be able configure alerts based on device telemetry values. Your solution should require the least administrative effort.
            </p>
            <p>
                What should you do?
            </p>
        </div>
    </li>
    <li class=""k-state-active"">
        Answers
        <div>
            <p>
                <ul class=""fieldlist"">
                    <li class=""correct"">
                        <input type=""radio"" name=""group""");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1209, "\"", 1233, 1);
#line 29 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_20.cshtml"
WriteAttributeValue("", 1214, Html.GetNextId(), 1214, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1234, 71, true);
            WriteLiteral(" class=\"k-radio\">\r\n                        <label class=\"k-radio-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 1305, "\"", 1334, 1);
#line 30 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_20.cshtml"
WriteAttributeValue("", 1311, Html.GetNextId(true), 1311, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1335, 238, true);
            WriteLiteral(">\r\n                            Enable Azure Monitor resource diagnostics logs on the IoT Hub.\r\n                        </label>\r\n                    </li>\r\n                    <li>\r\n                        <input type=\"radio\" name=\"group\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1573, "\"", 1597, 1);
#line 35 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_20.cshtml"
WriteAttributeValue("", 1578, Html.GetNextId(), 1578, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1598, 71, true);
            WriteLiteral(" class=\"k-radio\">\r\n                        <label class=\"k-radio-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 1669, "\"", 1698, 1);
#line 36 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_20.cshtml"
WriteAttributeValue("", 1675, Html.GetNextId(true), 1675, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1699, 202, true);
            WriteLiteral(">\r\n                            Use Azure Resource Health.\r\n                        </label>\r\n                    </li>\r\n                    <li>\r\n                        <input type=\"radio\" name=\"group\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1901, "\"", 1925, 1);
#line 41 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_20.cshtml"
WriteAttributeValue("", 1906, Html.GetNextId(), 1906, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1926, 71, true);
            WriteLiteral(" class=\"k-radio\">\r\n                        <label class=\"k-radio-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 1997, "\"", 2026, 1);
#line 42 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_20.cshtml"
WriteAttributeValue("", 2003, Html.GetNextId(true), 2003, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2027, 200, true);
            WriteLiteral(">\r\n                            Use Azure Activity Logs.\r\n                        </label>\r\n                    </li>\r\n                    <li>\r\n                        <input type=\"radio\" name=\"group\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2227, "\"", 2251, 1);
#line 47 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_20.cshtml"
WriteAttributeValue("", 2232, Html.GetNextId(), 2232, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2252, 71, true);
            WriteLiteral(" class=\"k-radio\">\r\n                        <label class=\"k-radio-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 2323, "\"", 2352, 1);
#line 48 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_20.cshtml"
WriteAttributeValue("", 2329, Html.GetNextId(true), 2329, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2353, 2567, true);
            WriteLiteral(@">
                            Use Azure Application Insights with the LOB application.
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
                You should enable Azure Monitor resource diagnostics logs on the IoT Hub. Resource-level diagnostics logs allow you to monitor events that happen inside the resource. Each type of resource provides a different type of events. For the IoT Hub, the event category DeviceTelemetry fits your needs.
            </p>
            <p>
                You should not use Azure Activity Logs. This service provides information about the actions performed on the resources in a subscription while using Resource Manager. Creating an IoT Hub, listing keys from a storage account, or starting a virtual machine are some examples of the type of activity logging information provided by Activity Logs.
            </p>
            <p>
");
            WriteLiteral(@"                You should not use Azure Resource Health. This service provides information about the high-level health status of the resource or if there is a regional outage. You would use this service to know if the IoT Hub is running or not.
            </p>
            <p>
                You should not use Azure Application Insights with the LOB application. Application Insights provides information about the application performance while the application is running.
            </p>
        </div>
    </li>
    <li>
        References
        <div>
            <p>
                <a href=""https://docs.microsoft.com/en-us/azure/monitoring-and-diagnostics/monitoring-overview-of-diagnostic-logs"" target=""_blank"" rel=""noopener"">Collect and consume log data from your Azure resources</a>
            </p>
            <p>
                <a href=""https://docs.microsoft.com/en-us/azure/monitoring-and-diagnostics/monitoring-diagnostic-logs-schema"" target=""_blank"" rel=""noopener"">Supported services, sc");
            WriteLiteral(@"hemas, and categories for Azure Diagnostic Logs</a>
            </p>
            <p>
                <a href=""https://docs.microsoft.com/en-us/azure/application-insights/app-insights-overview"" target=""_blank"" rel=""noopener"">What is Application Insights?</a>
            </p>
            <p>
                <a href=""https://docs.microsoft.com/en-us/azure/service-health/resource-health-overview"" target=""_blank"" rel=""noopener"">Azure Resource Health overview</a>
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
