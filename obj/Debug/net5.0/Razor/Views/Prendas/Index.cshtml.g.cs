#pragma checksum "D:\.net\practicaBdd\PracticaConBDD\PracticaConBDD\Views\Prendas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "651a409f7060f5cc196669a6ae8ab1eea9e8f73f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Prendas_Index), @"mvc.1.0.view", @"/Views/Prendas/Index.cshtml")]
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
#line 1 "D:\.net\practicaBdd\PracticaConBDD\PracticaConBDD\Views\_ViewImports.cshtml"
using PracticaConBDD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\.net\practicaBdd\PracticaConBDD\PracticaConBDD\Views\_ViewImports.cshtml"
using PracticaConBDD.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"651a409f7060f5cc196669a6ae8ab1eea9e8f73f", @"/Views/Prendas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a471ad306a86951cddae36471cd3bcb72680bec7", @"/Views/_ViewImports.cshtml")]
    public class Views_Prendas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PracticaConBDD.Models.Prendum>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Prendas/index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\.net\practicaBdd\PracticaConBDD\PracticaConBDD\Views\Prendas\Index.cshtml"
   
    List< PracticaConBDD.Models.TipoPrendum> todasTipoPrendas = ViewBag.TodasTipoPrendas;
    int? IdTipoPrendaSeleccionada = ViewBag.IdTipoPrendaSeleccionada;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "651a409f7060f5cc196669a6ae8ab1eea9e8f73f4646", async() => {
                WriteLiteral("\r\n    Tipo prenda:\r\n    <select name=\"IdTipoPrenda\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "651a409f7060f5cc196669a6ae8ab1eea9e8f73f4970", async() => {
                    WriteLiteral("Elija Prenda");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 11 "D:\.net\practicaBdd\PracticaConBDD\PracticaConBDD\Views\Prendas\Index.cshtml"
         foreach (var tipo in todasTipoPrendas)
        {
            if (tipo.IdTipoPrenda == IdTipoPrendaSeleccionada && IdTipoPrendaSeleccionada.HasValue)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "651a409f7060f5cc196669a6ae8ab1eea9e8f73f6584", async() => {
#nullable restore
#line 15 "D:\.net\practicaBdd\PracticaConBDD\PracticaConBDD\Views\Prendas\Index.cshtml"
                                                       Write(tipo.Descripcion);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 15 "D:\.net\practicaBdd\PracticaConBDD\PracticaConBDD\Views\Prendas\Index.cshtml"
                   WriteLiteral(tipo.IdTipoPrenda);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 16 "D:\.net\practicaBdd\PracticaConBDD\PracticaConBDD\Views\Prendas\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "651a409f7060f5cc196669a6ae8ab1eea9e8f73f9041", async() => {
#nullable restore
#line 19 "D:\.net\practicaBdd\PracticaConBDD\PracticaConBDD\Views\Prendas\Index.cshtml"
                                              Write(tipo.Descripcion);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 19 "D:\.net\practicaBdd\PracticaConBDD\PracticaConBDD\Views\Prendas\Index.cshtml"
                   WriteLiteral(tipo.IdTipoPrenda);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 20 "D:\.net\practicaBdd\PracticaConBDD\PracticaConBDD\Views\Prendas\Index.cshtml"
            }

        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </select>\r\n    <input type=\"submit\" value=\"filtrar\"/>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 27 "D:\.net\practicaBdd\PracticaConBDD\PracticaConBDD\Views\Prendas\Index.cshtml"
 if(Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>No hay prendas</div>\r\n");
#nullable restore
#line 30 "D:\.net\practicaBdd\PracticaConBDD\PracticaConBDD\Views\Prendas\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<table>\r\n    <tr>\r\n        <th>Tipo</th>\r\n        <th>Talle</th>\r\n        <th>Color</th>\r\n        <th>Modelo</th>\r\n        <th>Marca</th>\r\n    </tr>\r\n");
#nullable restore
#line 41 "D:\.net\practicaBdd\PracticaConBDD\PracticaConBDD\Views\Prendas\Index.cshtml"
     foreach (var prenda in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 44 "D:\.net\practicaBdd\PracticaConBDD\PracticaConBDD\Views\Prendas\Index.cshtml"
           Write(prenda.IdTipoPrendaNavigation.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 45 "D:\.net\practicaBdd\PracticaConBDD\PracticaConBDD\Views\Prendas\Index.cshtml"
           Write(prenda.Talle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 46 "D:\.net\practicaBdd\PracticaConBDD\PracticaConBDD\Views\Prendas\Index.cshtml"
           Write(prenda.Color);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 47 "D:\.net\practicaBdd\PracticaConBDD\PracticaConBDD\Views\Prendas\Index.cshtml"
           Write(prenda.Modelo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 48 "D:\.net\practicaBdd\PracticaConBDD\PracticaConBDD\Views\Prendas\Index.cshtml"
           Write(prenda.Marca);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 50 "D:\.net\practicaBdd\PracticaConBDD\PracticaConBDD\Views\Prendas\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
#nullable restore
#line 52 "D:\.net\practicaBdd\PracticaConBDD\PracticaConBDD\Views\Prendas\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PracticaConBDD.Models.Prendum>> Html { get; private set; }
    }
}
#pragma warning restore 1591