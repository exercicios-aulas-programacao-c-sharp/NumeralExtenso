using System;
using Humanizer;
using Figgle;

namespace NumeralExtenso
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string numeroTextao;

            Console.Write("Digite um número ..: ");
            
            numero = Convert.ToInt32(Console.ReadLine());
            numeroTextao = FiggleFonts.ThreeDDiagonal.Render(numero.ToWords());
            
            Console.WriteLine($"\n{numeroTextao}");

        }
    }
}
