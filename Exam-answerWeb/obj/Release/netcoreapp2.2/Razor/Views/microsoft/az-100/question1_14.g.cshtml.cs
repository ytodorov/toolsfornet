#pragma checksum "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question1_14.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb764c4ab6be56912691461b1d5508ab9e2f61f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_microsoft_az_100_question1_14), @"mvc.1.0.view", @"/Views/microsoft/az-100/question1_14.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/microsoft/az-100/question1_14.cshtml", typeof(AspNetCore.Views_microsoft_az_100_question1_14))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb764c4ab6be56912691461b1d5508ab9e2f61f4", @"/Views/microsoft/az-100/question1_14.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bee3447070987ca46eb03bbeb43d7bf40055dde5", @"/Views/_ViewImports.cshtml")]
    public class Views_microsoft_az_100_question1_14 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 111, true);
            WriteLiteral("<ul class=\"panelbar\">\r\n    <li class=\"k-state-active\">\r\n        <span class=\"k-link k-state-selected\">Question ");
            EndContext();
            BeginContext(112, 9, false);
#line 3 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question1_14.cshtml"
                                                  Write(Model?.Id);

#line default
#line hidden
            EndContext();
            BeginContext(121, 57, true);
            WriteLiteral("</span>\r\n        <div>\r\n            <p>\r\n                ");
            EndContext();
            BeginContext(179, 25, false);
#line 6 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question1_14.cshtml"
           Write(Html.Raw(Model.H1OpenTag));

#line default
#line hidden
            EndContext();
            BeginContext(204, 128, true);
            WriteLiteral("\r\n                You use taxonomic tags to logically organize resources and to make billing reporting easier.\r\n                ");
            EndContext();
            BeginContext(333, 26, false);
#line 8 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question1_14.cshtml"
           Write(Html.Raw(Model.H1CloseTag));

#line default
#line hidden
            EndContext();
            BeginContext(359, 53, true);
            WriteLiteral("\r\n            </p>\r\n            <p>\r\n                ");
            EndContext();
            BeginContext(413, 25, false);
#line 11 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question1_14.cshtml"
           Write(Html.Raw(Model.H2OpenTag));

#line default
#line hidden
            EndContext();
            BeginContext(438, 154, true);
            WriteLiteral("\r\n                You use Azure PowerShell to append an additional tag on a storage account named corpstorage99. The code is as follows:\r\n                ");
            EndContext();
            BeginContext(593, 26, false);
#line 13 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question1_14.cshtml"
           Write(Html.Raw(Model.H2CloseTag));

#line default
#line hidden
            EndContext();
            BeginContext(619, 203, true);
            WriteLiteral("\r\n            </p>\r\n            <p>\r\n                $r = Get-AzureRmResource -ResourceName \"corpstorage99\" -ResourceGroupName \"prod-rg\"\r\n                <br />\r\n                Set-AzureRmResource -Tag ");
            EndContext();
            BeginContext(823, 571, true);
            WriteLiteral(@"@{Dept=""IT""} -ResourceId $r.ResourceId -Force
            </p>
            <p>
                The code returns unexpected results.
            </p>
            <p>
                You need to append the additional tag as quickly as possible.
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
            BeginWriteAttribute("id", " id=\"", 1394, "\"", 1418, 1);
#line 37 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question1_14.cshtml"
WriteAttributeValue("", 1399, Html.GetNextId(), 1399, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1419, 71, true);
            WriteLiteral(" class=\"k-radio\">\r\n                        <label class=\"k-radio-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 1490, "\"", 1519, 1);
#line 38 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question1_14.cshtml"
WriteAttributeValue("", 1496, Html.GetNextId(true), 1496, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1520, 258, true);
            WriteLiteral(@">
                            Refactor the code by using the Azure Command-Line Interface (CLI).
                        </label>
                    </li>
                    <li class=""correct"">
                        <input type=""radio"" name=""group""");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1778, "\"", 1802, 1);
#line 43 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question1_14.cshtml"
WriteAttributeValue("", 1783, Html.GetNextId(), 1783, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1803, 71, true);
            WriteLiteral(" class=\"k-radio\">\r\n                        <label class=\"k-radio-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 1874, "\"", 1903, 1);
#line 44 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question1_14.cshtml"
WriteAttributeValue("", 1880, Html.GetNextId(true), 1880, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1904, 236, true);
            WriteLiteral(">\r\n                            Call the Add() method on the resource to append the new tag.\r\n                        </label>\r\n                    </li>\r\n                    <li>\r\n                        <input type=\"radio\" name=\"group\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2140, "\"", 2164, 1);
#line 49 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question1_14.cshtml"
WriteAttributeValue("", 2145, Html.GetNextId(), 2145, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2165, 71, true);
            WriteLiteral(" class=\"k-radio\">\r\n                        <label class=\"k-radio-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 2236, "\"", 2265, 1);
#line 50 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question1_14.cshtml"
WriteAttributeValue("", 2242, Html.GetNextId(true), 2242, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2266, 235, true);
            WriteLiteral(">\r\n                            Deploy the tag by using an Azure Resource Manager template.\r\n                        </label>\r\n                    </li>\r\n                    <li>\r\n                        <input type=\"radio\" name=\"group\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2501, "\"", 2525, 1);
#line 55 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question1_14.cshtml"
WriteAttributeValue("", 2506, Html.GetNextId(), 2506, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2526, 71, true);
            WriteLiteral(" class=\"k-radio\">\r\n                        <label class=\"k-radio-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 2597, "\"", 2626, 1);
#line 56 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question1_14.cshtml"
WriteAttributeValue("", 2603, Html.GetNextId(true), 2603, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2627, 3286, true);
            WriteLiteral(@">
                            Assign the Enforce tag and its value Azure Policy to the resource group.
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
                You should call the Add() method on the storage account resource as shown in the second line of this refactored Azure PowerShell code:
            </p>
            <p>
                $r = Get-AzureRmResource -ResourceName ""corpstorage99"" -ResourceGroupName ""prod-rg""
                <br />
                $r.Tags.Add(""Dept"", ""IT"")
                <br />
                Set-AzureRmResource -Tag $r.Tags -ResourceId $r.ResourceId -Force
            </p>
            <p>
                Unless you call the Add() method, the Set-AzureRmResource cmdlet will overwrite any existing taxonomic tags on the resource. The Add() method preserves existing tags and includes one or more tags to the resource ta");
            WriteLiteral(@"g list.
            </p>
            <p>
                You should not deploy the tag by using an Azure Resource Manager template. Doing so is unnecessary in this case because the Azure PowerShell is mostly complete as-is. Furthermore, you must find the solution as quickly as possible.
            </p>
            <p>
                You should not assign the Enforce tag and its value Azure Policy to the resource group. Azure Policy is a governance feature that helps businesses enforce compliance in resource creation. In this case, the solution involves too much administrative overhead to be a viable option. Moreover, the scenario makes no mention of the need for governance policy in specific terms.
            </p>
            <p>
                You should not refactor the code by using the Azure Command-Line Interface (CLI). Either Azure PowerShell or Azure CLI can be used to institute this solution. It makes no sense to change the development language given that you have already completed most o");
            WriteLiteral(@"f the code in PowerShell.
            </p>
        </div>
    </li>
    <li>
        References
        <div>
            <p>
                <a href=""https://docs.microsoft.com/en-us/azure/azure-resource-manager/resource-group-using-tags"" target=""_blank"" rel=""noopener"">Use tags to organize your Azure resources</a>
            </p>
            <p>
                <a href=""https://docs.microsoft.com/en-us/powershell/module/azurerm.resources/set-azurermresource"" target=""_blank"" rel=""noopener"">Set-AzureRmResource</a>
            </p>
            <p>
                <a href=""https://docs.microsoft.com/en-us/azure/azure-policy/azure-policy-introduction"" target=""_blank"" rel=""noopener"">What is Azure Policy?</a>
            </p>
            <p>
                <a href=""https://docs.microsoft.com/en-us/cli/azure/"" target=""_blank"" rel=""noopener"">Azure CLI</a>
            </p>
            <p>
                <a href=""https://docs.microsoft.com/en-us/azure/azure-resource-manager/resource-manager-quick");
            WriteLiteral("start-create-templates-use-the-portal\" target=\"_blank\" rel=\"noopener\">Quickstart: Create and deploy Azure Resource Manager templates by using the Azure portal</a>\r\n            </p>\r\n        </div>\r\n    </li>\r\n</ul>");
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
