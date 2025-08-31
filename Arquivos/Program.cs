using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string caminhoDoArquivoDeOrigem = @"c:\teste\arquivoTeste.txt"; //Usar @ faz com não seja necessário usar // 
            string caminhoDoArquivoDeDestino = @"c:\teste\arquivoTeste2.txt";
            string[] linhas = File.ReadAllLines(caminhoDoArquivoDeOrigem); //O vetor linhas recebe o conteúdo do arquivo especificado 
            foreach (string linha in linhas)
            {
                Console.WriteLine(linha);
            }

            try
            {
                FileInfo arquivo = new FileInfo(caminhoDoArquivoDeOrigem); //Cria um objeto associado ao arquivo no diretório
                arquivo.CopyTo(caminhoDoArquivoDeDestino); //CopyTo é uma operação que copia um arquivo para o diretório colocado como parâmetro
            }
            catch (IOException e) //se ocorrer algum erro/exceção relacionada a arquivos
            {
                Console.WriteLine("Ocorreu um erro");
                Console.WriteLine(e.Message);
            }
        
        }
    }
}
