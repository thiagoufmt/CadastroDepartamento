#pragma checksum "C:\Users\UFMT\source\repos\CRUD - Cadastro\WebApplicationCRUD\Views\RecordVendas\PesquisaAgrupada.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3033569171abc6c94a6366311fb559c410da1a47"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RecordVendas_PesquisaAgrupada), @"mvc.1.0.view", @"/Views/RecordVendas/PesquisaAgrupada.cshtml")]
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
#nullable restore
#line 1 "C:\Users\UFMT\source\repos\CRUD - Cadastro\WebApplicationCRUD\Views\_ViewImports.cshtml"
using WebApplicationCRUD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\UFMT\source\repos\CRUD - Cadastro\WebApplicationCRUD\Views\_ViewImports.cshtml"
using WebApplicationCRUD.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3033569171abc6c94a6366311fb559c410da1a47", @"/Views/RecordVendas/PesquisaAgrupada.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7fac9cb09ab988a81fa24d6f708a82d852b611f", @"/Views/_ViewImports.cshtml")]
    public class Views_RecordVendas_PesquisaAgrupada : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IGrouping<Department, RecordeVendas>>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-form navbar-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\UFMT\source\repos\CRUD - Cadastro\WebApplicationCRUD\Views\RecordVendas\PesquisaAgrupada.cshtml"
  
    ViewData["Title"] = "Pesquisa Agrupada";
    DateTime minDate = DateTime.Parse(ViewData["minDate"] as string);
    DateTime maxDate = DateTime.Parse(ViewData["maxDate"] as string);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 10 "C:\Users\UFMT\source\repos\CRUD - Cadastro\WebApplicationCRUD\Views\RecordVendas\PesquisaAgrupada.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<nav class=\"navbar navbar-inverse\">\r\n    <div class=\"container-fluid\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3033569171abc6c94a6366311fb559c410da1a474857", async() => {
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <div class=\"form-group\">\r\n                    <label for=\"minDate\">Min Date</label>\r\n                    <input type=\"date\" class=\"form-control\" name=\"minDate\"");
                BeginWriteAttribute("value", " value=", 635, "", 662, 1);
#nullable restore
#line 17 "C:\Users\UFMT\source\repos\CRUD - Cadastro\WebApplicationCRUD\Views\RecordVendas\PesquisaAgrupada.cshtml"
WriteAttributeValue("", 642, ViewData["minDate"], 642, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"maxDate\">Max Date</label>\r\n                    <input type=\"date\" class=\"form-control\" name=\"maxDate\"");
                BeginWriteAttribute("value", " value=", 864, "", 891, 1);
#nullable restore
#line 21 "C:\Users\UFMT\source\repos\CRUD - Cadastro\WebApplicationCRUD\Views\RecordVendas\PesquisaAgrupada.cshtml"
WriteAttributeValue("", 871, ViewData["maxDate"], 871, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                </div>\r\n            </div>\r\n            <button type=\"submit\" class=\"btn btn-primary\">Filter</button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</nav>\r\n\r\n");
#nullable restore
#line 29 "C:\Users\UFMT\source\repos\CRUD - Cadastro\WebApplicationCRUD\Views\RecordVendas\PesquisaAgrupada.cshtml"
 foreach (var departmentGroup in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"panel panel-primary\">\r\n        <div class=\"panel-heading\">\r\n            <h3 class=\"panel-title\">Department ");
#nullable restore
#line 33 "C:\Users\UFMT\source\repos\CRUD - Cadastro\WebApplicationCRUD\Views\RecordVendas\PesquisaAgrupada.cshtml"
                                          Write(departmentGroup.Key.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(", Total vendas = ");
#nullable restore
#line 33 "C:\Users\UFMT\source\repos\CRUD - Cadastro\WebApplicationCRUD\Views\RecordVendas\PesquisaAgrupada.cshtml"
                                                                                    Write(departmentGroup.Key.TotalVendas(minDate, maxDate).ToString("F2"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
        </div>
        <div class=""panel-body"">
            <table class=""table table-striped table-hover"">
                <thead>
                    <tr class=""success"">
                        <th>
                            Data
                        </th>
                        <th>
                            Quantidade
                        </th>
                        <th>
                            Vendedor
                        </th>
                        <th>
                            Status
                        </th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 54 "C:\Users\UFMT\source\repos\CRUD - Cadastro\WebApplicationCRUD\Views\RecordVendas\PesquisaAgrupada.cshtml"
                     foreach (var item in departmentGroup)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 58 "C:\Users\UFMT\source\repos\CRUD - Cadastro\WebApplicationCRUD\Views\RecordVendas\PesquisaAgrupada.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Data));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 61 "C:\Users\UFMT\source\repos\CRUD - Cadastro\WebApplicationCRUD\Views\RecordVendas\PesquisaAgrupada.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Quantidade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 64 "C:\Users\UFMT\source\repos\CRUD - Cadastro\WebApplicationCRUD\Views\RecordVendas\PesquisaAgrupada.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Vendedor.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 67 "C:\Users\UFMT\source\repos\CRUD - Cadastro\WebApplicationCRUD\Views\RecordVendas\PesquisaAgrupada.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 70 "C:\Users\UFMT\source\repos\CRUD - Cadastro\WebApplicationCRUD\Views\RecordVendas\PesquisaAgrupada.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 75 "C:\Users\UFMT\source\repos\CRUD - Cadastro\WebApplicationCRUD\Views\RecordVendas\PesquisaAgrupada.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IGrouping<Department, RecordeVendas>>> Html { get; private set; }
    }
}
#pragma warning restore 1591