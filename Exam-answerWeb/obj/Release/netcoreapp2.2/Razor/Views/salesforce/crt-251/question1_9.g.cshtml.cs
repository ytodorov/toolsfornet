#pragma checksum "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\salesforce\crt-251\question1_9.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b171b0a432c3403cf942f2dcbd87710c6c978fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_salesforce_crt_251_question1_9), @"mvc.1.0.view", @"/Views/salesforce/crt-251/question1_9.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/salesforce/crt-251/question1_9.cshtml", typeof(AspNetCore.Views_salesforce_crt_251_question1_9))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b171b0a432c3403cf942f2dcbd87710c6c978fb", @"/Views/salesforce/crt-251/question1_9.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bee3447070987ca46eb03bbeb43d7bf40055dde5", @"/Views/_ViewImports.cshtml")]
    public class Views_salesforce_crt_251_question1_9 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 111, true);
            WriteLiteral("<ul class=\"panelbar\">\r\n    <li class=\"k-state-active\">\r\n        <span class=\"k-link k-state-selected\">Question ");
            EndContext();
            BeginContext(112, 9, false);
#line 3 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\salesforce\crt-251\question1_9.cshtml"
                                                  Write(Model?.Id);

#line default
#line hidden
            EndContext();
            BeginContext(121, 57, true);
            WriteLiteral("</span>\r\n        <div>\r\n            <p>\r\n                ");
            EndContext();
            BeginContext(179, 25, false);
#line 6 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\salesforce\crt-251\question1_9.cshtml"
           Write(Html.Raw(Model.H1OpenTag));

#line default
#line hidden
            EndContext();
            BeginContext(204, 175, true);
            WriteLiteral("\r\n                Universal Containers has a public sharing model for accounts and uses the parent account field to create a multi-level account  hierarchy. \r\n                ");
            EndContext();
            BeginContext(380, 26, false);
#line 8 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\salesforce\crt-251\question1_9.cshtml"
           Write(Html.Raw(Model.H1CloseTag));

#line default
#line hidden
            EndContext();
            BeginContext(406, 53, true);
            WriteLiteral("\r\n            </p>\r\n            <p>\r\n                ");
            EndContext();
            BeginContext(460, 25, false);
#line 11 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\salesforce\crt-251\question1_9.cshtml"
           Write(Html.Raw(Model.H2OpenTag));

#line default
#line hidden
            EndContext();
            BeginContext(485, 164, true);
            WriteLiteral("\r\n                When viewing a parent account, the company wants to see the total value of open opportunities for all accounts in the hierarchy.\r\n                ");
            EndContext();
            BeginContext(650, 26, false);
#line 13 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\salesforce\crt-251\question1_9.cshtml"
           Write(Html.Raw(Model.H2CloseTag));

#line default
#line hidden
            EndContext();
            BeginContext(676, 390, true);
            WriteLiteral(@"
            </p>
            <p>
                Which solution should a consultant recommend to meet this requirement?
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
            BeginWriteAttribute("id", " id=\"", 1066, "\"", 1090, 1);
#line 26 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\salesforce\crt-251\question1_9.cshtml"
WriteAttributeValue("", 1071, Html.GetNextId(), 1071, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1091, 71, true);
            WriteLiteral(" class=\"k-radio\">\r\n                        <label class=\"k-radio-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 1162, "\"", 1191, 1);
#line 27 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\salesforce\crt-251\question1_9.cshtml"
WriteAttributeValue("", 1168, Html.GetNextId(true), 1168, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1192, 299, true);
            WriteLiteral(@">
                            Use Apex to update a custom field on the parent account with the total value of open opportunities form the child accounts.
                        </label>
                    </li>
                    <li>
                        <input type=""radio"" name=""group""");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1491, "\"", 1515, 1);
#line 32 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\salesforce\crt-251\question1_9.cshtml"
WriteAttributeValue("", 1496, Html.GetNextId(), 1496, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1516, 71, true);
            WriteLiteral(" class=\"k-radio\">\r\n                        <label class=\"k-radio-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 1587, "\"", 1616, 1);
#line 33 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\salesforce\crt-251\question1_9.cshtml"
WriteAttributeValue("", 1593, Html.GetNextId(true), 1593, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1617, 299, true);
            WriteLiteral(@">
                            Create a roll-up summary field on the parent account showing the total value of open opportunities from the child accounts.
                        </label>
                    </li>
                    <li>
                        <input type=""radio"" name=""group""");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1916, "\"", 1940, 1);
#line 38 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\salesforce\crt-251\question1_9.cshtml"
WriteAttributeValue("", 1921, Html.GetNextId(), 1921, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1941, 71, true);
            WriteLiteral(" class=\"k-radio\">\r\n                        <label class=\"k-radio-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 2012, "\"", 2041, 1);
#line 39 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\salesforce\crt-251\question1_9.cshtml"
WriteAttributeValue("", 2018, Html.GetNextId(true), 2018, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2042, 315, true);
            WriteLiteral(@">
                            Define a workflow rule to update the custom field on the parent account with the total value of open opportunities from the child accounts.
                        </label>
                    </li>
                    <li>
                        <input type=""radio"" name=""group""");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2357, "\"", 2381, 1);
#line 44 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\salesforce\crt-251\question1_9.cshtml"
WriteAttributeValue("", 2362, Html.GetNextId(), 2362, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2382, 71, true);
            WriteLiteral(" class=\"k-radio\">\r\n                        <label class=\"k-radio-label\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 2453, "\"", 2482, 1);
#line 45 "C:\Projects\exam-answer-repo\Exam-answer\Exam-answerWeb\Views\salesforce\crt-251\question1_9.cshtml"
WriteAttributeValue("", 2459, Html.GetNextId(true), 2459, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2483, 296, true);
            WriteLiteral(@">
                            Create a link on the account that opens a report showing the total value of open opportunities for all accounts in the hierarchy.
                        </label>
                    </li>
                </ul>
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
