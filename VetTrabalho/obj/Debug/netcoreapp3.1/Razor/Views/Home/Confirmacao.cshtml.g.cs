#pragma checksum "D:\Senac\Meus projetos VS\VetTrabalho\Views\Home\Confirmacao.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08600d0dcc1bce9b8af9363cc5b1d79e99236089"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Confirmacao), @"mvc.1.0.view", @"/Views/Home/Confirmacao.cshtml")]
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
#line 1 "D:\Senac\Meus projetos VS\VetTrabalho\Views\_ViewImports.cshtml"
using VetTrabalho;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Senac\Meus projetos VS\VetTrabalho\Views\_ViewImports.cshtml"
using VetTrabalho.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08600d0dcc1bce9b8af9363cc5b1d79e99236089", @"/Views/Home/Confirmacao.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bec7f95c8dfd0e5f11cc032f14e4af09eae4cc5a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Confirmacao : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Cliente>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
    <h2>Agendamento Concluído:</h2>

    <table class= ""table table-bordered table-stripeed"">
        <thead>
            <tr>
                <th>Nome</th>
                <th>Telefone</th>
                <th>Data</th>
                <th>Animal</th>
                <th>Necessidade</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 16 "D:\Senac\Meus projetos VS\VetTrabalho\Views\Home\Confirmacao.cshtml"
             foreach(Cliente i in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 19 "D:\Senac\Meus projetos VS\VetTrabalho\Views\Home\Confirmacao.cshtml"
                   Write(i.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 20 "D:\Senac\Meus projetos VS\VetTrabalho\Views\Home\Confirmacao.cshtml"
                   Write(i.Telefone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 21 "D:\Senac\Meus projetos VS\VetTrabalho\Views\Home\Confirmacao.cshtml"
                   Write(i.Data);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 22 "D:\Senac\Meus projetos VS\VetTrabalho\Views\Home\Confirmacao.cshtml"
                   Write(i.Animal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 23 "D:\Senac\Meus projetos VS\VetTrabalho\Views\Home\Confirmacao.cshtml"
                   Write(i.Necessidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 25 "D:\Senac\Meus projetos VS\VetTrabalho\Views\Home\Confirmacao.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Cliente>> Html { get; private set; }
    }
}
#pragma warning restore 1591
