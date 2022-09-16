// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();
Console.WriteLine("Задача 47.");

Console.Write("Введите кол-во строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите кол-во столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] Array = new double[m, n];

RandomArray(Array);
Print(Array);

void RandomArray(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100));
        }
    }
}

void Print(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            double alignNumber = Math.Round(array[i, j], 1);
            Console.Write(alignNumber + " "); 
        }
        Console.WriteLine();
    }
}
