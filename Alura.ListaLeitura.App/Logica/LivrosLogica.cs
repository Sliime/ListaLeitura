﻿using Alura.ListaLeitura.App.HTML;
using Alura.ListaLeitura.App.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Alura.ListaLeitura.App.Logica
{
    public class LivrosController : Controller
    {

        public IActionResult ParaLer()
        {

            var _repo = new LivroRepositorioCSV();

            ViewBag.Livros = _repo.ParaLer.Livros;
            return View("lista");
        }

        public IActionResult Lidos()
        {
            var _repo = new LivroRepositorioCSV();
            ViewBag.Livros = _repo.Lidos.Livros;

            return View("lista");
        }

        public IActionResult Lendo()
        {
            var _repo = new LivroRepositorioCSV();

            ViewBag.Livros = _repo.Lendo.Livros;

            return View("lista");
        }

        public string ExibirDetalhes(int id)
        {            
            var _repo = new LivroRepositorioCSV();

            var livro = _repo.Todos.First(l => l.Id == id);

            return livro.Detalhes();
        }

        public string teste()
        {
            return "aff";
        }


    }
}