using System;
using System.Globalization;

namespace idades_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            String nome1, nome2;
            int idade1, idade2;
            double idadem;

            Console.WriteLine("  Dados da primeira pessoa: ");
            Console.Write("  Nome: ");
            nome1 = Console.ReadLine();
            Console.Write("  Idade: ");
            idade1 = int.Parse(Console.ReadLine());

            Console.WriteLine("  Dados da segunda pessoa: ");
            Console.Write("  Nome: ");
            nome2 = Console.ReadLine();
            Console.Write("  Idade: ");
            idade2 = int.Parse(Console.ReadLine());
            idadem = (idade1 + idade2) / 2.0;
            Console.WriteLine();
            Console.WriteLine("  A idade média de "+nome1+" e "+nome2+" é de "
                + idadem.ToString("F1", CI)+" anos.");

        }
    }
}
