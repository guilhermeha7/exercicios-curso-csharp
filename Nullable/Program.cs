using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double? dataDeNascimento = null;

            /*GetValueOrDefault fala o seguinte: pega o valor do campo dataDeNascimento, 
            mas se o valor não existir, pega o valor padrão do tipo da variável x*/
            Console.WriteLine(dataDeNascimento.GetValueOrDefault());
            
            /*HasValue verifica se o campo está sem valor/null ou se tem algum valor e retorna true ou false*/
            Console.WriteLine(dataDeNascimento.HasValue);

            /*Operador de coalescência nula: ??*/
            double? x = null;
            double y = x ?? 0.0; //Cria a variável y com o valor de x, mas caso o valor de x for nulo, então y receberá o valor 0.0
            Console.WriteLine(y);
        }
    }
}