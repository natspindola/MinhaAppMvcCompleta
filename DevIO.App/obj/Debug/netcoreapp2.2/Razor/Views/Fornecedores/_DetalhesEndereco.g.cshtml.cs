#pragma checksum "C:\dev\Desenvolvedor.IO\MinhaAppMvcCompleta\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b320243fbb756ec0273e2f00318e2284b22cc051"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Fornecedores__DetalhesEndereco), @"mvc.1.0.view", @"/Views/Fornecedores/_DetalhesEndereco.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Fornecedores/_DetalhesEndereco.cshtml", typeof(AspNetCore.Views_Fornecedores__DetalhesEndereco))]
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
#line 1 "C:\dev\Desenvolvedor.IO\MinhaAppMvcCompleta\DevIO.App\Views\_ViewImports.cshtml"
using DevIO.App;

#line default
#line hidden
#line 2 "C:\dev\Desenvolvedor.IO\MinhaAppMvcCompleta\DevIO.App\Views\_ViewImports.cshtml"
using DevIO.App.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b320243fbb756ec0273e2f00318e2284b22cc051", @"/Views/Fornecedores/_DetalhesEndereco.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b1c4f7112a188c6823fcdfc8cbeb3cfe4ebb5b7", @"/Views/_ViewImports.cshtml")]
    public class Views_Fornecedores__DetalhesEndereco : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DevIO.App.ViewModels.FornecedorViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AtualizarEndereco", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(49, 103, true);
            WriteLiteral("\r\n<div style=\"padding-top: 20px\">\r\n    <div>\r\n        <hr />\r\n        <h4>Endereço</h4>\r\n    </div>\r\n\r\n");
            EndContext();
#line 9 "C:\dev\Desenvolvedor.IO\MinhaAppMvcCompleta\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
     if (Model != null)
    {

#line default
#line hidden
            BeginContext(184, 155, true);
            WriteLiteral("        <table class=\"table table-hover\">\r\n            <thead class=\"thead-dark\">\r\n                <tr>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(340, 67, false);
#line 15 "C:\dev\Desenvolvedor.IO\MinhaAppMvcCompleta\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
                   Write(Html.DisplayNameFor(expression: model => model.Endereco.Logradouro));

#line default
#line hidden
            EndContext();
            BeginContext(407, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(487, 63, false);
#line 18 "C:\dev\Desenvolvedor.IO\MinhaAppMvcCompleta\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
                   Write(Html.DisplayNameFor(expression: model => model.Endereco.Numero));

#line default
#line hidden
            EndContext();
            BeginContext(550, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(630, 68, false);
#line 21 "C:\dev\Desenvolvedor.IO\MinhaAppMvcCompleta\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
                   Write(Html.DisplayNameFor(expression: model => model.Endereco.Complemento));

#line default
#line hidden
            EndContext();
            BeginContext(698, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(778, 63, false);
#line 24 "C:\dev\Desenvolvedor.IO\MinhaAppMvcCompleta\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
                   Write(Html.DisplayNameFor(expression: model => model.Endereco.Bairro));

#line default
#line hidden
            EndContext();
            BeginContext(841, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(921, 60, false);
#line 27 "C:\dev\Desenvolvedor.IO\MinhaAppMvcCompleta\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
                   Write(Html.DisplayNameFor(expression: model => model.Endereco.Cep));

#line default
#line hidden
            EndContext();
            BeginContext(981, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1061, 63, false);
#line 30 "C:\dev\Desenvolvedor.IO\MinhaAppMvcCompleta\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
                   Write(Html.DisplayNameFor(expression: model => model.Endereco.Cidade));

#line default
#line hidden
            EndContext();
            BeginContext(1124, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1204, 63, false);
#line 33 "C:\dev\Desenvolvedor.IO\MinhaAppMvcCompleta\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
                   Write(Html.DisplayNameFor(expression: model => model.Endereco.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(1267, 167, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n\r\n            <tr>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1435, 63, false);
#line 41 "C:\dev\Desenvolvedor.IO\MinhaAppMvcCompleta\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
               Write(Html.DisplayFor(expression: model => model.Endereco.Logradouro));

#line default
#line hidden
            EndContext();
            BeginContext(1498, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1566, 59, false);
#line 44 "C:\dev\Desenvolvedor.IO\MinhaAppMvcCompleta\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
               Write(Html.DisplayFor(expression: model => model.Endereco.Numero));

#line default
#line hidden
            EndContext();
            BeginContext(1625, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1693, 64, false);
#line 47 "C:\dev\Desenvolvedor.IO\MinhaAppMvcCompleta\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
               Write(Html.DisplayFor(expression: model => model.Endereco.Complemento));

#line default
#line hidden
            EndContext();
            BeginContext(1757, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1825, 59, false);
#line 50 "C:\dev\Desenvolvedor.IO\MinhaAppMvcCompleta\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
               Write(Html.DisplayFor(expression: model => model.Endereco.Bairro));

#line default
#line hidden
            EndContext();
            BeginContext(1884, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1952, 56, false);
#line 53 "C:\dev\Desenvolvedor.IO\MinhaAppMvcCompleta\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
               Write(Html.DisplayFor(expression: model => model.Endereco.Cep));

#line default
#line hidden
            EndContext();
            BeginContext(2008, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(2076, 59, false);
#line 56 "C:\dev\Desenvolvedor.IO\MinhaAppMvcCompleta\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
               Write(Html.DisplayFor(expression: model => model.Endereco.Cidade));

#line default
#line hidden
            EndContext();
            BeginContext(2135, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(2203, 59, false);
#line 59 "C:\dev\Desenvolvedor.IO\MinhaAppMvcCompleta\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
               Write(Html.DisplayFor(expression: model => model.Endereco.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(2262, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(2329, 151, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b320243fbb756ec0273e2f00318e2284b22cc05111382", async() => {
                BeginContext(2423, 53, true);
                WriteLiteral("<span title=\"Editar\" class=\"fa fa-pencil-alt\"></span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 62 "C:\dev\Desenvolvedor.IO\MinhaAppMvcCompleta\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
                                                        WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("data-modal", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2480, 62, true);
            WriteLiteral("\r\n                </th>\r\n            </tr>\r\n        </table>\r\n");
            EndContext();
#line 66 "C:\dev\Desenvolvedor.IO\MinhaAppMvcCompleta\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
    }

#line default
#line hidden
            BeginContext(2549, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DevIO.App.ViewModels.FornecedorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
