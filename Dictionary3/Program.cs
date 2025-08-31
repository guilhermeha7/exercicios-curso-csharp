using System;
using System.Collections.Generic;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file = Path.Combine(AppContext.BaseDirectory, "count.csv");

            try
            {
                using (StreamReader reader = new StreamReader(file))
                {
                    Dictionary<string, int> dictionary = new Dictionary<string, int>();

                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] pieces = line.Split(",");
                        string candidate = pieces[0];
                        int votes = int.Parse(pieces[1]);

                        if (dictionary.ContainsKey(candidate)) //Se o candidato já estiver no dicionário
                        {
                            //Apenas acrescente os votos da nova urna nele
                            dictionary[candidate] += votes;
                        }
                        else
                        {
                            dictionary.Add(candidate, votes);
                        }
                    }

                    foreach (KeyValuePair<string, int> item in dictionary)
                    {
                        Console.WriteLine(item.Key + ": " + item.Value);
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