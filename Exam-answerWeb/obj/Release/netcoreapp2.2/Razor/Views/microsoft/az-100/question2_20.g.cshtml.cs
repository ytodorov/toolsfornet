#pragma checksum "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question2_20.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4fe8928d078867de8132a1c2d63c2a2078de6380"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_microsoft_az_100_question2_20), @"mvc.1.0.view", @"/Views/microsoft/az-100/question2_20.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/microsoft/az-100/question2_20.cshtml", typeof(AspNetCore.Views_microsoft_az_100_question2_20))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fe8928d078867de8132a1c2d63c2a2078de6380", @"/Views/microsoft/az-100/question2_20.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bee3447070987ca46eb03bbeb43d7bf40055dde5", @"/Views/_ViewImports.cshtml")]
    public class Views_microsoft_az_100_question2_20 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 111, true);
            WriteLiteral("<ul class=\"panelbar\">\r\n    <li class=\"k-state-active\">\r\n        <span class=\"k-link k-state-selected\">Question ");
            EndContext();
            BeginContext(112, 9, false);
#line 3 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question2_20.cshtml"
                                                  Write(Model?.Id);

#line default
#line hidden
            EndContext();
            BeginContext(121, 57, true);
            WriteLiteral("</span>\r\n        <div>\r\n            <p>\r\n                ");
            EndContext();
            BeginContext(179, 25, false);
#line 6 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question2_20.cshtml"
           Write(Html.Raw(Model.H1OpenTag));

#line default
#line hidden
            EndContext();
            BeginContext(204, 238, true);
            WriteLiteral("\r\n                You manage several Windows Server virtual machines (VMs) located in a virtual network (VNet) named prod-vnet. These VMs are used internally by development staff and are not accessible from the Internet.\r\n                ");
            EndContext();
            BeginContext(443, 26, false);
#line 8 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question2_20.cshtml"
           Write(Html.Raw(Model.H1CloseTag));

#line default
#line hidden
            EndContext();
            BeginContext(469, 53, true);
            WriteLiteral("\r\n            </p>\r\n            <p>\r\n                ");
            EndContext();
            BeginContext(523, 25, false);
#line 11 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question2_20.cshtml"
           Write(Html.Raw(Model.H2OpenTag));

#line default
#line hidden
            EndContext();
            BeginContext(548, 248, true);
            WriteLiteral("\r\n                You need to provide your development staff with secure access to object and table data to support their Azure-based applications. The storage account data reside in Azure, but must not be exposed to the Internet.\r\n                ");
            EndContext();
            BeginContext(797, 26, false);
#line 13 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question2_20.cshtml"
           Write(Html.Raw(Model.H2CloseTag));

#line default
#line hidden
            EndContext();
            BeginContext(823, 381, true);
            WriteLiteral(@"
            </p>
            <p>
                What two actions should you perform? Each correct answer presents part of the solution.
            </p>
        </div>
    </li>
    <li class=""k-state-active"">
        Answers
        <div>
            <p>
                <ul class=""fieldlist"">
                    <li>
                        <input type=""checkbox""");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1204, "\"", 1228, 1);
#line 26 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question2_20.cshtml"
WriteAttributeValue("", 1209, Html.GetNextId(), 1209, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1229, 77, true);
            WriteLiteral(" class=\"k-checkbox\">\r\n                        <label class=\"k-checkbox-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 1306, "\"", 1335, 1);
#line 27 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question2_20.cshtml"
WriteAttributeValue("", 1312, Html.GetNextId(true), 1312, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1336, 211, true);
            WriteLiteral(">\r\n                            Configure a service endpoint.\r\n                        </label>\r\n                    </li>\r\n                    <li class=\"correct\">\r\n                        <input type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1547, "\"", 1571, 1);
#line 32 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question2_20.cshtml"
WriteAttributeValue("", 1552, Html.GetNextId(), 1552, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1572, 77, true);
            WriteLiteral(" class=\"k-checkbox\">\r\n                        <label class=\"k-checkbox-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 1649, "\"", 1678, 1);
#line 33 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question2_20.cshtml"
WriteAttributeValue("", 1655, Html.GetNextId(true), 1655, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1679, 196, true);
            WriteLiteral(">\r\n                            Deploy a blob storage account.\r\n                        </label>\r\n                    </li>\r\n                    <li>\r\n                        <input type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1875, "\"", 1899, 1);
#line 38 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question2_20.cshtml"
WriteAttributeValue("", 1880, Html.GetNextId(), 1880, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1900, 77, true);
            WriteLiteral(" class=\"k-checkbox\">\r\n                        <label class=\"k-checkbox-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 1977, "\"", 2006, 1);
#line 39 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question2_20.cshtml"
WriteAttributeValue("", 1983, Html.GetNextId(true), 1983, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2007, 203, true);
            WriteLiteral(">\r\n                            Deploy an Azure File Sync sync group.\r\n                        </label>\r\n                    </li>\r\n                    <li>\r\n                        <input type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2210, "\"", 2234, 1);
#line 44 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question2_20.cshtml"
WriteAttributeValue("", 2215, Html.GetNextId(), 2215, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2235, 77, true);
            WriteLiteral(" class=\"k-checkbox\">\r\n                        <label class=\"k-checkbox-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 2312, "\"", 2341, 1);
#line 45 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question2_20.cshtml"
WriteAttributeValue("", 2318, Html.GetNextId(true), 2318, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2342, 228, true);
            WriteLiteral(">\r\n                            Configure a point-to-site (P2S) virtual private network (VPN).\r\n                        </label>\r\n                    </li>\r\n                    <li>\r\n                        <input type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2570, "\"", 2594, 1);
#line 50 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question2_20.cshtml"
WriteAttributeValue("", 2575, Html.GetNextId(), 2575, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2595, 77, true);
            WriteLiteral(" class=\"k-checkbox\">\r\n                        <label class=\"k-checkbox-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 2672, "\"", 2701, 1);
#line 51 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question2_20.cshtml"
WriteAttributeValue("", 2678, Html.GetNextId(true), 2678, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2702, 207, true);
            WriteLiteral(">\r\n                            Deploy a general-purpose storage account.\r\n                        </label>\r\n                    </li>\r\n                    <li>\r\n                        <input type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2909, "\"", 2933, 1);
#line 56 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question2_20.cshtml"
WriteAttributeValue("", 2914, Html.GetNextId(), 2914, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2934, 77, true);
            WriteLiteral(" class=\"k-checkbox\">\r\n                        <label class=\"k-checkbox-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 3011, "\"", 3040, 1);
#line 57 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question2_20.cshtml"
WriteAttributeValue("", 3017, Html.GetNextId(true), 3017, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3041, 3628, true);
            WriteLiteral(@">
                            Configure an Azure Content Delivery Network (CDN)profile.
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
                You should deploy a general-purpose storage account, and then configure a service endpoint. A general-purpose storage account consists of four services, two of which are called for in the scenario:
            </p>
            <p>
                * Binary large object (blob) object storage
                <br />
                * Table (key-value pair) storage
                <br />
                * Queue (messaging) storage
                <br />
                * File (Server Message Block (SMB) file share) storage
            </p>
            <p>
                Service endpoints allow you to bind certain Azure services, including storage accounts and Azure SQL Databases, to a VNet in order to restric");
            WriteLiteral(@"t their access. In this scenario, you would create a service endpoint on prod-vnet to allow the Microsoft.Storage resource provider access. You would then complete the configuration by associating the storage account with the target VNet.
            </p>
            <p>
                You should not deploy a blob storage account because a blob storage account has only one service and the scenario requires both object and table storage to support your developers. The blob storage account includes access tiers that save costs on cool and cold storage (archival) for block blobs such as documents or media files.
            </p>
            <p>
                You should not deploy an Azure File Sync sync group. Azure File Sync is a mechanism to offer tiered and synchronized storage for on-premises Server Message Block (SMB) file shares. This feature meets none of the scenario's requirements.
            </p>
            <p>
                You should not configure a CDN profile. CDN profiles are used ");
            WriteLiteral(@"in conjunction with Azure App Service web applications to deliver static website assets to worldwide customers with low latency.
            </p>
            <p>
                You should not configure a P2S VPN. A P2S VPN is appropriate when you need to give individual users a secure connection to an Azure VNet. In this case you are concerned with providing secure access from the VNet to a storage account.
            </p>
        </div>
    </li>
    <li>
        References
        <div>
            <p>
                <a href=""https://docs.microsoft.com/en-us/azure/storage/common/storage-introduction"" target=""_blank"" rel=""noopener"">Introduction to Azure Storage</a>
            </p>
            <p>
                <a href=""https://docs.microsoft.com/en-us/azure/virtual-network/virtual-network-service-endpoints-overview"" target=""_blank"" rel=""noopener"">Virtual Network Service Endpoints</a>
            </p>
            <p>
                <a href=""https://docs.microsoft.com/en-us/azure/cdn/cd");
            WriteLiteral(@"n-overview"" target=""_blank"" rel=""noopener"">What is a content delivery network on Azure?</a>
            </p>
            <p>
                <a href=""https://docs.microsoft.com/en-us/azure/vpn-gateway/point-to-site-about"" target=""_blank"" rel=""noopener"">About Point-to-Site VPN</a>
            </p>
            <p>
                <a href=""https://docs.microsoft.com/en-us/azure/storage/files/storage-sync-files-deployment-guide?tabs=portal"" target=""_blank"" rel=""noopener"">Deploy Azure File Sync</a>
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
