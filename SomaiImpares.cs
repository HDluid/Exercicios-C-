namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, sn, tc;

            Console.WriteLine("  Digite dois números:");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            sn = 0;
        
                if (n1 > n2)
                {
                    tc = n1;
                    n1 = n2;
                    n2 = tc;
                }
                sn = 0;
                for (int i = n1 + 1; i < n2; i++)
                { 
                    if (i % 2 != 0)
                    {
                        sn = sn + i;
                    }
                }
            Console.Write("  Soma dos impares: "+ sn);
        }   
    }
}
