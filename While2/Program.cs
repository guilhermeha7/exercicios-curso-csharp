/*Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha 
incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser 
impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002.*/
Console.Write("Informe a senha: ");
string senhaDigitada = Console.ReadLine();
string senhaCorreta = "2002";

while (senhaDigitada != senhaCorreta)
{
    Console.WriteLine("Senha inválida");
    senhaDigitada = Console.ReadLine();
}

Console.WriteLine("Acesso Permitido");

