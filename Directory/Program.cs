using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\teste\myfolder";

            try
            {
                //Lista todas as subpastas a partir da pasta myfolder
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories); // *.* é uma máscara de busca que significa retornar qualquer nome de arquivo e qualquer extensão. SearchOption.AllDirectories lista inclusive as subpastas
                Console.WriteLine("FOLDERS: ");
                foreach (string folder in folders)
                {
                    Console.WriteLine(folder);
                }

                Console.WriteLine("");

                //Lista todos os arquivos a partir da pasta myfolder
                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories); // *.* é uma máscara de busca que significa retornar qualquer nome de arquivo e qualquer extensão. SearchOption.AllDirectories lista inclusive as subpastas
                Console.WriteLine("FILES: ");
                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }

                //Criar uma nova pasta
                Directory.CreateDirectory(path + @"\newfolder");
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}