#pragma checksum "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question3_3.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40dcbeb139655dce72627b750cbb408e730fd028"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_microsoft_az_100_question3_3), @"mvc.1.0.view", @"/Views/microsoft/az-100/question3_3.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/microsoft/az-100/question3_3.cshtml", typeof(AspNetCore.Views_microsoft_az_100_question3_3))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40dcbeb139655dce72627b750cbb408e730fd028", @"/Views/microsoft/az-100/question3_3.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bee3447070987ca46eb03bbeb43d7bf40055dde5", @"/Views/_ViewImports.cshtml")]
    public class Views_microsoft_az_100_question3_3 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QuestionViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(26, 111, true);
            WriteLiteral("<ul class=\"panelbar\">\r\n    <li class=\"k-state-active\">\r\n        <span class=\"k-link k-state-selected\">Question ");
            EndContext();
            BeginContext(138, 9, false);
#line 4 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question3_3.cshtml"
                                                  Write(Model?.Id);

#line default
#line hidden
            EndContext();
            BeginContext(147, 113, true);
            WriteLiteral("<i class=\"fas fa-question\" style=\"text-align:right\"></i></span>\r\n        <div>\r\n            <p>\r\n                ");
            EndContext();
            BeginContext(261, 25, false);
#line 7 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question3_3.cshtml"
           Write(Html.Raw(Model.H1OpenTag));

#line default
#line hidden
            EndContext();
            BeginContext(286, 132, true);
            WriteLiteral("\r\n                You have an Azure resource group named RG1. RG1 contains a Linux virtual machine (VM) named VM1.\r\n                ");
            EndContext();
            BeginContext(419, 26, false);
#line 9 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question3_3.cshtml"
           Write(Html.Raw(Model.H1CloseTag));

#line default
#line hidden
            EndContext();
            BeginContext(445, 53, true);
            WriteLiteral("\r\n            </p>\r\n            <p>\r\n                ");
            EndContext();
            BeginContext(499, 25, false);
#line 12 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question3_3.cshtml"
           Write(Html.Raw(Model.H2OpenTag));

#line default
#line hidden
            EndContext();
            BeginContext(524, 153, true);
            WriteLiteral("\r\n                You need to automate the deployment of 20 additional Linux VMs. The new VMs should be based upon VM1\'s configuration.\r\n                ");
            EndContext();
            BeginContext(678, 26, false);
#line 14 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question3_3.cshtml"
           Write(Html.Raw(Model.H2CloseTag));

#line default
#line hidden
            EndContext();
            BeginContext(704, 466, true);
            WriteLiteral(@"
            </p>
            <p>
                Solution: From the resource group's Policies blade, you click Assign policy.
            </p>
            <p>
                Does this solution meet the goal?
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
            BeginWriteAttribute("id", " id=\"", 1170, "\"", 1194, 1);
#line 30 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question3_3.cshtml"
WriteAttributeValue("", 1175, Html.GetNextId(), 1175, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1195, 71, true);
            WriteLiteral(" class=\"k-radio\">\r\n                        <label class=\"k-radio-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 1266, "\"", 1295, 1);
#line 31 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question3_3.cshtml"
WriteAttributeValue("", 1272, Html.GetNextId(true), 1272, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1296, 139, true);
            WriteLiteral(">Yes</label>\r\n                    </li>\r\n                    <li class=\"correct\">\r\n                        <input type=\"radio\" name=\"group\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1435, "\"", 1459, 1);
#line 34 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question3_3.cshtml"
WriteAttributeValue("", 1440, Html.GetNextId(), 1440, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1460, 71, true);
            WriteLiteral(" class=\"k-radio\">\r\n                        <label class=\"k-radio-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 1531, "\"", 1560, 1);
#line 35 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question3_3.cshtml"
WriteAttributeValue("", 1537, Html.GetNextId(true), 1537, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1561, 1842, true);
            WriteLiteral(@">No</label>
                    </li>
                </ul>
            </p>
        </div>
    </li>
    <li>
        Explanation
        <div>
            <p>
                This solution does not meet the goal. To automate the deployment of the 20 additional VMs, you should access the virtual machine's underlying JavaScript Object Notation (JSON) template and deploy the new resources by using the template and custom deployment parameters. By contrast, Azure Policy is a governance product that makes it easier for Azure administrators to constrain deployments to meet organizational requirements. For example, you could deploy an Azure policy that requires all resource deployments to occur within only company-authorized geographic locations.
            </p>
        </div>
    </li>
    <li>
        References
        <div>
            <p>
                <a href=""https://docs.microsoft.com/en-us/azure/azure-resource-manager/resource-group-template-deploy-portal"" target=""_blank"" rel=""noopene");
            WriteLiteral(@"r"" tabindex=""190"">Deploy resources with Resource Manager templates and Azure portal</a>
            </p>
            <p>
                <a href=""https://docs.microsoft.com/en-us/azure/virtual-machines/windows/download-template"" target=""_blank"" rel=""noopener"" tabindex=""190"">Download the template for a VM</a>
            </p>
            <p>
                <a href=""https://docs.microsoft.com/en-us/azure/virtual-machines/windows/ps-template"" target=""_blank"" rel=""noopener"" tabindex=""190"">Create a Windows virtual machine from a Resource Manager template</a>
            </p>
            <p>
                <a href=""https://docs.microsoft.com/en-us/azure/governance/policy/overview"" target=""_blank"" rel=""noopener"" tabindex=""190"">What is Azure Policy?</a>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuestionViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591