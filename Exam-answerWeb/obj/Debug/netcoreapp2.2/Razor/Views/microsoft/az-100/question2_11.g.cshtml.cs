#pragma checksum "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question2_11.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "983885b130238e790f847f64c6b45be548bbddb6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_microsoft_az_100_question2_11), @"mvc.1.0.view", @"/Views/microsoft/az-100/question2_11.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/microsoft/az-100/question2_11.cshtml", typeof(AspNetCore.Views_microsoft_az_100_question2_11))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"983885b130238e790f847f64c6b45be548bbddb6", @"/Views/microsoft/az-100/question2_11.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bee3447070987ca46eb03bbeb43d7bf40055dde5", @"/Views/_ViewImports.cshtml")]
    public class Views_microsoft_az_100_question2_11 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 111, true);
            WriteLiteral("<ul class=\"panelbar\">\r\n    <li class=\"k-state-active\">\r\n        <span class=\"k-link k-state-selected\">Question ");
            EndContext();
            BeginContext(112, 9, false);
#line 3 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question2_11.cshtml"
                                                  Write(Model?.Id);

#line default
#line hidden
            EndContext();
            BeginContext(121, 57, true);
            WriteLiteral("</span>\r\n        <div>\r\n            <p>\r\n                ");
            EndContext();
            BeginContext(179, 25, false);
#line 6 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question2_11.cshtml"
           Write(Html.Raw(Model.H1OpenTag));

#line default
#line hidden
            EndContext();
            BeginContext(204, 354, true);
            WriteLiteral(@"
                Your company has a file server that stores important information. The operating system for this file server is Windows Server 2012 R2 Standard Edition. The information is stored in a separate volume from the system volume. To improve security, the volume that stores corporate information is encrypted using BitLocker.
                ");
            EndContext();
            BeginContext(559, 26, false);
#line 8 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question2_11.cshtml"
           Write(Html.Raw(Model.H1CloseTag));

#line default
#line hidden
            EndContext();
            BeginContext(585, 53, true);
            WriteLiteral("\r\n            </p>\r\n            <p>\r\n                ");
            EndContext();
            BeginContext(639, 25, false);
#line 11 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question2_11.cshtml"
           Write(Html.Raw(Model.H2OpenTag));

#line default
#line hidden
            EndContext();
            BeginContext(664, 213, true);
            WriteLiteral("\r\n                Your company wants to centralize the storage of information and improve the flexibility for accessing the information. You decide to use Azure File Sync for achieving this goal.\r\n                ");
            EndContext();
            BeginContext(878, 26, false);
#line 13 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question2_11.cshtml"
           Write(Html.Raw(Model.H2CloseTag));

#line default
#line hidden
            EndContext();
            BeginContext(904, 657, true);
            WriteLiteral(@"
            </p>
            <p>
                You configure an Azure File share and the appropriate firewall rules for allowing access from your company offices.
            </p>
            <p>
                After configuring the Sync group, you receive an error about the cloud endpoint creation.
            </p>
            <p>
                What is the most likely cause of the error?
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
            BeginWriteAttribute("id", " id=\"", 1561, "\"", 1585, 1);
#line 32 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question2_11.cshtml"
WriteAttributeValue("", 1566, Html.GetNextId(), 1566, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1586, 71, true);
            WriteLiteral(" class=\"k-radio\">\r\n                        <label class=\"k-radio-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 1657, "\"", 1686, 1);
#line 33 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question2_11.cshtml"
WriteAttributeValue("", 1663, Html.GetNextId(true), 1663, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1687, 236, true);
            WriteLiteral(">\r\n                            You forgot to register the file server with Azure File Sync.\r\n                        </label>\r\n                    </li>\r\n                    <li>\r\n                        <input type=\"radio\" name=\"group\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1923, "\"", 1947, 1);
#line 38 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question2_11.cshtml"
WriteAttributeValue("", 1928, Html.GetNextId(), 1928, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1948, 71, true);
            WriteLiteral(" class=\"k-radio\">\r\n                        <label class=\"k-radio-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 2019, "\"", 2048, 1);
#line 39 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question2_11.cshtml"
WriteAttributeValue("", 2025, Html.GetNextId(true), 2025, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2049, 280, true);
            WriteLiteral(@">
                            Windows Server 2012 R2 Standard Edition is not supported by the Azure File Sync service.
                        </label>
                    </li>
                    <li class=""correct"">
                        <input type=""radio"" name=""group""");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2329, "\"", 2353, 1);
#line 44 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question2_11.cshtml"
WriteAttributeValue("", 2334, Html.GetNextId(), 2334, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2354, 71, true);
            WriteLiteral(" class=\"k-radio\">\r\n                        <label class=\"k-radio-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 2425, "\"", 2454, 1);
#line 45 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question2_11.cshtml"
WriteAttributeValue("", 2431, Html.GetNextId(true), 2431, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2455, 228, true);
            WriteLiteral(">\r\n                            You are using firewall rules in the storage account.\r\n                        </label>\r\n                    </li>\r\n                    <li>\r\n                        <input type=\"radio\" name=\"group\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2683, "\"", 2707, 1);
#line 50 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question2_11.cshtml"
WriteAttributeValue("", 2688, Html.GetNextId(), 2688, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2708, 71, true);
            WriteLiteral(" class=\"k-radio\">\r\n                        <label class=\"k-radio-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 2779, "\"", 2808, 1);
#line 51 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question2_11.cshtml"
WriteAttributeValue("", 2785, Html.GetNextId(true), 2785, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2809, 2087, true);
            WriteLiteral(@">
                            You are trying to sync an encrypted volume.
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
                You are getting the error while creating the cloud endpoint because you are using firewall rules in the storage account. This is not a supported configuration. You cannot use firewall rules or virtual networks with the storage account that will host the synced data from for on-premises file servers.
            </p>
            <p>
                You are not getting the error because you forgot to register the file server with Azure File Sync. You can download and install the Azure Storage Sync agent in the file server after configuring the cloud endpoint. Once you install the agent, you need to register the file server with the Azure File Sync service before you can create a server endpoint.
            </p>
            <p>");
            WriteLiteral(@"
                You are not getting the error because you are using Windows Server 2012 R2 Standard Edition. Windows Server 2012 R2 Standard and Datacenter editions as well as Windows Server 2016 Standard and Datacenter editions are supported operating systems for working with the Azure File Sync service.
            </p>
            <p>
                You are not getting the error because you are trying to sync an encrypted volume. Using encrypted disks with BitLocker is a supported configuration.
            </p>
        </div>
    </li>
    <li>
        References
        <div>
            <p>
                <a href=""https://docs.microsoft.com/en-us/azure/storage/files/storage-sync-files-planning"" target=""_blank"" rel=""noopener"">Planning for an Azure File Sync deployment</a>
            </p>
            <p>
                <a href=""https://docs.microsoft.com/en-us/azure/storage/files/storage-sync-files-deployment-guide"" target=""_blank"" rel=""noopener"">Deploy Azure File Sync</a>
           ");
            WriteLiteral(" </p>\r\n        </div>\r\n    </li>\r\n</ul>");
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