using System;
using System.Globalization;


namespace PrimeiroC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario1, salario2;
            string nome1, nome2;
            int idade;
            char sexo;
            double B, A, area, perim, diag;
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("  Base do retângulo: ");
            B = double.Parse(Console.ReadLine(), CI);
            Console.Write("  Altura do retângulo: ");
            A = double.Parse(Console.ReadLine(), CI);
            Console.WriteLine();

            area = (A * B);
            perim = 2 * (A + B);
            diag = Math.Sqrt(Math.Pow(A,2.0) + Math.Pow(B ,2.0));


            Console.WriteLine("Área = " + area.ToString("F4", CI));
            Console.WriteLine("Perimetro = " + perim.ToString("F4", CI));
            Console.WriteLine("Diagonal = " + diag.ToString("F4", CI));
            Console.WriteLine();
            Console.WriteLine();




        }
    }
}