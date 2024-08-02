namespace MenordeTrês
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, mv;

            Console.Write("  Primeiro valor: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("  Segundo valor: ");
            n2 = int.Parse(Console.ReadLine());
            Console.Write("  Terceiro valor: ");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            mv = n1;
            if (n2 < n1)
            {
                mv = n2;
            }
            else if (n3 < n1)
            {  
                mv = n3;
    
            }
            Console.WriteLine("  Menor é: "+ mv);
            Console.WriteLine();

        }
    }
}
