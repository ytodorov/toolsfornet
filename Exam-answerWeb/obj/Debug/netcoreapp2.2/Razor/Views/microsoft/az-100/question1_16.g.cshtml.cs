#pragma checksum "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_16.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9b0e15d64a0191619daaca8e9bab11b6b71f393"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_microsoft_az_100_question1_16), @"mvc.1.0.view", @"/Views/microsoft/az-100/question1_16.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/microsoft/az-100/question1_16.cshtml", typeof(AspNetCore.Views_microsoft_az_100_question1_16))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9b0e15d64a0191619daaca8e9bab11b6b71f393", @"/Views/microsoft/az-100/question1_16.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bee3447070987ca46eb03bbeb43d7bf40055dde5", @"/Views/_ViewImports.cshtml")]
    public class Views_microsoft_az_100_question1_16 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 111, true);
            WriteLiteral("<ul class=\"panelbar\">\r\n    <li class=\"k-state-active\">\r\n        <span class=\"k-link k-state-selected\">Question ");
            EndContext();
            BeginContext(112, 9, false);
#line 3 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_16.cshtml"
                                                  Write(Model?.Id);

#line default
#line hidden
            EndContext();
            BeginContext(121, 57, true);
            WriteLiteral("</span>\r\n        <div>\r\n            <p>\r\n                ");
            EndContext();
            BeginContext(179, 25, false);
#line 6 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_16.cshtml"
           Write(Html.Raw(Model.H1OpenTag));

#line default
#line hidden
            EndContext();
            BeginContext(204, 164, true);
            WriteLiteral("\r\n                Your company has an Azure Subscription with several resources deployed. The subscription is managed by a Cloud Service Provider.\r\n                ");
            EndContext();
            BeginContext(369, 26, false);
#line 8 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_16.cshtml"
           Write(Html.Raw(Model.H1CloseTag));

#line default
#line hidden
            EndContext();
            BeginContext(395, 53, true);
            WriteLiteral("\r\n            </p>\r\n            <p>\r\n                ");
            EndContext();
            BeginContext(449, 25, false);
#line 11 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_16.cshtml"
           Write(Html.Raw(Model.H2OpenTag));

#line default
#line hidden
            EndContext();
            BeginContext(474, 262, true);
            WriteLiteral(@"
                The accounting department is currently granted the billing reader role, so they are able to see cost-related information. They need to get a better understanding of the costs so they can assign them to the correct cost center.
                ");
            EndContext();
            BeginContext(737, 26, false);
#line 13 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_16.cshtml"
           Write(Html.Raw(Model.H2CloseTag));

#line default
#line hidden
            EndContext();
            BeginContext(763, 551, true);
            WriteLiteral(@"
            </p>
            <p>
                You need to provide cost center information. Your solution should minimize the administrative effort.
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
                    <li class=""correct"">
                        <input type=""checkbox""");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1314, "\"", 1338, 1);
#line 29 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_16.cshtml"
WriteAttributeValue("", 1319, Html.GetNextId(), 1319, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1339, 77, true);
            WriteLiteral(" class=\"k-checkbox\">\r\n                        <label class=\"k-checkbox-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 1416, "\"", 1445, 1);
#line 30 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_16.cshtml"
WriteAttributeValue("", 1422, Html.GetNextId(true), 1422, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1446, 227, true);
            WriteLiteral(">\r\n                            Create a tag named CostCenter and assign it to each resource.\r\n                        </label>\r\n                    </li>\r\n                    <li>\r\n                        <input type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1673, "\"", 1697, 1);
#line 35 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_16.cshtml"
WriteAttributeValue("", 1678, Html.GetNextId(), 1678, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1698, 77, true);
            WriteLiteral(" class=\"k-checkbox\">\r\n                        <label class=\"k-checkbox-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 1775, "\"", 1804, 1);
#line 36 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_16.cshtml"
WriteAttributeValue("", 1781, Html.GetNextId(true), 1781, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1805, 258, true);
            WriteLiteral(@">
                            Instruct the accounting department to use the Cost Analysis blade in the subscription panel.
                        </label>
                    </li>
                    <li>
                        <input type=""checkbox""");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2063, "\"", 2087, 1);
#line 41 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_16.cshtml"
WriteAttributeValue("", 2068, Html.GetNextId(), 2068, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2088, 77, true);
            WriteLiteral(" class=\"k-checkbox\">\r\n                        <label class=\"k-checkbox-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 2165, "\"", 2194, 1);
#line 42 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_16.cshtml"
WriteAttributeValue("", 2171, Html.GetNextId(true), 2171, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2195, 249, true);
            WriteLiteral(">\r\n                            Instruct the accounting department to use the Azure Account Center.\r\n                        </label>\r\n                    </li>\r\n                    <li class=\"correct\">\r\n                        <input type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2444, "\"", 2468, 1);
#line 47 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_16.cshtml"
WriteAttributeValue("", 2449, Html.GetNextId(), 2449, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2469, 77, true);
            WriteLiteral(" class=\"k-checkbox\">\r\n                        <label class=\"k-checkbox-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 2546, "\"", 2575, 1);
#line 48 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_16.cshtml"
WriteAttributeValue("", 2552, Html.GetNextId(true), 2552, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2576, 2831, true);
            WriteLiteral(@">
                            Create a tag named CostCenter and assign it to each resource group.
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
                You should create a tag named CostCenter and assign it to each resource group. Creating a tag and assigning it to each resource group allows you to easily identify the cost center associated with each resource group. When you associate a tag with a resource or resource group, you need to provide a value to that tag. You can instruct the accounting department to use the Azure Cost Management tool to review the costs associated with each cost center by filtering by the newly created tag.
            </p>
            <p>
                You should also create a tag named CostCenter and assign it to each resource. If you apply a tag to a resource group, that tag is not inherited by the resources in the resou");
            WriteLiteral(@"rce group. You need to manually configure the tag for each resource that you want to include in the cost center. You can automate this action by using a PowerShell or Azure CLI script.
            </p>
            <p>
                You should not instruct the accounting department to use either the Cost Analysis blade in the subscription panel or the Azure Account Center. Because your subscription is managed by a Cloud Service Provider, you can get that information from your provider. You can also get this information by using the Azure Cost Management tool.
            </p>
        </div>
    </li>
    <li>
        References
        <div>
            <p>
                <a title=""Use tags to organize your Azure resources"" href=""https://docs.microsoft.com/en-us/azure/azure-resource-manager/resource-group-using-tags"" target=""_blank"" rel=""noopener"">Use tags to organize your Azure resources</a>
            </p>
            <p>
                <a title=""Prevent unexpected charges with Azure billi");
            WriteLiteral(@"ng and cost management"" href=""https://docs.microsoft.com/en-us/azure/billing/billing-getting-started"" target=""_blank"" rel=""noopener""><br>Prevent unexpected charges with Azure billing and cost management</a>
            </p>
            <p>
                <a title=""Use tags to organize your Azure resources"" href=""https://docs.microsoft.com/en-us/azure/azure-resource-manager/resource-group-using-tags"" target=""_blank"" rel=""noopener""><br>Use tags to organize your Azure resources</a>
            </p>
            <p>
                <a title=""What is Azure Cost Management?"" href=""https://docs.microsoft.com/en-us/azure/cost-management/overview-cost-mgt"" target=""_blank"" rel=""noopener""><br>What is Azure Cost Management?</a>
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
