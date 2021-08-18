using System;

namespace PrimeiroApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Meu primeiro App em C#");
            Console.WriteLine("Digite o seu nome:");
            string name = Console.ReadLine();
            Console.WriteLine("Digite a sua idade:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Nome: {name} e idade: {age}");
        }
    }
}
