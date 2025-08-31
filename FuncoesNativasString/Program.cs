using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textoOriginal = "abcde FGHIJ ABC abc DEFG   ";
            string s2 = textoOriginal.ToUpper(); //ToUpper torna toda string maiúscula
            string s3 = textoOriginal.ToLower(); //ToLower torna toda string minúscula
            
            string s4 = textoOriginal.Trim(); //Trim apaga os espaços em branco tanto na frente como atrás do string
            
            string s5 = textoOriginal.Substring(3); //A função Substring de 1 parâmetro corta o texto original a partir da posição de um caracter
            string s6 = textoOriginal.Substring(3, 5); //A função Substring de 2 parâmetros corta o texto original a partir da posição de um caracter e termina quando a contagem especificada no segundo parâmetro acaba
            
            string s7 = textoOriginal.Replace("a", "x"); //Replace troca uma string por outra
            
            int n1 = textoOriginal.IndexOf("bc"); //IndexOf retorna a posição de um caracter (ou vários) em uma string
            int n2 = textoOriginal.LastIndexOf("bc"); //LastIndexOf retorna a última posição de um caracter (ou vários)  
            
            bool b1 = String.IsNullOrEmpty(textoOriginal); //IsNullOrEmpty verifica se a string tem valor nulo ou vazio, bom para testar formulários
            bool b2 = String.IsNullOrWhiteSpace(textoOriginal); //IsNullOrWhiteSpace verifica se a string tem valor nulo ou possui somente espaços em branco, bom para testar formulários

            Console.WriteLine("Original: " + "-" + textoOriginal + "-");
            Console.WriteLine("ToUpper: " + "-" + s2 + "-"); 
            Console.WriteLine("ToLower: " + "-" + s3 + "-"); 
            Console.WriteLine("Trim: " + "-" + s4 + "-"); 
            Console.WriteLine("IndexOf: " + n1);
            Console.WriteLine("LastIndexOf: " + n2);
            Console.WriteLine("Substring(3): " + "-" + s5 + "-");
            Console.WriteLine("Substring(3, 5): " + "-" + s6 + "-");
            Console.WriteLine("Replace('a','x'): " + "-" + s7 + "-");
            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);
        }
    }
}
