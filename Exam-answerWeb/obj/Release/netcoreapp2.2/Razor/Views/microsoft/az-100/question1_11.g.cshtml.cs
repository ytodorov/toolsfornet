#pragma checksum "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question1_11.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e3d55610253cf39c529399df26b49581f2ef508"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_microsoft_az_100_question1_11), @"mvc.1.0.view", @"/Views/microsoft/az-100/question1_11.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/microsoft/az-100/question1_11.cshtml", typeof(AspNetCore.Views_microsoft_az_100_question1_11))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e3d55610253cf39c529399df26b49581f2ef508", @"/Views/microsoft/az-100/question1_11.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bee3447070987ca46eb03bbeb43d7bf40055dde5", @"/Views/_ViewImports.cshtml")]
    public class Views_microsoft_az_100_question1_11 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 111, true);
            WriteLiteral("<ul class=\"panelbar\">\r\n    <li class=\"k-state-active\">\r\n        <span class=\"k-link k-state-selected\">Question ");
            EndContext();
            BeginContext(112, 9, false);
#line 3 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question1_11.cshtml"
                                                  Write(Model?.Id);

#line default
#line hidden
            EndContext();
            BeginContext(121, 57, true);
            WriteLiteral("</span>\r\n        <div>\r\n            <p>\r\n                ");
            EndContext();
            BeginContext(179, 25, false);
#line 6 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question1_11.cshtml"
           Write(Html.Raw(Model.H1OpenTag));

#line default
#line hidden
            EndContext();
            BeginContext(204, 293, true);
            WriteLiteral(@"
                You are the owner of your organization's Microsoft Azure subscription. You hire a new administrator to help you manage a virtual network that contains nine Windows Server virtual machines (VMs). The deployment is contained in a resource group named prod-rg.
                ");
            EndContext();
            BeginContext(498, 26, false);
#line 8 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question1_11.cshtml"
           Write(Html.Raw(Model.H1CloseTag));

#line default
#line hidden
            EndContext();
            BeginContext(524, 53, true);
            WriteLiteral("\r\n            </p>\r\n            <p>\r\n                ");
            EndContext();
            BeginContext(578, 25, false);
#line 11 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question1_11.cshtml"
           Write(Html.Raw(Model.H2OpenTag));

#line default
#line hidden
            EndContext();
            BeginContext(603, 262, true);
            WriteLiteral(@"
                You need to provide the administrator with least-privilege access only to the prod-rg resource group. The administrator should be allowed to manage all aspects of the Azure VMs. Your solution should minimize management effort.
                ");
            EndContext();
            BeginContext(866, 26, false);
#line 13 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question1_11.cshtml"
           Write(Html.Raw(Model.H2CloseTag));

#line default
#line hidden
            EndContext();
            BeginContext(892, 672, true);
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
                        <input type=""radio"" name=""group"" id=""1_11"" class=""k-radio"">
                        <label class=""k-radio-label"" for=""1_11"">
                            Assign the Allowed virtual machine SKUs Azure Policy at the resource group scope.
                        </label>
                    </li>
                    <li>
                        <input type=""radio"" name=""group""");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1564, "\"", 1588, 1);
#line 32 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question1_11.cshtml"
WriteAttributeValue("", 1569, Html.GetNextId(), 1569, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1589, 71, true);
            WriteLiteral(" class=\"k-radio\">\r\n                        <label class=\"k-radio-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 1660, "\"", 1689, 1);
#line 33 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question1_11.cshtml"
WriteAttributeValue("", 1666, Html.GetNextId(true), 1666, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1690, 251, true);
            WriteLiteral(">\r\n                            Assign a custom Azure Policy at the management group scope.\r\n                        </label>\r\n                    </li>\r\n                    <li class=\"correct\">\r\n                        <input type=\"radio\" name=\"group\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1941, "\"", 1965, 1);
#line 38 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question1_11.cshtml"
WriteAttributeValue("", 1946, Html.GetNextId(), 1946, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1966, 71, true);
            WriteLiteral(" class=\"k-radio\">\r\n                        <label class=\"k-radio-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 2037, "\"", 2066, 1);
#line 39 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question1_11.cshtml"
WriteAttributeValue("", 2043, Html.GetNextId(true), 2043, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2067, 253, true);
            WriteLiteral(">\r\n                            Assign the administrator to the Contributor role at the resource group scope.\r\n                        </label>\r\n                    </li>\r\n                    <li>\r\n                        <input type=\"radio\" name=\"group\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2320, "\"", 2344, 1);
#line 44 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question1_11.cshtml"
WriteAttributeValue("", 2325, Html.GetNextId(), 2325, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2345, 71, true);
            WriteLiteral(" class=\"k-radio\">\r\n                        <label class=\"k-radio-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 2416, "\"", 2445, 1);
#line 45 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question1_11.cshtml"
WriteAttributeValue("", 2422, Html.GetNextId(true), 2422, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2446, 2968, true);
            WriteLiteral(@">
                            Assign the administrator to the Virtual Machine Operator role at the virtual machine scope.
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
                You should assign the administrator to the Contributor role at the resource group scope. The Contributor role-based access control (RBAC) role provides the new administrator with full read/write privileges at that scope. Inheritance ensures that the permissions cascade to the VMs within the prod-rg resource group and minimizes management overhead.
            </p>
            <p>
                You should not assign the administrator to the Virtual Machine Operator role at the virtual machine scope. The Virtual Machine Operator role does not grant the administrator full access to all resources contained on the virtual network. Moreover, making multiple RBAC assignments requires m");
            WriteLiteral(@"uch more management effort than making a single role assignment at a parent scope.
            </p>
            <p>
                You should not assign the Allowed virtual machine SKUs Azure Policy at the resource group scope. Doing so only restricts the administrator from selecting VM instance stock-keeping units (SKUs) that are defined in the Azure Policy. The scenario states only that the administrator should be able to fully manage existing VMs within the prod-rg resource group.
            </p>
            <p>
                You should not assign a custom Azure Policy at the management group scope. Azure Policy is a governance feature that restricts the types of resources administrators can select in Azure Resource Manager. In other words, Azure Policy is fundamentally different from RBAC, which limits the ability for administrators to take particular actions in the first place.
            </p>
        </div>
    </li>
    <li>
        References
        <div>
            <p>
          ");
            WriteLiteral(@"      <a href=""https://docs.microsoft.com/en-us/azure/role-based-access-control/overview"" target=""_blank"" rel=""noopener"">What is role-based access control (RBAC)?</a>
            </p>
            <p>
                <a href=""https://docs.microsoft.com/en-us/azure/role-based-access-control/rbac-and-directory-admin-roles"" target=""_blank"" rel=""noopener"">Classic subscription administrator roles, Azure RBAC roles, and Azure AD administrator roles</a>
            </p>
            <p>
                <a href=""https://docs.microsoft.com/en-us/azure/azure-policy/azure-policy-introduction"" target=""_blank"" rel=""noopener"">What is Azure Policy?</a>
            </p>
            <p>
                <a href=""https://docs.microsoft.com/en-us/azure/azure-policy/create-manage-policy"" target=""_blank"" rel=""noopener"">Create and manage policies to enforce compliance</a>
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
