#pragma checksum "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question2_9.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8179eefd3dab3a0a8b8b5efe6bf45bced27bea99"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_microsoft_az_100_question2_9), @"mvc.1.0.view", @"/Views/microsoft/az-100/question2_9.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/microsoft/az-100/question2_9.cshtml", typeof(AspNetCore.Views_microsoft_az_100_question2_9))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8179eefd3dab3a0a8b8b5efe6bf45bced27bea99", @"/Views/microsoft/az-100/question2_9.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bee3447070987ca46eb03bbeb43d7bf40055dde5", @"/Views/_ViewImports.cshtml")]
    public class Views_microsoft_az_100_question2_9 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 111, true);
            WriteLiteral("<ul class=\"panelbar\">\r\n    <li class=\"k-state-active\">\r\n        <span class=\"k-link k-state-selected\">Question ");
            EndContext();
            BeginContext(112, 9, false);
#line 3 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question2_9.cshtml"
                                                  Write(Model?.Id);

#line default
#line hidden
            EndContext();
            BeginContext(121, 57, true);
            WriteLiteral("</span>\r\n        <div>\r\n            <p>\r\n                ");
            EndContext();
            BeginContext(179, 25, false);
#line 6 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question2_9.cshtml"
           Write(Html.Raw(Model.H1OpenTag));

#line default
#line hidden
            EndContext();
            BeginContext(204, 182, true);
            WriteLiteral("\r\n                Your on-premises datacenter has a mixture of servers running Windows Server 2012 R2 Datacenter edition and Windows Server 2016 Datacenter edition.\r\n                ");
            EndContext();
            BeginContext(387, 26, false);
#line 8 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question2_9.cshtml"
           Write(Html.Raw(Model.H1CloseTag));

#line default
#line hidden
            EndContext();
            BeginContext(413, 53, true);
            WriteLiteral("\r\n            </p>\r\n            <p>\r\n                ");
            EndContext();
            BeginContext(467, 25, false);
#line 11 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question2_9.cshtml"
           Write(Html.Raw(Model.H2OpenTag));

#line default
#line hidden
            EndContext();
            BeginContext(492, 143, true);
            WriteLiteral("\r\n                You need to configure Azure Sync Service between the Azure Files service and the servers in the datacenter.\r\n                ");
            EndContext();
            BeginContext(636, 26, false);
#line 13 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question2_9.cshtml"
           Write(Html.Raw(Model.H2CloseTag));

#line default
#line hidden
            EndContext();
            BeginContext(662, 469, true);
            WriteLiteral(@"
            </p>
            <p>
                Which two activities must you complete to ensure that the service will operate successfully on your servers? Each correct answer presents part of the solution.
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
            BeginWriteAttribute("id", " id=\"", 1131, "\"", 1155, 1);
#line 26 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question2_9.cshtml"
WriteAttributeValue("", 1136, Html.GetNextId(), 1136, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1156, 77, true);
            WriteLiteral(" class=\"k-checkbox\">\r\n                        <label class=\"k-checkbox-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 1233, "\"", 1262, 1);
#line 27 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question2_9.cshtml"
WriteAttributeValue("", 1239, Html.GetNextId(true), 1239, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1263, 247, true);
            WriteLiteral(">\r\n                            Disable Internet Explorer Enhanced Security for Admins and Users.\r\n                        </label>\r\n                    </li>\r\n                    <li class=\"correct\">\r\n                        <input type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1510, "\"", 1534, 1);
#line 32 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question2_9.cshtml"
WriteAttributeValue("", 1515, Html.GetNextId(), 1515, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1535, 77, true);
            WriteLiteral(" class=\"k-checkbox\">\r\n                        <label class=\"k-checkbox-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 1612, "\"", 1641, 1);
#line 33 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question2_9.cshtml"
WriteAttributeValue("", 1618, Html.GetNextId(true), 1618, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1642, 251, true);
            WriteLiteral(">\r\n                            Ensure that the PowerShell version deployed to the servers is at minimum version 5.1.\r\n                        </label>\r\n                    </li>\r\n                    <li>\r\n                        <input type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1893, "\"", 1917, 1);
#line 38 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question2_9.cshtml"
WriteAttributeValue("", 1898, Html.GetNextId(), 1898, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1918, 77, true);
            WriteLiteral(" class=\"k-checkbox\">\r\n                        <label class=\"k-checkbox-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 1995, "\"", 2024, 1);
#line 39 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question2_9.cshtml"
WriteAttributeValue("", 2001, Html.GetNextId(true), 2001, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2025, 284, true);
            WriteLiteral(@">
                            Ensure that for fileserver clusters, Azure Active Directory Connect is deployed to at least one server in the cluster.
                        </label>
                    </li>
                    <li>
                        <input type=""checkbox""");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2309, "\"", 2333, 1);
#line 44 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question2_9.cshtml"
WriteAttributeValue("", 2314, Html.GetNextId(), 2314, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2334, 77, true);
            WriteLiteral(" class=\"k-checkbox\">\r\n                        <label class=\"k-checkbox-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 2411, "\"", 2440, 1);
#line 45 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question2_9.cshtml"
WriteAttributeValue("", 2417, Html.GetNextId(true), 2417, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2441, 226, true);
            WriteLiteral(">\r\n                            Disable Internet Explorer Enhanced Security for Admins only.\r\n                        </label>\r\n                    </li>\r\n                    <li>\r\n                        <input type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2667, "\"", 2691, 1);
#line 50 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question2_9.cshtml"
WriteAttributeValue("", 2672, Html.GetNextId(), 2672, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2692, 77, true);
            WriteLiteral(" class=\"k-checkbox\">\r\n                        <label class=\"k-checkbox-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 2769, "\"", 2798, 1);
#line 51 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question2_9.cshtml"
WriteAttributeValue("", 2775, Html.GetNextId(true), 2775, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2799, 1869, true);
            WriteLiteral(@">
                            Ensure that the Windows Identity Framework is deployed to all servers.
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
                To enable Azure File Sync, you must disable Internet Explorer Enhanced Security for all admin and user accounts.
            </p>
            <p>
                Azure File Sync requires a minimum PowerShell version of 5.1. Windows Server 2016 supports that as the minimum default version, but it may have to be installed on Windows Server 2012 R2 servers.
            </p>
            <p>
                The Windows Identity Foundation and Azure Active directory connect do not need to be installed on the file servers in the environment. Azure Active Directory Connect is used to synchronize on-premises identities to Azure Active Directory (Azure AD) and so is needed in the overall environment, but not");
            WriteLiteral(@" on the file servers.
            </p>
        </div>
    </li>
    <li>
        References
        <div>
            <p>
                <a href=""https://docs.microsoft.com/en-us/azure/storage/files/storage-sync-files-deployment-guide"" target=""_blank"" rel=""noopener"">Deploy Azure File Sync</a>
            </p>
            <p>
                <a href=""https://msdn.microsoft.com/en-us/library/ee748475.aspx"" target=""_blank"" rel=""noopener"">What is Windows Identity Foundation?</a>
            </p>
            <p>
                <a title=""https://docs.microsoft.com/en-us/azure/active-directory/hybrid/whatis-hybrid-identity"" href=""https://docs.microsoft.com/en-us/azure/active-directory/hybrid/whatis-hybrid-identity"" target=""_blank"" rel=""noopener"">What is hybrid identity?</a>
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