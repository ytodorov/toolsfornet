#pragma checksum "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_18.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9fadde5ecf5ec793a7617cfb2970f98ca400512d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_microsoft_az_100_question1_18), @"mvc.1.0.view", @"/Views/microsoft/az-100/question1_18.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/microsoft/az-100/question1_18.cshtml", typeof(AspNetCore.Views_microsoft_az_100_question1_18))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fadde5ecf5ec793a7617cfb2970f98ca400512d", @"/Views/microsoft/az-100/question1_18.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bee3447070987ca46eb03bbeb43d7bf40055dde5", @"/Views/_ViewImports.cshtml")]
    public class Views_microsoft_az_100_question1_18 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 111, true);
            WriteLiteral("<ul class=\"panelbar\">\r\n    <li class=\"k-state-active\">\r\n        <span class=\"k-link k-state-selected\">Question ");
            EndContext();
            BeginContext(112, 9, false);
#line 3 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_18.cshtml"
                                                  Write(Model?.Id);

#line default
#line hidden
            EndContext();
            BeginContext(121, 57, true);
            WriteLiteral("</span>\r\n        <div>\r\n            <p>\r\n                ");
            EndContext();
            BeginContext(179, 25, false);
#line 6 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_18.cshtml"
           Write(Html.Raw(Model.H1OpenTag));

#line default
#line hidden
            EndContext();
            BeginContext(204, 113, true);
            WriteLiteral("\r\n                You are the lead architect for your company\'s Microsoft Azure infrastructure.\r\n                ");
            EndContext();
            BeginContext(318, 26, false);
#line 8 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_18.cshtml"
           Write(Html.Raw(Model.H1CloseTag));

#line default
#line hidden
            EndContext();
            BeginContext(344, 53, true);
            WriteLiteral("\r\n            </p>\r\n            <p>\r\n                ");
            EndContext();
            BeginContext(398, 25, false);
#line 11 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_18.cshtml"
           Write(Html.Raw(Model.H2OpenTag));

#line default
#line hidden
            EndContext();
            BeginContext(423, 179, true);
            WriteLiteral("\r\n                To maintain corporate compliance certifications, you need to ensure that any virtual machines (VMs) are created only in approved Azure regions.\r\n                ");
            EndContext();
            BeginContext(603, 26, false);
#line 13 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_18.cshtml"
           Write(Html.Raw(Model.H2CloseTag));

#line default
#line hidden
            EndContext();
            BeginContext(629, 323, true);
            WriteLiteral(@"
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
                    <li>
                        <input type=""radio"" name=""group""");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 952, "\"", 976, 1);
#line 26 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_18.cshtml"
WriteAttributeValue("", 957, Html.GetNextId(), 957, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(977, 71, true);
            WriteLiteral(" class=\"k-radio\">\r\n                        <label class=\"k-radio-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 1048, "\"", 1077, 1);
#line 27 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_18.cshtml"
WriteAttributeValue("", 1054, Html.GetNextId(true), 1054, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1078, 209, true);
            WriteLiteral(">\r\n                            Create an Azure management group.\r\n                        </label>\r\n                    </li>\r\n                    <li>\r\n                        <input type=\"radio\" name=\"group\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1287, "\"", 1311, 1);
#line 32 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_18.cshtml"
WriteAttributeValue("", 1292, Html.GetNextId(), 1292, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1312, 71, true);
            WriteLiteral(" class=\"k-radio\">\r\n                        <label class=\"k-radio-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 1383, "\"", 1412, 1);
#line 33 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_18.cshtml"
WriteAttributeValue("", 1389, Html.GetNextId(true), 1389, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1413, 263, true);
            WriteLiteral(@">
                            Enforce conditional access policy in Azure Active Directory (Azure AD).
                        </label>
                    </li>
                    <li class=""correct"">
                        <input type=""radio"" name=""group""");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1676, "\"", 1700, 1);
#line 38 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_18.cshtml"
WriteAttributeValue("", 1681, Html.GetNextId(), 1681, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1701, 71, true);
            WriteLiteral(" class=\"k-radio\">\r\n                        <label class=\"k-radio-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 1772, "\"", 1801, 1);
#line 39 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_18.cshtml"
WriteAttributeValue("", 1778, Html.GetNextId(true), 1778, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1802, 225, true);
            WriteLiteral(">\r\n                            Define and deploy a custom Azure Policy template.\r\n                        </label>\r\n                    </li>\r\n                    <li>\r\n                        <input type=\"radio\" name=\"group\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2027, "\"", 2051, 1);
#line 44 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_18.cshtml"
WriteAttributeValue("", 2032, Html.GetNextId(), 2032, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2052, 71, true);
            WriteLiteral(" class=\"k-radio\">\r\n                        <label class=\"k-radio-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 2123, "\"", 2152, 1);
#line 45 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_18.cshtml"
WriteAttributeValue("", 2129, Html.GetNextId(true), 2129, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2153, 3023, true);
            WriteLiteral(@">
                            Define and deploy an Azure Automation Desired State Configuration (DSC) configuration.
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
                You should define and deploy a custom Azure Policy by using JSON and Azure PowerShell. Azure Resource Manager includes a number of predefined policy templates that cover various governance use cases. However, you can also build a custom template and upload it to Azure to make it available in your subscriptions.
            </p>
            <p>
                You should not define and deploy an Azure Automation DSC configuration. Azure Automation DSC prevents configuration drift on newly deployed or existing Azure or on-premises nodes. This scenario requires that you enforce compliance on VM locations at deployment time.
            </p>
            <p>
                You should no");
            WriteLiteral(@"t deploy a management group. A management group is a scope level above the Azure subscription that allows you to assign Azure Policy that affects multiple subscriptions simultaneously. In your case, you need to define a policy in the first place, and then you can optionally scope the new custom policy to a management group.
            </p>
            <p>
                You should not enforce conditional access policy on Azure Active Directory. This feature affects user accounts, not VMs deployed in Azure. Conditional access allows you to specify requirements for your users to access Azure AD-protected apps. For instance, you might require that users can only authenticate to an app if they are connecting from a corporate IP address.
            </p>
        </div>
    </li>
    <li>
        References
        <div>
            <p>
                <a href=""https://docs.microsoft.com/en-us/azure/azure-policy/create-manage-policy"" target=""_blank"" rel=""noopener"">Create and manage policies to enforce ");
            WriteLiteral(@"compliance</a>
            </p>
            <p>
                <a href=""https://docs.microsoft.com/en-us/azure/automation/automation-dsc-overview"" target=""_blank"" rel=""noopener"">Azure Automation State Configuration Overview</a>
            </p>
            <p>
                <a href=""https://docs.microsoft.com/en-us/azure/azure-policy/azure-policy-introduction"" target=""_blank"" rel=""noopener"">What is Azure Policy?</a>
            </p>
            <p>
                <a href=""https://docs.microsoft.com/en-us/azure/azure-resource-manager/management-groups-overview"" target=""_blank"" rel=""noopener"">Organize your resources with Azure management groups</a>
            </p>
            <p>
                <a href=""https://docs.microsoft.com/en-us/azure/active-directory/active-directory-conditional-access-azure-portal"" target=""_blank"" rel=""noopener"">What is conditional access in Azure Active Directory?</a>
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