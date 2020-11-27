﻿using Alura.ListaLeitura.App.HTML;
using Alura.ListaLeitura.App.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.ListaLeitura.App.Logica
{
    public class LivrosController
    {
        public IActionResult ParaLer()
        {
            var _repo = new LivroRepositorioCSV();
            var html = new ViewResult { ViewName = "lista" };
            return html;
        }


        //public static Task ParaLer(HttpContext context)
        //{
        //    var _repo = new LivroRepositorioCSV();
        //    var conteudoArquivo = HtmlUtils.CarregaArquivoHTML("para-ler");

        //    foreach (var livro in _repo.ParaLer.Livros)
        //    {
        //        conteudoArquivo = conteudoArquivo
        //            .Replace("#NOVO-ITEM#", $"<li>{livro.Titulo} - {livro.Autor}</li>#NOVO-ITEM#");
        //    }
        //    conteudoArquivo = conteudoArquivo.Replace("#NOVO-ITEM#", "");


        //    return context.Response.WriteAsync(conteudoArquivo);
        //}

        public static Task Lendo(HttpContext context)
        {
            var _repo = new LivroRepositorioCSV();
            return context.Response.WriteAsync(_repo.Lendo.ToString());
        }

        public static Task Lidos(HttpContext context)
        {
            var _repo = new LivroRepositorioCSV();
            return context.Response.WriteAsync(_repo.Lidos.ToString());
        }

        public string Detalhes(int id)
        {
            var repo = new LivroRepositorioCSV();
            var livro = repo.Todos.First(l => l.Id == id);
            return livro.Detalhes();
        }

        public string Teste()
        {
            return "Nova funcionalidade implementada!";
        }

    }
}
