using Biblioteca.Model;
using System;
using System.IO;

namespace Biblioteca.Arquivo
{
    public class GerenciadorArquivo
    {

        public static void GravarArquivo(string nome, string texto)
        {
            string caminho = "C:\\" + nome + ".txt";

            if (File.Exists(caminho))
            {
                using (StreamWriter wr = File.AppendText(caminho))
                {
                    wr.WriteLine(texto);
                }
            }
            else
            {
                using (StreamWriter wr = new StreamWriter(caminho))
                {
                    wr.WriteLine(texto);
                }
            }
        }

        public static string[] LerArquivo(string nome)
        {
            return File.ReadAllLines("C:\\" + nome + ".txt");
        }

    }
}
