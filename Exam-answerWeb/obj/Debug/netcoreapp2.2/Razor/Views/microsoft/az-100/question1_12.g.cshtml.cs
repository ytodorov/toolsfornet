#pragma checksum "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_12.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11757ee4879f54d3eaffe2764120deea348cda2d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_microsoft_az_100_question1_12), @"mvc.1.0.view", @"/Views/microsoft/az-100/question1_12.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/microsoft/az-100/question1_12.cshtml", typeof(AspNetCore.Views_microsoft_az_100_question1_12))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11757ee4879f54d3eaffe2764120deea348cda2d", @"/Views/microsoft/az-100/question1_12.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bee3447070987ca46eb03bbeb43d7bf40055dde5", @"/Views/_ViewImports.cshtml")]
    public class Views_microsoft_az_100_question1_12 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 111, true);
            WriteLiteral("<ul class=\"panelbar\">\r\n    <li class=\"k-state-active\">\r\n        <span class=\"k-link k-state-selected\">Question ");
            EndContext();
            BeginContext(112, 9, false);
#line 3 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_12.cshtml"
                                                  Write(Model?.Id);

#line default
#line hidden
            EndContext();
            BeginContext(121, 57, true);
            WriteLiteral("</span>\r\n        <div>\r\n            <p>\r\n                ");
            EndContext();
            BeginContext(179, 25, false);
#line 6 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_12.cshtml"
           Write(Html.Raw(Model.H1OpenTag));

#line default
#line hidden
            EndContext();
            BeginContext(204, 137, true);
            WriteLiteral("\r\n                You determine that business units have Azure resources spread across different Azure resource groups.\r\n                ");
            EndContext();
            BeginContext(342, 26, false);
#line 8 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_12.cshtml"
           Write(Html.Raw(Model.H1CloseTag));

#line default
#line hidden
            EndContext();
            BeginContext(368, 53, true);
            WriteLiteral("\r\n            </p>\r\n            <p>\r\n                ");
            EndContext();
            BeginContext(422, 25, false);
#line 11 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_12.cshtml"
           Write(Html.Raw(Model.H2OpenTag));

#line default
#line hidden
            EndContext();
            BeginContext(447, 115, true);
            WriteLiteral("\r\n                You need to make sure that resources are assigned to their proper cost centers.\r\n                ");
            EndContext();
            BeginContext(563, 26, false);
#line 13 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_12.cshtml"
           Write(Html.Raw(Model.H2CloseTag));

#line default
#line hidden
            EndContext();
            BeginContext(589, 339, true);
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
                    <li class=""correct"">
                        <input type=""radio"" name=""group""");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 928, "\"", 952, 1);
#line 26 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_12.cshtml"
WriteAttributeValue("", 933, Html.GetNextId(), 933, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(953, 71, true);
            WriteLiteral(" class=\"k-radio\">\r\n                        <label class=\"k-radio-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 1024, "\"", 1053, 1);
#line 27 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_12.cshtml"
WriteAttributeValue("", 1030, Html.GetNextId(true), 1030, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1054, 236, true);
            WriteLiteral(">\r\n                            Create taxonomic tags and assign them at the resource level.\r\n                        </label>\r\n                    </li>\r\n                    <li>\r\n                        <input type=\"radio\" name=\"group\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1290, "\"", 1314, 1);
#line 32 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_12.cshtml"
WriteAttributeValue("", 1295, Html.GetNextId(), 1295, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1315, 71, true);
            WriteLiteral(" class=\"k-radio\">\r\n                        <label class=\"k-radio-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 1386, "\"", 1415, 1);
#line 33 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_12.cshtml"
WriteAttributeValue("", 1392, Html.GetNextId(true), 1392, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1416, 242, true);
            WriteLiteral(">\r\n                            Create taxonomic tags and assign them at the resource group level.\r\n                        </label>\r\n                    </li>\r\n                    <li>\r\n                        <input type=\"radio\" name=\"group\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1658, "\"", 1682, 1);
#line 38 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_12.cshtml"
WriteAttributeValue("", 1663, Html.GetNextId(), 1663, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1683, 71, true);
            WriteLiteral(" class=\"k-radio\">\r\n                        <label class=\"k-radio-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 1754, "\"", 1783, 1);
#line 39 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_12.cshtml"
WriteAttributeValue("", 1760, Html.GetNextId(true), 1760, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1784, 245, true);
            WriteLiteral(">\r\n                            Deploy the Enforce tag and its value on resource groups Azure Policy.\r\n                        </label>\r\n                    </li>\r\n                    <li>\r\n                        <input type=\"radio\" name=\"group\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2029, "\"", 2053, 1);
#line 44 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_12.cshtml"
WriteAttributeValue("", 2034, Html.GetNextId(), 2034, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2054, 71, true);
            WriteLiteral(" class=\"k-radio\">\r\n                        <label class=\"k-radio-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 2125, "\"", 2154, 1);
#line 45 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question1_12.cshtml"
WriteAttributeValue("", 2131, Html.GetNextId(true), 2131, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2155, 2884, true);
            WriteLiteral(@">
                            Deploy the Enforce tag and its value Azure Policy.
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
                You should create taxonomic tags and assign them at the resource level. Tags in Azure are key-value string pairs that administrators can associate with Azure resources for logical organization. Identifying cost centers is an excellent use case for tags. Because corporate divisions own Azure resources spread across different Azure resource groups, you have to assign cost center tags at the resource level. Wherever possible, it is best practice to organize related resources into the same resource groups because you can then bulk-assign taxonomic tags to all contained resources in a single operation.
            </p>
            <p>
                You should not create taxonomic tags and assign them at the resource group l");
            WriteLiteral(@"evel. The scenario states that business units have resources spread across different resource groups. If you assign a particular cost center tag at the resource group level, then you likely will mis-tag contained resources owned by another business unit.
            </p>
            <p>
                You should not deploy the Enforce tag and its value Azure Policy. Doing so enforces the presence of a single specified tag and value pair. In this case, the scenario states that the organization has more than one cost center and therefore needs more than one taxonomic tag.
            </p>
            <p>
                You should not deploy the Enforce tag and its value on resource groups Azure Policy for the same reasons. The company has more than one cost center, and the business units have resources spread across multiple resource groups.
            </p>
        </div>
    </li>
    <li>
        References
        <div>
            <p>
                <a href=""https://docs.microsoft.com/en-u");
            WriteLiteral(@"s/azure/azure-resource-manager/resource-group-using-tags"" target=""_blank"" rel=""noopener"">Use tags to organize your Azure resources</a>
            </p>
            <p>
                <a href=""https://docs.microsoft.com/en-us/azure/billing/billing-getting-started"" target=""_blank"" rel=""noopener"">Prevent unexpected charges with Azure billing and cost management</a>
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
