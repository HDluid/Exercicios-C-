namespace Crescente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            Console.WriteLine("  Digite dois números: ");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());

            while (n1 != n2)
            {
                if (n1 < n2)
                {
                    Console.WriteLine("  Crescente!");
                }
                else
                {
                    Console.WriteLine("  Decrescente!");
                }
                Console.WriteLine("  Digite outros dois números: ");
                n1 = int.Parse(Console.ReadLine());
                n2 = int.Parse(Console.ReadLine());
            }
        }
    }
}
