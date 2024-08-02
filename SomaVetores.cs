using System;
using System.Globalization;

namespace SomaVetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sm, md;
            int n,i;
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("  Quantos numeros voce vai digitar? ");
            n = int.Parse(Console.ReadLine());

            double[] vet = new double[n];

            for (i = 0; i < n; i++)
            {
                Console.Write("  Digite um número: ");
                vet[i] = double.Parse(Console.ReadLine(), CI);
            }
            Console.WriteLine();
            sm = 0;
            Console.Write("  Valores: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(vet[i].ToString("F1", CI) + " ");
                sm = sm + vet[i];
            }
            Console.WriteLine();
            md = sm / n;
            Console.WriteLine("  Soma: "+ sm.ToString("F2", CI));
            Console.WriteLine("  Média: "+ md.ToString("F2", CI));
            Console.WriteLine();
        }
    }
}
