#pragma checksum "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question1_9.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e87e0acde0536fcf88bb424410dd01906218ba8a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_microsoft_az_100_question1_9), @"mvc.1.0.view", @"/Views/microsoft/az-100/question1_9.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/microsoft/az-100/question1_9.cshtml", typeof(AspNetCore.Views_microsoft_az_100_question1_9))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e87e0acde0536fcf88bb424410dd01906218ba8a", @"/Views/microsoft/az-100/question1_9.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bee3447070987ca46eb03bbeb43d7bf40055dde5", @"/Views/_ViewImports.cshtml")]
    public class Views_microsoft_az_100_question1_9 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 111, true);
            WriteLiteral("<ul class=\"panelbar\">\r\n    <li class=\"k-state-active\">\r\n        <span class=\"k-link k-state-selected\">Question ");
            EndContext();
            BeginContext(112, 9, false);
#line 3 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question1_9.cshtml"
                                                  Write(Model?.Id);

#line default
#line hidden
            EndContext();
            BeginContext(121, 57, true);
            WriteLiteral("</span>\r\n        <div>\r\n            <p>\r\n                ");
            EndContext();
            BeginContext(179, 25, false);
#line 6 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question1_9.cshtml"
           Write(Html.Raw(Model.H1OpenTag));

#line default
#line hidden
            EndContext();
            BeginContext(204, 152, true);
            WriteLiteral("\r\n                You have an Azure resource group named RG1. RG1 contains 12 virtual machines (VMs) that run Windows Server or Linux.\r\n                ");
            EndContext();
            BeginContext(357, 26, false);
#line 8 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question1_9.cshtml"
           Write(Html.Raw(Model.H1CloseTag));

#line default
#line hidden
            EndContext();
            BeginContext(383, 53, true);
            WriteLiteral("\r\n            </p>\r\n            <p>\r\n                ");
            EndContext();
            BeginContext(437, 25, false);
#line 11 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question1_9.cshtml"
           Write(Html.Raw(Model.H2OpenTag));

#line default
#line hidden
            EndContext();
            BeginContext(462, 126, true);
            WriteLiteral("\r\n                You need to use Azure Cloud Shell to lift any resource locks that were applied to the VMs.\r\n                ");
            EndContext();
            BeginContext(589, 26, false);
#line 13 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\microsoft\az-100\question1_9.cshtml"
           Write(Html.Raw(Model.H2CloseTag));

#line default
#line hidden
            EndContext();
            BeginContext(615, 360, true);
            WriteLiteral(@"
            </p>
            <p>
                How should you complete the Azure PowerShell command? To answer, select the appropriate options from the drop-down menus.
            </p>
        </div>
    </li>
    <li class=""k-state-active"">
        Answers
        <div>
            <p>
                <select class=""ea"">
                    ");
            EndContext();
            BeginContext(975, 17, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e87e0acde0536fcf88bb424410dd01906218ba8a6817", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(992, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1014, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e87e0acde0536fcf88bb424410dd01906218ba8a7894", async() => {
                BeginContext(1042, 23, true);
                WriteLiteral("Get-AzureRmResourceLock");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1074, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1096, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e87e0acde0536fcf88bb424410dd01906218ba8a9191", async() => {
                BeginContext(1104, 19, true);
                WriteLiteral("Get-AzureRmResource");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1132, 118, true);
            WriteLiteral("\r\n                </select>\r\n                &nbsp;| &nbsp;\r\n                <select class=\"ea\">\r\n                    ");
            EndContext();
            BeginContext(1250, 17, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e87e0acde0536fcf88bb424410dd01906218ba8a10506", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1267, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1289, 30, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e87e0acde0536fcf88bb424410dd01906218ba8a11585", async() => {
                BeginContext(1297, 13, true);
                WriteLiteral("Select-Object");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1319, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1341, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e87e0acde0536fcf88bb424410dd01906218ba8a12790", async() => {
                BeginContext(1369, 12, true);
                WriteLiteral("Where-Object");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1390, 151, true);
            WriteLiteral("\r\n                </select>\r\n                &nbsp;ResourceGroupName -eq \"$rg-name\" | &nbsp;\r\n                <select class=\"ea\">\r\n                    ");
            EndContext();
            BeginContext(1541, 17, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e87e0acde0536fcf88bb424410dd01906218ba8a14217", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1558, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1580, 39, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e87e0acde0536fcf88bb424410dd01906218ba8a15296", async() => {
                BeginContext(1588, 22, true);
                WriteLiteral("Remove-AzureRmResource");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1619, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1641, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e87e0acde0536fcf88bb424410dd01906218ba8a16510", async() => {
                BeginContext(1669, 26, true);
                WriteLiteral("Remove-AzureRmResourceLock");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1704, 3243, true);
            WriteLiteral(@"
                </select>
            </p>
        </div>
    </li>
    <li>
        Explanation
        <div>
            <p>
                You should use the following command:
            </p>
            <p>
                $rg = ""rg1""
                <br />
                Get-AzureRmResourceLock |
                <br />
                Where-Object ResourceGroupName -eq ""$rg-name"" |
                <br />
                Remove-AzureRmResourceLock -Force
            </p>
            <p>
                To programmatically lift resource locks in Azure, start with the Get-AzureRmResourceLock command to retrieve all resource locks in your current subscription context. You can add a Where-Object filter expression to retrieve only locks from a particular resource group.
            </p>
            <p>
                Next, you can take advantage of the PowerShell pipeline by piping your results to the Remove-AzureRmResourceLock cmdlet to actually remove the locks. The -Force switc");
            WriteLiteral(@"h parameter forces the command to run without asking for user confirmation.
            </p>
            <p>
                You should not use the Get-AzureRmResource or Remove-AzureRmResource cmdlets because doing so requires far more PowerShell code than is shown in the scenario to retrieve only locked resources from a specific resource group.
            </p>
            <p>
                You should not use the Select-Object cmdlet because it filters at the property level, and not the row level, and would therefore not restrict output to locked resources within a single resource group.
            </p>
        </div>
    </li>
    <li>
        References
        <div>
            <p>
                <a href=""https://docs.microsoft.com/en-us/azure/azure-resource-manager/resource-group-lock-resources"" target=""_blank"" rel=""noopener"">Lock resources to prevent unexpected changes</a>
            </p>
            <p>
                <a href=""https://docs.microsoft.com/en-us/powershell/module/a");
            WriteLiteral(@"zurerm.resources/get-azurermresourcelock"" target=""_blank"" rel=""noopener"">Get-AzureRmResourceLock</a>
            </p>
            <p>
                <a href=""https://docs.microsoft.com/en-us/powershell/module/azurerm.resources/get-azurermresource"" target=""_blank"" rel=""noopener"">Get-AzureRmResource</a>
            </p>
            <p>
                <a href=""https://docs.microsoft.com/en-us/powershell/module/microsoft.powershell.core/where-object"" target=""_blank"" rel=""noopener"">Where-Object</a>
            </p>
            <p>
                <a href=""https://docs.microsoft.com/en-us/powershell/module/microsoft.powershell.utility/select-object"" target=""_blank"" rel=""noopener"">Select-Object</a>
            </p>
            <p>
                <a href=""https://docs.microsoft.com/en-us/powershell/module/azurerm.resources/remove-azurermresourcelock"" target=""_blank"" rel=""noopener"">Remove-AzureRmResourceLock</a>
            </p>
            <p>
                <a href=""https://docs.microsoft.com/en-u");
            WriteLiteral("s/powershell/module/azurerm.resources/remove-azurermresource\" target=\"_blank\" rel=\"noopener\">Remove-AzureRmResource</a>\r\n            </p>\r\n        </div>\r\n    </li>\r\n</ul>");
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
