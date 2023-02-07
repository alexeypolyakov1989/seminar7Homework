// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Random random = new Random();
int m = random.Next(2,16);
int n = random.Next(2,16);

ColumnArithAverage(m, n, CreateFillArray(m, n)); 

static int[,] CreateFillArray(int m, int n)
{
    int[,] arr = new int[m, n];
    Random random = new Random();
    Console.WriteLine();
    Console.WriteLine("Двумерный массив из целых чисел: "); Console.WriteLine();;

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = random.Next(-99, 100);
            Console.Write("{0, 5}", arr[i, j]);
        }
        Console.WriteLine();Console.WriteLine();
    }
    return arr;
}

void ColumnArithAverage(int m, int n, int[,] array)
{
Console.WriteLine("Среднее арифметическое элементов в каждом столбце: "); 

for (int i = 0; i < n; i++)
    {
        double arc = 0;
        for (int j = 0; j < m; j++)
        {
            arc += array[j, i];
        }
        arc = arc/m;
        Console.Write((arc).ToString("0.0") + " ; ");
    }
}