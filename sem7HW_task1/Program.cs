// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

using System;

class Program
{
    static void Main(string[] args)
    {
        CreateFillArray();
        Console.Write("");
       
        void CreateFillArray()
        {
            Console.WriteLine("Задайте размер двумерного массива m x n: ");
            Console.Write("- укажите количество строк" + "\t" + "m = ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("- укажите количество столбцов" + "\t" + "n = ");
            int n = Convert.ToInt32(Console.ReadLine()); 

            double[,] array = new double[m, n];
            Random random = new Random();
            Console.WriteLine(); 
            
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = Math.Round((random.NextDouble() * 200 - 100), 2);
                    Console.Write("{0, 10}", (array[i, j]).ToString("0.00"));
                }
            Console.WriteLine();   
            }
        }
    }
}