/*Relatório de Vendas com Filtro de Data*/

using Arquivos3.Entities;
using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Lê o arquivo vendas.csv
                string caminho = Path.Combine(AppContext.BaseDirectory, "vendas.csv"); //sourcePath recebe o caminho do arquivo vendas.csv
                string[] linhas = File.ReadAllLines(caminho);

                //Imprime na tela as vendas
                List<Venda> vendas = new List<Venda>();
                bool primeiraLinha = true;
                foreach (string linha in linhas)
                {
                    if (primeiraLinha == true)
                    {
                        primeiraLinha = false;
                        continue;
                    }
                    string[] partes = linha.Split(',');
                    DateTime data = DateTime.Parse(partes[0]);
                    string produto = partes[1];
                    double preco = double.Parse(partes[2], CultureInfo.InvariantCulture);
                    Venda v = new Venda(produto, data, preco);
                    vendas.Add(v);
                    Console.WriteLine(v);
                }

                //O usuário escolhe uma data para filtrar as vendas e produzir um relatório filtrado (.csv)
                Console.WriteLine("");
                Console.Write("Digite a data de filtro: ");
                DateTime dataDeFiltro = DateTime.Parse(Console.ReadLine());
                string caminhoSaida = AppContext.BaseDirectory + @"\out";
                Directory.CreateDirectory(caminhoSaida);
                List<string> linhasSaida = new List<string>();
                linhasSaida.Add("Data, Produto, Venda"); //cabeçalho
                foreach (Venda venda in vendas)
                {
                    if (venda.IsSameDate(dataDeFiltro) == true)
                    {
                        linhasSaida.Add($"{venda.Data},{venda.Produto},{venda.Preco}");
                    }
                }
                File.WriteAllLines(caminhoSaida + @"\output.csv", linhasSaida);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}