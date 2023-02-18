#pragma checksum "C:\Users\HP\source\repos\CoreSM\CoreSM\Views\Reports\AdvanceTaxPaid.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7cdc75ab482a2ed1d26cea17f893cc7aaa15b081"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reports_AdvanceTaxPaid), @"mvc.1.0.view", @"/Views/Reports/AdvanceTaxPaid.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Reports/AdvanceTaxPaid.cshtml", typeof(AspNetCore.Views_Reports_AdvanceTaxPaid))]
namespace AspNetCore
{
    #line hidden
#line 2 "C:\Users\HP\source\repos\CoreSM\CoreSM\Views\Reports\AdvanceTaxPaid.cshtml"
using System;

#line default
#line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\HP\source\repos\CoreSM\CoreSM\Views\_ViewImports.cshtml"
using CoreSM;

#line default
#line hidden
#line 2 "C:\Users\HP\source\repos\CoreSM\CoreSM\Views\_ViewImports.cshtml"
using CoreSM.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cdc75ab482a2ed1d26cea17f893cc7aaa15b081", @"/Views/Reports/AdvanceTaxPaid.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53bae0f71a1bdfba5a18f52ae2cf72cc3ac85bd0", @"/Views/_ViewImports.cshtml")]
    public class Views_Reports_AdvanceTaxPaid : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CoreSM.Models.Invoice>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 24px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/icons8-edit-50.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/icon/icons8-trash-can-50.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\HP\source\repos\CoreSM\CoreSM\Views\Reports\AdvanceTaxPaid.cshtml"
  
    ViewData["Title"] = "AdvanceTaxPaid";

#line default
#line hidden
            BeginContext(109, 1047, true);
            WriteLiteral(@"
<div class=""container-fluid"">
    <div class=""row"">
        <div class=""col-lg-12"">
            <div class=""card"">
                <div class=""card-header"">Advance Tax Paid</div>
                <div class=""card-body"">
                    <div class=""row"">
                        <div class=""col-md-12"">
                            <table id=""invoice"" class=""table table-striped table-bordered"" style=""width:100%"">
                                <thead>
                                    <tr>
                                        <th>Invoice Date</th>
                                        <th>CNIC</th>
                                        <th>Category</th>
                                        <th>Tax Rate</th>
                                        <th>Tax Withheld</th>
                                        <th>Tax Amount</th>
                                        <th></th>
                                    </tr>
                                </thead>
                  ");
            WriteLiteral("              <tbody>\r\n");
            EndContext();
#line 28 "C:\Users\HP\source\repos\CoreSM\CoreSM\Views\Reports\AdvanceTaxPaid.cshtml"
                                     foreach (var item in Model)
                                    {

#line default
#line hidden
            BeginContext(1261, 144, true);
            WriteLiteral("                                        <tr>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(1406, 36, false);
#line 32 "C:\Users\HP\source\repos\CoreSM\CoreSM\Views\Reports\AdvanceTaxPaid.cshtml"
                                           Write(item.InvoiceDate.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(1442, 101, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>");
            EndContext();
            BeginContext(1544, 9, false);
#line 34 "C:\Users\HP\source\repos\CoreSM\CoreSM\Views\Reports\AdvanceTaxPaid.cshtml"
                                           Write(item.CNIC);

#line default
#line hidden
            EndContext();
            BeginContext(1553, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(1609, 13, false);
#line 35 "C:\Users\HP\source\repos\CoreSM\CoreSM\Views\Reports\AdvanceTaxPaid.cshtml"
                                           Write(item.SaleType);

#line default
#line hidden
            EndContext();
            BeginContext(1622, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(1678, 12, false);
#line 36 "C:\Users\HP\source\repos\CoreSM\CoreSM\Views\Reports\AdvanceTaxPaid.cshtml"
                                           Write(item.TaxRate);

#line default
#line hidden
            EndContext();
            BeginContext(1690, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(1746, 16, false);
#line 37 "C:\Users\HP\source\repos\CoreSM\CoreSM\Views\Reports\AdvanceTaxPaid.cshtml"
                                           Write(item.TaxWithheld);

#line default
#line hidden
            EndContext();
            BeginContext(1762, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(1818, 14, false);
#line 38 "C:\Users\HP\source\repos\CoreSM\CoreSM\Views\Reports\AdvanceTaxPaid.cshtml"
                                           Write(item.TaxAmount);

#line default
#line hidden
            EndContext();
            BeginContext(1832, 123, true);
            WriteLiteral("</td>\r\n                                            <td>\r\n                                                <a target=\"_blank\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1955, "\"", 1979, 2);
            WriteAttributeValue("", 1962, "/Invoice/", 1962, 9, true);
#line 40 "C:\Users\HP\source\repos\CoreSM\CoreSM\Views\Reports\AdvanceTaxPaid.cshtml"
WriteAttributeValue("", 1971, item.ID, 1971, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1980, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1981, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "54f1292d24624ebc972b5d225d9786a0", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2043, 56, true);
            WriteLiteral("</a>\r\n                                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2099, "\"", 2129, 2);
            WriteAttributeValue("", 2106, "/RemoveInvoice/", 2106, 15, true);
#line 41 "C:\Users\HP\source\repos\CoreSM\CoreSM\Views\Reports\AdvanceTaxPaid.cshtml"
WriteAttributeValue("", 2121, item.ID, 2121, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2130, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2131, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3290716ed6ae48238f2e8dbd855a52e0", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2203, 104, true);
            WriteLiteral("</a>\r\n                                            </td>\r\n                                        </tr>\r\n");
            EndContext();
#line 44 "C:\Users\HP\source\repos\CoreSM\CoreSM\Views\Reports\AdvanceTaxPaid.cshtml"
                                    }

#line default
#line hidden
            BeginContext(2346, 851, true);
            WriteLiteral(@"                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<script>
    $(document).ready(function () {
        $('#invoice').DataTable();
    });

    function convertdate(date) {
        var fullDate = new Date(date);
        var twoDigitMonth = fullDate.getMonth() + """";
        if (twoDigitMonth.length == 1)
            twoDigitMonth = ""0"" + twoDigitMonth;
        var twoDigitDate = fullDate.getDate() + """";
        if (twoDigitDate.length == 1)
            twoDigitDate = ""0"" + twoDigitDate;
        var currentDate = twoDigitDate + ""/"" + twoDigitMonth + ""/"" + fullDate.getFullYear();
        console.log(currentDate);
        return currentDate;
    }
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CoreSM.Models.Invoice>> Html { get; private set; }
    }
}
#pragma warning restore 1591
