using System;

namespace Milhas_para_Km
{
    class Program
    {
        static void Main(string[] args)
        {
            double milhas;
            double km = 1.609;

            Console.WriteLine("Digite seu valor em milhas: ");
            milhas = double.Parse(Console.ReadLine()); 

            Console.WriteLine("Seu valor de milhas para Km");
            Console.WriteLine($"{milhas * km}");
            Console.Write("\n");

            Console.WriteLine("Pressione Enter para sair!");
            Console.ReadKey();
        }
    }
}
