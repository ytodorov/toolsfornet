#pragma checksum "C:\Projects\toolsfornet\Exam-answerWeb\Views\Shared\_JsScripts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3df477ccd6ca62f71fd71d7ead96d9771e3697db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__JsScripts), @"mvc.1.0.view", @"/Views/Shared/_JsScripts.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_JsScripts.cshtml", typeof(AspNetCore.Views_Shared__JsScripts))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3df477ccd6ca62f71fd71d7ead96d9771e3697db", @"/Views/Shared/_JsScripts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bee3447070987ca46eb03bbeb43d7bf40055dde5", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__JsScripts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1143, true);
            WriteLiteral(@"<script src=""https://kendo.cdn.telerik.com/2019.1.220/js/jszip.min.js""></script>
<script src=""https://kendo.cdn.telerik.com/2019.1.220/js/kendo.all.min.js""></script>
<script src=""https://kendo.cdn.telerik.com/2019.1.220/js/kendo.aspnetmvc.min.js""></script>
<script>
    function placeholder(element) {
        return $(""<li class='list-item' id='placeholder'>Drop Here!</li>"");
    }

    $(document).ready(function () {
        $(""#menu"").kendoMenu();

        $(""#panelbar, .panelbar"").kendoPanelBar({
            expandMode: ""multi""
        });

        $(""select.ea"").kendoDropDownList({
            autoWidth: true
        });

        $(""#sortable-listC"").kendoSortable({
            placeholder: placeholder
        });

        $(""body"").show();

        $(""#gridExams"").kendoGrid({
            sortable: true
        });

    });

    $(document).ajaxSend(function (event, request, settings) {
        //settings.url = settings.url.toLowerCase();
    });
</script>

<script>
   ");
            WriteLiteral(" function onAdditionalData() {\r\n        return {\r\n            text: $(\"#questions\").val()\r\n        };\r\n    }\r\n</script>");
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
