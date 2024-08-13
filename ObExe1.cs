using System;
using System.Globalization;

namespace ObExe1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            p1.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segunda funcionário: ");
            Console.Write("Nome: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            p2.Salario = double.Parse(Console.ReadLine());

            double Smedio = (p1.Salario + p2.Salario) / 2.0;

            Console.Write("Salário médio: R$" + Smedio.ToString("F2", CI));

        }
    }
}
