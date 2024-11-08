#pragma checksum "E:\Cezar\Workspaces\CRUD_Ajax\Views\Pessoas\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "e83c5712f6b234c98001e2e7936d0bedbb168e1a6cd23a7dba6a9e2635c56ae6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pessoas_Index), @"mvc.1.0.view", @"/Views/Pessoas/Index.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\Cezar\Workspaces\CRUD_Ajax\Views\_ViewImports.cshtml"
using CRUD_Ajax

#nullable disable
    ;
#nullable restore
#line 2 "E:\Cezar\Workspaces\CRUD_Ajax\Views\_ViewImports.cshtml"
using CRUD_Ajax.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"e83c5712f6b234c98001e2e7936d0bedbb168e1a6cd23a7dba6a9e2635c56ae6", @"/Views/Pessoas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"503a2656cab53bb7399840ee3a85e1d1c64e8faaa3649a0868dda55043fcd597", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Pessoas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\Cezar\Workspaces\CRUD_Ajax\Views\Pessoas\Index.cshtml"
  
    ViewData["Title"] = "Pessoas Cadastradas";

#line default
#line hidden
#nullable disable

            WriteLiteral(@"
<div class=""p-5"">
    <div class=""border border-light border-3 rounded"">
        <div class=""container"">
            <div class=""p-5"">
                <div class=""row"">
                    <div class=""col-8"">
                        <h6>Pessoas cadastradas</h6>
                    </div>
                    <div class=""col-4"">
                        <button class=""btn btn-sm btn-outline-success novaPessoa"">Nova pessoa</button>
                    </div>
                </div>

                <hr />

                <div class=""p-5 rounded shadow-sm"" id=""divTabela""></div>
            </div>
        </div>
    </div>
</div>

<div id=""modal"" class=""modal fade"" role=""dialog"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h6 class=""modal-title""></h6>
            </div>
            
            <div class=""modal-body"">
                <input type=""hidden"" class=""form-control form-control-sm pessoaId"" />
  ");
            WriteLiteral(@"              <div class=""form-group"">
                    <label>Nome</label>
                    <input type=""text"" class=""form-control form-control-sm nome"" />
                    <span class=""text-danger erroNome d-none""></span>
                </div>

                <div class=""form-group"">
                    <label>Idade</label>
                    <input type=""number"" class=""form-control form-control-sm idade"" />
                    <span class=""text-danger erroIdade d-none"">Digite um número</span>
                </div>

                <div class=""form-group"">
                    <label>Profissão</label>
                    <input type=""text"" class=""form-control form-control-sm profissao"" />
                    <span class=""text-danger erroProfissao d-none"">Digite uma profissão</span>
                </div>
            </div>

            <div class=""modal-footer"">
                <div class=""form-group"">
                    <input type=""button"" value=""Salvar"" class=""btn btn-sm");
            WriteLiteral(" btn-outline-success btnSalvar\" />\r\n                    <input type=\"button\" value=\"Cancelar\" class=\"btn btn-sm btn-light\" data-bs-dismiss=\"modal\" />\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
