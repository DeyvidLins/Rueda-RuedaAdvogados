#pragma checksum "C:\Users\Deyvid\Desktop\CadastroPessoas\CadastroPessoas\Views\Telefones\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f91858b7bb1e86804027e72d89ea6493509e941"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Telefones_Index), @"mvc.1.0.view", @"/Views/Telefones/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Telefones/Index.cshtml", typeof(AspNetCore.Views_Telefones_Index))]
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
#line 1 "C:\Users\Deyvid\Desktop\CadastroPessoas\CadastroPessoas\Views\_ViewImports.cshtml"
using CadastroPessoas;

#line default
#line hidden
#line 2 "C:\Users\Deyvid\Desktop\CadastroPessoas\CadastroPessoas\Views\_ViewImports.cshtml"
using CadastroPessoas.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f91858b7bb1e86804027e72d89ea6493509e941", @"/Views/Telefones/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"956f9707fb66cb0b48d1054899b1a8f2a8ed7029", @"/Views/_ViewImports.cshtml")]
    public class Views_Telefones_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CadastroPessoas.Models.Telefone>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AtualizarTelefone", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ExcluirTelefone", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Deyvid\Desktop\CadastroPessoas\CadastroPessoas\Views\Telefones\Index.cshtml"
  
    ViewData["Title"] = "Lista de Telefones";

#line default
#line hidden
            BeginContext(109, 121, true);
            WriteLiteral("\r\n<h1>Lista de Telefones</h1>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(231, 42, false);
#line 15 "C:\Users\Deyvid\Desktop\CadastroPessoas\CadastroPessoas\Views\Telefones\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.numero));

#line default
#line hidden
            EndContext();
            BeginContext(273, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(329, 40, false);
#line 18 "C:\Users\Deyvid\Desktop\CadastroPessoas\CadastroPessoas\Views\Telefones\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.tipo));

#line default
#line hidden
            EndContext();
            BeginContext(369, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 24 "C:\Users\Deyvid\Desktop\CadastroPessoas\CadastroPessoas\Views\Telefones\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(504, 11, true);
            WriteLiteral("        <tr");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 515, "\"", 537, 2);
            WriteAttributeValue("", 520, "telefone-", 520, 9, true);
#line 26 "C:\Users\Deyvid\Desktop\CadastroPessoas\CadastroPessoas\Views\Telefones\Index.cshtml"
WriteAttributeValue("", 529, item.id, 529, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(538, 39, true);
            WriteLiteral(">\r\n\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(578, 41, false);
#line 29 "C:\Users\Deyvid\Desktop\CadastroPessoas\CadastroPessoas\Views\Telefones\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.numero));

#line default
#line hidden
            EndContext();
            BeginContext(619, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(675, 39, false);
#line 32 "C:\Users\Deyvid\Desktop\CadastroPessoas\CadastroPessoas\Views\Telefones\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.tipo));

#line default
#line hidden
            EndContext();
            BeginContext(714, 75, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n            <td>\r\n\r\n                ");
            EndContext();
            BeginContext(789, 95, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f91858b7bb1e86804027e72d89ea6493509e9417538", async() => {
                BeginContext(871, 9, true);
                WriteLiteral("Atualizar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 37 "C:\Users\Deyvid\Desktop\CadastroPessoas\CadastroPessoas\Views\Telefones\Index.cshtml"
                                                                            WriteLiteral(item.id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(884, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(902, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f91858b7bb1e86804027e72d89ea6493509e94110008", async() => {
                BeginContext(981, 7, true);
                WriteLiteral("Excluir");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 38 "C:\Users\Deyvid\Desktop\CadastroPessoas\CadastroPessoas\Views\Telefones\Index.cshtml"
                                                                         WriteLiteral(item.id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(992, 71, true);
            WriteLiteral("\r\n              \r\n            </td>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 43 "C:\Users\Deyvid\Desktop\CadastroPessoas\CadastroPessoas\Views\Telefones\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1074, 166, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<p>\r\n    <button type=\"button\" class=\"btn btn-outline-primary\">\r\n       <a href=\"https://localhost:44385/\">Voltar</a>\r\n    </button>\r\n</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CadastroPessoas.Models.Telefone>> Html { get; private set; }
    }
}
#pragma warning restore 1591
