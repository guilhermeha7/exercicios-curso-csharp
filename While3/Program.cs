using System;

namespace MyApp
{
    public class GlobalVars
    {
        public static float x;
        public static float y;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa para ler as coordenadas (X, Y) de uma quantidade indeterminada de pontos no sistema 
            cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo 
            menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma). */
            LerCoordenadas();

            while (GlobalVars.x != 0 && GlobalVars.y != 0)
            {
                if (GlobalVars.x > 0 && GlobalVars.y > 0)
                {
                    Console.WriteLine("primeiro");
                    LerCoordenadas();
                }
                else if (GlobalVars.x < 0 && GlobalVars.y > 0)
                {
                    Console.WriteLine("segundo");
                    LerCoordenadas();
                }
                else if (GlobalVars.x < 0 && GlobalVars.y < 0)
                {
                    Console.WriteLine("terceiro");
                    LerCoordenadas();
                }
                else if (GlobalVars.x > 0 && GlobalVars.y < 0)
                {
                    Console.WriteLine("quarto");
                    LerCoordenadas();
                }
            }
        }

        static void LerCoordenadas()
        {
            Console.WriteLine("Escreva um valor para a coordenada X");
            GlobalVars.x = float.Parse(Console.ReadLine());

            Console.WriteLine("Escreva um valor para a coordenada Y");
            GlobalVars.y = float.Parse(Console.ReadLine());
        }
    }
}