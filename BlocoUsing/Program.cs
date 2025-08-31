using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string diretorio = @"c:\teste\arquivoTeste.txt";

            //Os objetos não gerenciados pelo .NET ao final do bloco using são desalocados da memória
            try
            {
                using (FileStream arquivo = new FileStream(diretorio, FileMode.Open))
                {
                    using (StreamReader leitor = new StreamReader(arquivo))
                    {
                        while (!leitor.EndOfStream)
                        {
                            string linha = leitor.ReadLine();
                            Console.WriteLine(linha);
                        }
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            
            
        }
    }
}
