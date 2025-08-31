using System;

namespace MyApp
{
    //Sistema de envio de mensagens
    public delegate void MessageDelegate(string name);
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowMessage("Guilherme", WelcomeMessage);
            ShowMessage("Guilherme", GoodByeMessage);
        }

        static void WelcomeMessage(string name)
        {
            Console.WriteLine($"Welcome {name}!");
        }

        static void GoodByeMessage(string name)
        {
            Console.WriteLine($"Goodbye {name}!");
        }

        static void ShowMessage(string name, MessageDelegate method)
        {
            method(name);
        }

    }


}
