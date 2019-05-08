using Alura.ListaLeitura.App.Repositorio;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using Alura.ListaLeitura.App.Negocio;
using Alura.ListaLeitura.App.HTML;
using Microsoft.AspNetCore.Mvc;

namespace Alura.ListaLeitura.App.Logica

{
    public class CadastroController 
    {

        public string Incluir(Livro livro)
        {
            var _repo = new LivroRepositorioCSV();
            _repo.Incluir(livro);
            return "Livro adicionado com sucesso";
        }

        public IActionResult ExibirFormulario()
        {
            //var html = HTML.CarregarArquivos("repositorio");
            var html = new ViewResult { ViewName = "repositorio" };
            return html;
        }

   

    }
}
