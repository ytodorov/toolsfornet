#pragma checksum "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question2_12.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abdfeb09e6f45d2ff2fea4afbf6920da6307b22e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_microsoft_az_100_question2_12), @"mvc.1.0.view", @"/Views/microsoft/az-100/question2_12.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/microsoft/az-100/question2_12.cshtml", typeof(AspNetCore.Views_microsoft_az_100_question2_12))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abdfeb09e6f45d2ff2fea4afbf6920da6307b22e", @"/Views/microsoft/az-100/question2_12.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bee3447070987ca46eb03bbeb43d7bf40055dde5", @"/Views/_ViewImports.cshtml")]
    public class Views_microsoft_az_100_question2_12 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 111, true);
            WriteLiteral("<ul class=\"panelbar\">\r\n    <li class=\"k-state-active\">\r\n        <span class=\"k-link k-state-selected\">Question ");
            EndContext();
            BeginContext(112, 9, false);
#line 3 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question2_12.cshtml"
                                                  Write(Model?.Id);

#line default
#line hidden
            EndContext();
            BeginContext(121, 57, true);
            WriteLiteral("</span>\r\n        <div>\r\n            <p>\r\n                ");
            EndContext();
            BeginContext(179, 25, false);
#line 6 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question2_12.cshtml"
           Write(Html.Raw(Model.H1OpenTag));

#line default
#line hidden
            EndContext();
            BeginContext(204, 310, true);
            WriteLiteral(@"
                Your company deploys an Azure File Sync service. This service syncs with an on-premises file server located on your office. The server stores the information synced with Azure in a volume different from the system volume. The file server has an antivirus solution installed.
                ");
            EndContext();
            BeginContext(515, 26, false);
#line 8 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question2_12.cshtml"
           Write(Html.Raw(Model.H1CloseTag));

#line default
#line hidden
            EndContext();
            BeginContext(541, 53, true);
            WriteLiteral("\r\n            </p>\r\n            <p>\r\n                ");
            EndContext();
            BeginContext(595, 25, false);
#line 11 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question2_12.cshtml"
           Write(Html.Raw(Model.H2OpenTag));

#line default
#line hidden
            EndContext();
            BeginContext(620, 219, true);
            WriteLiteral("\r\n                You notice that some infrequently accessed files are downloaded to the file server. After monitoring file system access, you determine that no user is accessing to the affected files.\r\n                ");
            EndContext();
            BeginContext(840, 26, false);
#line 13 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question2_12.cshtml"
           Write(Html.Raw(Model.H2CloseTag));

#line default
#line hidden
            EndContext();
            BeginContext(866, 496, true);
            WriteLiteral(@"
            </p>
            <p>
                You need to troubleshoot what is happening with those files.
            </p>
            <p>
                What are two ways of meeting your goal? Each correct answer presents a complete solution.
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
            BeginWriteAttribute("id", " id=\"", 1362, "\"", 1386, 1);
#line 29 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question2_12.cshtml"
WriteAttributeValue("", 1367, Html.GetNextId(), 1367, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1387, 77, true);
            WriteLiteral(" class=\"k-checkbox\">\r\n                        <label class=\"k-checkbox-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 1464, "\"", 1493, 1);
#line 30 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question2_12.cshtml"
WriteAttributeValue("", 1470, Html.GetNextId(true), 1470, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1494, 296, true);
            WriteLiteral(@">
                            Run the Set-AzureRmStorageSyncServerEndpoint -Id serverendpointid -CloudTiering true -VolumeFreeSpacePercent 60 PowerShell cmdlet.
                        </label>
                    </li>
                    <li>
                        <input type=""checkbox""");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1790, "\"", 1814, 1);
#line 35 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question2_12.cshtml"
WriteAttributeValue("", 1795, Html.GetNextId(), 1795, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1815, 77, true);
            WriteLiteral(" class=\"k-checkbox\">\r\n                        <label class=\"k-checkbox-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 1892, "\"", 1921, 1);
#line 36 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question2_12.cshtml"
WriteAttributeValue("", 1898, Html.GetNextId(true), 1898, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1922, 278, true);
            WriteLiteral(@">
                            Run the Test-NetConnection -ComputerName storage-account-name.file.core.windows.net -Port 443 PowerShell cmdlet.
                        </label>
                    </li>
                    <li>
                        <input type=""checkbox""");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2200, "\"", 2224, 1);
#line 41 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question2_12.cshtml"
WriteAttributeValue("", 2205, Html.GetNextId(), 2205, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2225, 77, true);
            WriteLiteral(" class=\"k-checkbox\">\r\n                        <label class=\"k-checkbox-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 2302, "\"", 2331, 1);
#line 42 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question2_12.cshtml"
WriteAttributeValue("", 2308, Html.GetNextId(true), 2308, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2332, 234, true);
            WriteLiteral(">\r\n                            Run the fltmc command at an elevated command prompt.\r\n                        </label>\r\n                    </li>\r\n                    <li class=\"correct\">\r\n                        <input type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2566, "\"", 2590, 1);
#line 47 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question2_12.cshtml"
WriteAttributeValue("", 2571, Html.GetNextId(), 2571, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2591, 77, true);
            WriteLiteral(" class=\"k-checkbox\">\r\n                        <label class=\"k-checkbox-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 2668, "\"", 2697, 1);
#line 48 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question2_12.cshtml"
WriteAttributeValue("", 2674, Html.GetNextId(true), 2674, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2698, 267, true);
            WriteLiteral(@">
                            Review the Application event log. the cluster to support File Server for General Use.
                        </label>
                    </li>
                    <li class=""correct"">
                        <input type=""checkbox""");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2965, "\"", 2989, 1);
#line 53 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question2_12.cshtml"
WriteAttributeValue("", 2970, Html.GetNextId(), 2970, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2990, 77, true);
            WriteLiteral(" class=\"k-checkbox\">\r\n                        <label class=\"k-checkbox-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 3067, "\"", 3096, 1);
#line 54 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question2_12.cshtml"
WriteAttributeValue("", 3073, Html.GetNextId(true), 3073, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3097, 2927, true);
            WriteLiteral(@">
                            Review the Services\Microsoft\FileSync\Agent event log.
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
                You should review the Application or Services\Microsoft\FileSync\Agent event logs. These diagnostics and operational event logs gathers information about sync, recall, and tiering issues. Since you notice that infrequent accessed files are being downloaded to the file server, this means that you have enabled cloud tiering for this server. When cloud tiering is enabled, the Azure File Sync file system filter replaces the actual file with a pointer to the file in the Azure File share where all the data is stored. When a user access to a tiered file, the file is transparently downloaded to the server. This issue could happen when an antivirus solution is not aware of the offline NTFS attribute in the file. This attribute ");
            WriteLiteral(@"is set to allow third-party applications to identify tiered files.
            </p>
            <p>
                You should not run the fltmc command at an elevated command prompt. You use the fltmc command to list all filesystem filters loaded in the file server. If the StorageSync.sys and StorageSyncGuard.sys file system filter drivers are not loaded, tiered files are not recalled and downloaded again to the file server. This is not the observed behavior.
            </p>
            <p>
                You should not run the Test-NetConnection -ComputerName storage-account-name.file.core.windows.net -Port 443 PowerShell cmdlet. You use the Test-NetConnection cmdlet to check the connectivity with a computer. If you use the Fully Qualified Domain Name, you are also checking the DNS resolution. You can check the connectivity to a TCP port if you use the -Port parameter.
            </p>
            <p>
                You should not run the Set-AzureRmStorageSyncServerEndpoint -Id serverendpointid");
            WriteLiteral(@" -CloudTiering true -VolumeFreeSpacePercent 60 PowerShell cmdlet. You use this cmdlet to enable cloud tiering on a server endpoint. You have already enable cloud tiering on this server.
            </p>
        </div>
    </li>
    <li>
        References
        <div>
            <p>
                <a href=""https://docs.microsoft.com/en-us/azure/storage/files/storage-sync-files-troubleshoot"" target=""_blank"" rel=""noopener"">Troubleshoot Azure File Sync</a>
            </p>
            <p>
                <a href=""https://docs.microsoft.com/en-us/azure/storage/files/storage-sync-files-planning"" target=""_blank"" rel=""noopener"">Planning for an Azure File Sync deployment</a>
            </p>
            <p>
                <a href=""https://ss64.com/nt/fltmc.html"" target=""_blank"" rel=""noopener"">FLTMC.exe</a>
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
