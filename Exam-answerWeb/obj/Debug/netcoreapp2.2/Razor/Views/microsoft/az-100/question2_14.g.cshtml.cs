#pragma checksum "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question2_14.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2d880a219cd6e058b1691c4e723f45098b1a211"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_microsoft_az_100_question2_14), @"mvc.1.0.view", @"/Views/microsoft/az-100/question2_14.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/microsoft/az-100/question2_14.cshtml", typeof(AspNetCore.Views_microsoft_az_100_question2_14))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2d880a219cd6e058b1691c4e723f45098b1a211", @"/Views/microsoft/az-100/question2_14.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bee3447070987ca46eb03bbeb43d7bf40055dde5", @"/Views/_ViewImports.cshtml")]
    public class Views_microsoft_az_100_question2_14 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 111, true);
            WriteLiteral("<ul class=\"panelbar\">\r\n    <li class=\"k-state-active\">\r\n        <span class=\"k-link k-state-selected\">Question ");
            EndContext();
            BeginContext(112, 9, false);
#line 3 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question2_14.cshtml"
                                                  Write(Model?.Id);

#line default
#line hidden
            EndContext();
            BeginContext(121, 57, true);
            WriteLiteral("</span>\r\n        <div>\r\n            <p>\r\n                ");
            EndContext();
            BeginContext(179, 25, false);
#line 6 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question2_14.cshtml"
           Write(Html.Raw(Model.H1OpenTag));

#line default
#line hidden
            EndContext();
            BeginContext(204, 249, true);
            WriteLiteral("\r\n                You have several Windows Server 2012 R2 file servers deployed in your on-premises infrastructure. You want to deploy a file server hybrid solution. You decide to use Azure File Sync with some of your file servers.\r\n                ");
            EndContext();
            BeginContext(454, 26, false);
#line 8 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question2_14.cshtml"
           Write(Html.Raw(Model.H1CloseTag));

#line default
#line hidden
            EndContext();
            BeginContext(480, 53, true);
            WriteLiteral("\r\n            </p>\r\n            <p>\r\n                ");
            EndContext();
            BeginContext(534, 25, false);
#line 11 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question2_14.cshtml"
           Write(Html.Raw(Model.H2OpenTag));

#line default
#line hidden
            EndContext();
            BeginContext(559, 140, true);
            WriteLiteral("\r\n                You configure two Azure File Storage accounts for this purpose. You are configuring the Azure File Sync.\r\n                ");
            EndContext();
            BeginContext(700, 26, false);
#line 13 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question2_14.cshtml"
           Write(Html.Raw(Model.H2CloseTag));

#line default
#line hidden
            EndContext();
            BeginContext(726, 316, true);
            WriteLiteral(@"
            </p>
            <p>
                Choose all that apply:
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
            BeginWriteAttribute("id", " id=\"", 1042, "\"", 1066, 1);
#line 26 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question2_14.cshtml"
WriteAttributeValue("", 1047, Html.GetNextId(), 1047, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1067, 77, true);
            WriteLiteral(" class=\"k-checkbox\">\r\n                        <label class=\"k-checkbox-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 1144, "\"", 1173, 1);
#line 27 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question2_14.cshtml"
WriteAttributeValue("", 1150, Html.GetNextId(true), 1150, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1174, 232, true);
            WriteLiteral(">\r\n                            You can use more than one Azure file share in the same sync group.\r\n                        </label>\r\n                    </li>\r\n                    <li>\r\n                        <input type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1406, "\"", 1430, 1);
#line 32 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question2_14.cshtml"
WriteAttributeValue("", 1411, Html.GetNextId(), 1411, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1431, 77, true);
            WriteLiteral(" class=\"k-checkbox\">\r\n                        <label class=\"k-checkbox-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 1508, "\"", 1537, 1);
#line 33 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question2_14.cshtml"
WriteAttributeValue("", 1514, Html.GetNextId(true), 1514, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1538, 226, true);
            WriteLiteral(">\r\n                            A server can sync with multiple sync groups.\r\n                        </label>\r\n                    </li>\r\n                    <li class=\"correct\">\r\n                        <input type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1764, "\"", 1788, 1);
#line 38 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question2_14.cshtml"
WriteAttributeValue("", 1769, Html.GetNextId(), 1769, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1789, 77, true);
            WriteLiteral(" class=\"k-checkbox\">\r\n                        <label class=\"k-checkbox-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 1866, "\"", 1895, 1);
#line 39 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question2_14.cshtml"
WriteAttributeValue("", 1872, Html.GetNextId(true), 1872, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1896, 237, true);
            WriteLiteral(">\r\n                            Changes made directly on the file share can take up to 24 to be synced.\r\n                        </label>\r\n                    </li>\r\n                    <li>\r\n                        <input type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2133, "\"", 2157, 1);
#line 44 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question2_14.cshtml"
WriteAttributeValue("", 2138, Html.GetNextId(), 2138, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2158, 77, true);
            WriteLiteral(" class=\"k-checkbox\">\r\n                        <label class=\"k-checkbox-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 2235, "\"", 2264, 1);
#line 45 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question2_14.cshtml"
WriteAttributeValue("", 2241, Html.GetNextId(true), 2241, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2265, 2720, true);
            WriteLiteral(@">
                            Pre-seeding is the best approach for doing the first synchronization.
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
                You cannot use more than one Azure file share in the same sync group. An Azure file share is represented by a cloud endpoint. You can only have one cloud endpoint per sync group. You can add as many server endpoints as you want. You should think of sync groups as the replication hub in the sync process.
            </p>
            <p>
                A server can sync with multiple sync groups. You can configure as many server endpoints as you need in a single server and each endpoint can be synced with different sync groups. This means that you can have the same server synced with a different sync group as long as you use different server endpoints. Remember that you cannot use NAS or mounted shares ");
            WriteLiteral(@"as server endpoints, and tiering will be applied only to those endpoints that are not stored in a system volume.
            </p>
            <p>
                Changes made directly on the file share can take up to 24 to be synced. You can make changes directly on an Azure file share that is a member of a sync group, but you should bear in mind that this change will not be effective until the change is discovered by the Azure File Sync change detection job that runs every 24 hours. This means that, in the worst case, a change made directly on the Azure file share can take up to 24 to be synced.
            </p>
            <p>
                Pre-seeding is not the best approach for doing the first synchronization. When you onboard with Azure File Sync you typically prefer to have a zero-downtime synchronization. You can achieve this by using only one server that hosts the dataset that you will sync and perform the first synchronization with this server. Once this first synchronization is done, you ca");
            WriteLiteral(@"n add any additional server to the sync group. If you use pre-seeding, you need to manually copy all the datasets to the Azure file share using a mechanism like SMB copy or Robocopy. If you decide to use this method, you need to ensure that you can afford the downtime and that there will not be any changes to the dataset.
            </p>
        </div>
    </li>
    <li>
        References
        <div>
            <p>
                <a href=""https://docs.microsoft.com/en-us/azure/storage/files/storage-sync-files-deployment-guide?tabs=powershell"" target=""_blank"" rel=""noopener"">Deploy Azure File Sync</a>
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
