#pragma checksum "C:\Users\bisso\OneDrive\Escritorio\BissoGit\bissoweb\bissoweb\Areas\Calculadora\Views\Calculadora\Calculadora.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ebef27dbcc2fd73b8cb182e257be402d593524a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Calculadora_Views_Calculadora_Calculadora), @"mvc.1.0.view", @"/Areas/Calculadora/Views/Calculadora/Calculadora.cshtml")]
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
#line 1 "C:\Users\bisso\OneDrive\Escritorio\BissoGit\bissoweb\bissoweb\Areas\Calculadora\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bisso\OneDrive\Escritorio\BissoGit\bissoweb\bissoweb\Areas\Calculadora\Views\_ViewImports.cshtml"
using bissoweb.Areas.Categorias.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\bisso\OneDrive\Escritorio\BissoGit\bissoweb\bissoweb\Areas\Calculadora\Views\_ViewImports.cshtml"
using bissoweb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ebef27dbcc2fd73b8cb182e257be402d593524a", @"/Areas/Calculadora/Views/Calculadora/Calculadora.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4025096c55eecd978ca12db0337a467cdd5105c5", @"/Areas/Calculadora/Views/_ViewImports.cshtml")]
    public class Areas_Calculadora_Views_Calculadora_Calculadora : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DatosCalculadora>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Calculadora", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Calculadora", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Calculadora", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\bisso\OneDrive\Escritorio\BissoGit\bissoweb\bissoweb\Areas\Calculadora\Views\Calculadora\Calculadora.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Calculadora</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ebef27dbcc2fd73b8cb182e257be402d593524a5221", async() => {
                WriteLiteral("\r\n    <div class=\"col-xs-6 col-md-3\">\r\n        <div class=\"col-md-10\">\r\n            <div class=\"row\">\r\n                <div>\r\n                    <h4>Numero1</h4>\r\n                    <input type=\"number\"");
                BeginWriteAttribute("value", " value=\"", 440, "\"", 459, 1);
#nullable restore
#line 15 "C:\Users\bisso\OneDrive\Escritorio\BissoGit\bissoweb\bissoweb\Areas\Calculadora\Views\Calculadora\Calculadora.cshtml"
WriteAttributeValue("", 448, Model.nro1, 448, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"nro1\" id=\"nro1\" class=\"form-control\" />\r\n                    <h4>Numero2</h4>\r\n                    <input type=\"number\"");
                BeginWriteAttribute("value", " value=\"", 586, "\"", 605, 1);
#nullable restore
#line 17 "C:\Users\bisso\OneDrive\Escritorio\BissoGit\bissoweb\bissoweb\Areas\Calculadora\Views\Calculadora\Calculadora.cshtml"
WriteAttributeValue("", 594, Model.nro2, 594, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"nro2\" id=\"nro2\" class=\"form-control\" />\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"col-md-10\">\r\n");
                WriteLiteral(@"            <div>
                <button style=""flex:1"" name=""operacion"" id=""operacion"" value=""1"" type=""submit"" class=""btn btn-outline-dark btn-lg"">+</button>
            </div>
            <div>
                <h4>Resultado</h4>
                <text>");
#nullable restore
#line 58 "C:\Users\bisso\OneDrive\Escritorio\BissoGit\bissoweb\bissoweb\Areas\Calculadora\Views\Calculadora\Calculadora.cshtml"
                 Write(Model.resultado);

#line default
#line hidden
#nullable disable
                WriteLiteral("</text>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DatosCalculadora> Html { get; private set; }
    }
}
#pragma warning restore 1591
