using System.Text.Json.Serialization;

namespace DimagonalNegativos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nn, n, M, N;

            Console.Write("  Qual é a ordem da matriz? ");
            N = int.Parse(Console.ReadLine());
            M = N;
            int[,] mat = new int[M, N];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write("  Elemento [" + i + "," + j + "]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("  Diagonal Pricipal: ");
            nn = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        nn = nn + 1;
                    }
                }
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();
            Console.Write("  Quantidade de negativos: "+nn);
        }
    }
}
