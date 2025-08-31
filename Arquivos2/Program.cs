using Arquivos2;
using System;
using System.Globalization;

//Programa que extrai dados de um arquivo .csv para produzir um segundo arquivo .csv

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Obtendo caminho do arquivo .csv*/
            string diretorioDoProjeto = AppContext.BaseDirectory; //AppContext.BaseDirectory retorna o caminho do executável do programa
            string diretorioDoArquivo = Path.Combine(diretorioDoProjeto, "itensVendidos.csv"); //Path.Combine concatena com segurança um caminho e um arquivo ou dois caminhos

            /*Armazenando os produtos e seus dados*/
            try
            {
                string[] linhas = File.ReadAllLines(diretorioDoArquivo);

                List<Produto> produtos = new List<Produto>();

                bool primeiraLinha = true;
                foreach (string linha in linhas)
                {
                    if (primeiraLinha == true)
                    {
                        primeiraLinha = false;
                        continue; //termina a iteração aqui
                    }
                    string[] partes = linha.Split(',');
                    string nome = partes[0];
                    double preco = double.Parse(partes[1], CultureInfo.InvariantCulture);
                    int quantidade = int.Parse(partes[2]);
                    Produto p = new Produto(nome, preco, quantidade);
                    produtos.Add(p);
                }

                //Criação do arquivo de saída
                List<string> linhasSaida = new List<string>();
                linhasSaida.Add("Produto, ValorTotal"); //cabeçalho

                foreach (Produto p in produtos)
                {
                    string linha = $"{p.Nome},{p.ValorTotal()}";
                    linhasSaida.Add(linha);
                }

                Directory.CreateDirectory(diretorioDoProjeto + @"\out");
                File.WriteAllLines(diretorioDoProjeto + @"\out\valoresTotais.csv", linhasSaida);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
           

        }
    }
}
