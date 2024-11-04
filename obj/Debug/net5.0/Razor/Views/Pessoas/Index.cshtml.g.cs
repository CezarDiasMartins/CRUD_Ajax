#pragma checksum "E:\Cezar\Workspaces\CRUD_Ajax\Views\Pessoas\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "75ca17d01f856155f759de87932c45330d6dd6be121a6355887469604c963921"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"75ca17d01f856155f759de87932c45330d6dd6be121a6355887469604c963921", @"/Views/Pessoas/Index.cshtml")]
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
            WriteLiteral(" btn-outline-success btnSalvar\" />\r\n                    <input type=\"button\" value=\"Cancelar\" class=\"btn btn-sm btn-light\" data-bs-dismiss=\"modal\" />\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        // $(document).ready(function () {
        //     carregarDados();
        // });

        // function carregarDados() {
        //     $.ajax({
        //         url: ""Pessoas/PegarTodos"",
        //         method: ""GET"",
        //         success: function (pessoas) {
        //             montarTabela(pessoas);
        //         }
        //     });
        // }

        // function montarTabela(pessoas) {
        //     var indice = 0;
        //     var divTabela = document.getElementById(""divTabela"");
        //     var tabela = '<table class=""table table-sm table-hover table-striped tabela"">';
        //     tabela += '<thead>';
        //     tabela += '<tr>';
        //     tabela += '<th>Nome</th>';
        //     tabela += '<th>Idade</th>';
        //     tabela += '<th>Profissão</th>';
        //     tabela += '<th>Ações</th>';
        //     tabela += '</tr>';
        //     tabela += '</thead>';
        //     tabela += '<tbody>';

       ");
                WriteLiteral(@" //     for (indice = 0; indice < pessoas.length; indice++) {
        //         tabela += `<tr id=""${pessoas[indice].pessoaId}"">`;
        //         tabela += `<td>${pessoas[indice].nome}</td>`;
        //         tabela += `<td>${pessoas[indice].idade}</td>`;
        //         tabela += `<td>${pessoas[indice].profissao}</td>`;
        //         tabela += `<td><button class=""btn btn-sm btn-outline-info"" onclick=""pegarPessoaPeloId(${pessoas[indice].pessoaId})"">Atualizar</button> |
        //                                 <button class=""btn btn-sm btn-outline-danger"" onclick=""excluirPessoa(${pessoas[indice].pessoaId})"">Excluir</button></td>`;
        //         tabela += '</tr>';
        //     }

        //     tabela += '</tbody>';
        //     tabela += '</table>';

        //     divTabela.innerHTML = tabela;
        // }

        // $("".novaPessoa"").click(function () {
        //     escolherTituloModal(""Cadastro de nova pessoa"");
        //     mostrarModal();
        //     lim");
                WriteLiteral(@"parFormulario();
        //     $('.pessoaId').val(0);
        // });


        // $("".btnSalvar"").click(function () {
        //     var pessoa = {
        //         pessoaId: $('.pessoaId').val(),
        //         nome: $('.nome').val(),
        //         idade: $('.idade').val(),
        //         profissao: $('.profissao').val()
        //     };

        //     if (validarFormulario(pessoa)) {

        //         if (parseInt(pessoa.pessoaId) > 0)
        //             atualizarPessoa(pessoa);
        //         else
        //             criarPessoa(pessoa);
        //     }
        // });

        // function criarPessoa(pessoa) {
        //     $.ajax({
        //         url: ""Pessoas/NovaPessoa"",
        //         method: 'POST',
        //         data: {
        //             pessoa: pessoa
        //         },
        //         success: function (pessoaCriada) {
        //             $(""#modal"").modal('hide');

        //             location.reload();");
                WriteLiteral(@"

        //             var linhaNovaPessoa = `<tr id=""${pessoaCriada.pessoaId}"">`;
        //             linhaNovaPessoa += `<td>${pessoaCriada.nome}</td>`;
        //             linhaNovaPessoa += `<td>${pessoaCriada.idade}</td>`;
        //             linhaNovaPessoa += `<td>${pessoaCriada.profissao}</td>`;
        //             linhaNovaPessoa += `<td><button class=""btn btn-sm btn-outline-info""
        //                     onclick=""pegarPessoaPeloId(${pessoaCriada.pessoaId})"">Atualizar</button> |
        //                     <button class=""btn btn-sm btn-outline-danger""
        //                     onclick=""excluirPessoaPeloId(${pessoaCriada.pessoaId})"">Excluir</button></td>`;

        //             linhaNovaPessoa += '</tr>';

        //             $("".tabela tbody"").append(linhaNovaPessoa);
        //             limparFormulario();
        //         }
        //     });
        // }

        // function pegarPessoaPeloId(pessoaId) {
        //     $.ajax({
        //  ");
                WriteLiteral(@"       url: ""Pessoas/PegarPessoaPeloId"",
        //         method: 'GET',
        //         data: {
        //             pessoaId: pessoaId
        //         },
        //         success: function (pessoa) {
        //             mostrarModal();
        //             escolherTituloModal(`Atualizar pessoa ${pessoa.nome}`);
        //             $("".pessoaId"").val(pessoa.pessoaId);
        //             $("".nome"").val(pessoa.nome);
        //             $("".idade"").val(pessoa.idade);
        //             $("".profissao"").val(pessoa.profissao);
        //         }
        //     })
        // }

        // function atualizarPessoa(pessoa) {
        //     $.ajax({
        //         url: ""Pessoas/AtualizarPessoa"",
        //         method: 'POST',
        //         data: {
        //             pessoa: pessoa
        //         },
        //         success: function (pessoaAtualizada) {
        //             $(""#modal"").modal('hide');
        //             var linhaTab");
                WriteLiteral(@"ela = $(`#${pessoaAtualizada.pessoaId}`);
        //             linhaTabela[0].childNodes[0].innerText = pessoaAtualizada.nome;
        //             linhaTabela[0].childNodes[1].innerText = pessoaAtualizada.idade;
        //             linhaTabela[0].childNodes[2].innerText = pessoaAtualizada.profissao;

        //             limparFormulario();
        //         }
        //     });
        // }

        // function excluirPessoa(pessoaId) {
        //     $.ajax({
        //         url: ""Pessoas/ExcluirPessoa"",
        //         method: 'POST',
        //         data: {
        //             pessoaId: pessoaId
        //         },
        //         success: function (status) {
        //             if (status) {
        //                 alert(""Pessoa excluída com sucesso"");
        //                 document.getElementById(pessoaId).remove();
        //             }

        //             else
        //                 alert(status.mensagem);
        //         }");
                WriteLiteral(@"
        //     })
        // }

        // function validarFormulario(pessoa) {
        //     let nomeValido = validarNome(pessoa.nome);
        //     let idadeValida = validarIdade(pessoa.idade);
        //     let profissaoValida = validarProfissao(pessoa.profissao);

        //     if (nomeValido == true && idadeValida == true && profissaoValida == true)
        //         return true;

        //     return false;
        // }

        // function validarNome(nome) {
        //     let nomeValido = true;

        //     if (nome.trim() == '' || nome == undefined) {
        //         $("".nome"").addClass('is-invalid');
        //         $("".erroNome"").text(""Preencha o nome"");
        //         $("".erroNome"").removeClass(""d-none"");
        //         nomeValido = false;
        //     }
        //     else if (nome.length > 20) {
        //         $("".nome"").addClass('is-invalid');
        //         $("".erroNome"").text(""Use menos caracteres"");
        //         $("".erroNome");
                WriteLiteral(@""").removeClass(""d-none"");
        //         nomeValido = false;
        //     }
        //     else {
        //         $("".nome"").removeClass('is-invalid');
        //         $("".nome"").addClass('is-valid');
        //         $("".erroNome"").addClass(""d-none"");
        //         nomeValido = true;
        //     }

        //     return nomeValido;
        // }

        // function validarIdade(idade) {
        //     let idadeValida = true;

        //     if (isNaN(idade) || idade == undefined || idade == '') {
        //         $("".idade"").addClass('is-invalid');
        //         $("".erroIdade"").text(""Preencha a idade"");
        //         $("".erroIdade"").removeClass(""d-none"");
        //         idadeValida = false;
        //     }

        //     else if (parseInt(idade) < 18 || parseInt(idade) > 100) {
        //         $("".idade"").addClass('is-invalid');
        //         $("".erroIdade"").text(""Idade inválida"");
        //         $("".erroIdade"").removeClass(""d-none");
                WriteLiteral(@""");
        //         idadeValida = false;
        //     }

        //     else {
        //         $("".idade"").removeClass('is-invalid');
        //         $("".idade"").addClass('is-valid');
        //         $("".erroIdade"").addClass(""d-none"");
        //         idadeValida = true;
        //     }

        //     return idadeValida;
        // }

        // function validarProfissao(profissao) {
        //     let profissaoValida = true;

        //     if (profissao.trim() == '' || profissao == undefined) {
        //         $("".profissao"").addClass('is-invalid');
        //         $("".erroProfissao"").text(""Preencha a profissão"");
        //         $("".erroProfissao"").removeClass(""d-none"");
        //         profissaoValida = false;
        //     }

        //     else if (profissao.length > 50) {
        //         $("".profissao"").addClass('is-invalid');
        //         $("".erroProfissao"").text(""Use menos caracteres"");
        //         $("".erroProfissao"").removeCl");
                WriteLiteral(@"ass(""d-none"");
        //         profissaoValida = false;
        //     }

        //     else {
        //         $("".profissao"").removeClass('is-invalid');
        //         $("".profissao"").addClass('is-valid');
        //         $("".erroProfissao"").addClass(""d-none"");
        //         profissaoValida = true;
        //     }

        //     return profissaoValida;
        // }

        // function mostrarModal() {
        //     new bootstrap.Modal($(""#modal""), {}).show();
        // }

        // function limparFormulario() {
        //     $("".nome"").val('');
        //     $("".nome"").removeClass('is-valid');
        //     $("".idade"").val('');
        //     $("".idade"").removeClass('is-valid');
        //     $("".profissao"").val('');
        //     $("".profissao"").removeClass('is-valid');
        // }

        // function escolherTituloModal(texto) {
        //     $("".modal-title"").text(texto);
        // }
    </script>
");
            }
            );
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
