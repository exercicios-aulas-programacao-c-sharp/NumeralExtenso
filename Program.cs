using System;
using Humanizer;

namespace NumeralExtenso
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.Write("Digite um número ..: ");
            
            numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\n{numero.ToWords()}");

        }
    }
}
