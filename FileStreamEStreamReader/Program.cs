using System;
using System.IO;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string diretorio = @"c:\teste\arquivoTeste.txt";
            FileStream arquivo = null;
            StreamReader leitor = null;

            try
            {
                arquivo = new FileStream(diretorio, FileMode.Open);
                leitor = new StreamReader(arquivo);
                while (!leitor.EndOfStream) //Enquanto não chegar no fim do arquivo
                {
                    string linha = leitor.ReadLine();
                    Console.WriteLine(linha);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (leitor != null) leitor.Close();
                if (arquivo != null) arquivo.Close();
            }

        }
    }
}
