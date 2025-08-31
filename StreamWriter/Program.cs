using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string caminhoDeOrigem = @"c:\teste\arquivoTeste1.txt";
            string caminhoDeDestino = @"c:\teste\arquivoTeste2.txt";

            try
            {
                string[] linhas = File.ReadAllLines(caminhoDeOrigem); //O vetor linhas guarda o conteúdo do arquivo de origem

                using (StreamWriter sw = File.AppendText(caminhoDeDestino)) //AppendText abre o arquivo para escrita, e tudo o que for definido no sw.WriteLine() é escrito nele
                {
                    foreach (string linha in linhas)
                    {
                        sw.WriteLine(linha.ToUpper());
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}