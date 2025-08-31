using Dictionary2.Entities;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = Path.Combine(AppContext.BaseDirectory, "count.csv"); //Path.Combine junta um diretório com um arquivo. AppContext.BaseDirectory pega o caminho do executável do projeto

            try
            {
                string[] lines = File.ReadAllLines(path); //Cada linha do arquivo vira um elemento do vetor
                HashSet<Candidate> candidates = new HashSet<Candidate>();

                foreach (string line in lines)
                {
                    string[] pieces = line.Split(',');
                    string name = pieces[0];
                    int votes = int.Parse(pieces[1]);
                    Candidate candidate = new Candidate(name, votes);

                    if (candidates.TryGetValue(candidate, out Candidate existingCandidate)) //Tente achar o candidato no conjunto, se já existir, armazene na variável existingCandidate
                    {
                        existingCandidate.AddVotes(votes); //E adicione os votos nele
                    }
                    else
                    {
                        candidates.Add(candidate); //Se não existir, adicione o candidato no conjunto
                    }
                }

                foreach (Candidate candidate in candidates)
                {
                    Console.WriteLine(candidate);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
