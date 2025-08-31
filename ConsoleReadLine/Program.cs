using System.Globalization;

//Nota: A função Console.ReadLine() armazena sempre o valor digitado pelo usuário como string, por isso é necessário fazer uma conversão
Console.WriteLine("Digite um número inteiro:");
int n1 = int.Parse(Console.ReadLine()); //O número inteiro que o usuário digitar é armazenado na variável n1
Console.WriteLine("Digite sua altura:");
float altura = float.Parse(Console.ReadLine());

Console.WriteLine("Você digitou:");
Console.WriteLine(n1);
Console.WriteLine(altura.ToString("F2",CultureInfo.InvariantCulture)); 
