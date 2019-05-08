using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Alura.ListaLeitura.App.HTML
{
    public class HTMLUtilidades
    {
        public string CarregarArquivos(string nomeArquivo)
        {
            var nomeCompletoArquivo = $"HTML/{nomeArquivo}.html";
            using (var arquivo = File.OpenText(nomeCompletoArquivo))
            {
                return arquivo.ReadToEnd();
            };
        }
    }
}
