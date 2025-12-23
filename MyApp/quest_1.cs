using System;

class Program
{
    static void Main(string[] args)
    {
        const int NMAX = 100;
        int[,] B = new int[NMAX, NMAX];
        Console.WriteLine("get N: ");
        int n = int.Parse(Console.ReadLine()!);
        int num = 1;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                B[i, j] = num;
                num++;
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(B[i, j] + " ");
            }
            Console.WriteLine();
        }

    }
}