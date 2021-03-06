#pragma checksum "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question2_6.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2fb3bf1c090a18fd9a3d23fbc1fb71fbc85866f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_microsoft_az_100_question2_6), @"mvc.1.0.view", @"/Views/microsoft/az-100/question2_6.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/microsoft/az-100/question2_6.cshtml", typeof(AspNetCore.Views_microsoft_az_100_question2_6))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fb3bf1c090a18fd9a3d23fbc1fb71fbc85866f2", @"/Views/microsoft/az-100/question2_6.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bee3447070987ca46eb03bbeb43d7bf40055dde5", @"/Views/_ViewImports.cshtml")]
    public class Views_microsoft_az_100_question2_6 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 111, true);
            WriteLiteral("<ul class=\"panelbar\">\r\n    <li class=\"k-state-active\">\r\n        <span class=\"k-link k-state-selected\">Question ");
            EndContext();
            BeginContext(112, 9, false);
#line 3 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question2_6.cshtml"
                                                  Write(Model?.Id);

#line default
#line hidden
            EndContext();
            BeginContext(121, 57, true);
            WriteLiteral("</span>\r\n        <div>\r\n            <p>\r\n                ");
            EndContext();
            BeginContext(179, 25, false);
#line 6 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question2_6.cshtml"
           Write(Html.Raw(Model.H1OpenTag));

#line default
#line hidden
            EndContext();
            BeginContext(204, 155, true);
            WriteLiteral("\r\n                You have a Microsoft Azure subscription named Sub1. Your company has 120 terabytes (TB) in its on-premises data center.\r\n                ");
            EndContext();
            BeginContext(360, 26, false);
#line 8 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question2_6.cshtml"
           Write(Html.Raw(Model.H1CloseTag));

#line default
#line hidden
            EndContext();
            BeginContext(386, 53, true);
            WriteLiteral("\r\n            </p>\r\n            <p>\r\n                ");
            EndContext();
            BeginContext(440, 25, false);
#line 11 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question2_6.cshtml"
           Write(Html.Raw(Model.H2OpenTag));

#line default
#line hidden
            EndContext();
            BeginContext(465, 132, true);
            WriteLiteral("\r\n                You need to use Azure Import/Export Service to transfer the data into a storage account in Sub1.\r\n                ");
            EndContext();
            BeginContext(598, 26, false);
#line 13 "C:\Projects\toolsfornet\Exam-answerWeb\Views\microsoft\az-100\question2_6.cshtml"
           Write(Html.Raw(Model.H2CloseTag));

#line default
#line hidden
            EndContext();
            BeginContext(624, 4417, true);
            WriteLiteral(@"
            </p>
            <p>
                Which five actions should you perform in sequence? To answer, move the appropriate actions from the list of possible actions to the answer area and arrange them in the correct order.
            </p>
        </div>
    </li>
    <li class=""k-state-active"">
        Answers
        <div>
            <div class=""demo-section hidden-on-narrow two-way wide"">
                <div class=""list-wrapper"">
                    <ul id=""sortable-listC"">
                        <li class=""list-item"">Prepare the hard drives.</li>
                        <li class=""list-item"">Create an import job.</li>
                        <li class=""list-item"">Ship the drives to an Azure datacenter.</li>
                        <li class=""list-item"">Update the job with the tracking information.</li>
                        <li class=""list-item"">Verify the data upload to Azure.</li>
                        <li class=""list-item"">Ship the Azure Data Box to an Azure datacente");
            WriteLiteral(@"r.</li>
                        <li class=""list-item"">Order an Azure Data Box.</li>
                        <li class=""list-item"">Create an Azure Key Vault.</li>
                    </ul>
                </div>
            </div>
        </div>
    </li>
    <li>
        Explanation
        <div>
            <p>
                You should perform the following actions in order:
            </p>
            <p>
                1. Prepare the hard drives.
                <br />
                2. Create an import job.
                <br />
                3. Ship the drives to an Azure datacenter.
                <br />
                4. Update the job with the tracking information.
                <br />
                5. Verify the data upload to Azure.
            </p>
            <p>
                Azure Import/Export service is one way to securely transport large data volumes from your on-premises environment into Microsoft Azure. This service enables you to use your own hard ");
            WriteLiteral(@"drives to store the data. You use a command-line tool to prepare the drives and to populate them accordingly. You then pay for drive shipment to and from your desired Azure datacenter. All Import/Export service tasks can be tracked from the Azure portal.
            </p>
            <p>
                You should not use Azure Data Box in this scenario because the scenario stipulates that you plan to use the Import/Export service. Azure Data Box is a newer alternative method for large-scale data import and export with Azure. With Azure Data Box you rent a hard drive array from Microsoft, populate the device, ship it back to Microsoft, and they unpack your data, securely erase the Data Box contents, and re-use the appliance with another customer.
            </p>
            <p>
                You should not use Azure Key Vault because the Import/Export service stores your hard drive encryption keys in the Import/Export service job details in the Azure portal. Azure Key Vault is an Azure solution that l");
            WriteLiteral(@"everages hardware-based security to store and manage your secrets, digital certificates, and authentication keys.
            </p>
        </div>
    </li>
    <li>
        References
        <div>
            <p>
                <a href=""https://docs.microsoft.com/en-us/azure/storage/common/storage-import-export-data-to-files"" target=""_blank"" rel=""noopener"">Use Azure Import/Export service to import data to Azure Files</a>
            </p>
            <p>
                <a href=""https://docs.microsoft.com/en-us/azure/storage/common/storage-import-export-service-faq"" target=""_blank"" rel=""noopener"">Azure Import/Export service: frequently asked questions</a>
            </p>
            <p>
                <a href=""https://docs.microsoft.com/en-us/azure/databox/data-box-quickstart-portal"" target=""_blank"" rel=""noopener"">Quickstart: Deploy Azure Data Box using the Azure portal</a>
            </p>
            <p>
                <a href=""https://docs.microsoft.com/en-us/azure/databox/data-box-faq");
            WriteLiteral(@""" target=""_blank"" rel=""noopener"">Azure Data Box: Frequently Asked Questions</a>
            </p>
            <p>
                <a href=""https://docs.microsoft.com/en-us/azure/key-vault/key-vault-overview"" target=""_blank"" rel=""noopener"">What is Azure Key Vault?</a>
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
