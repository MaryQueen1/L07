// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
Console.WriteLine("Задача 50.");

Console.Write("Введите кол-во строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите кол-во столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] Array = new int[m, n];
System.Console.WriteLine($"Задан двумерный массив:");

CreateArray(Array);
WriteArray(Array);
FormArray(Array, n);


void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10);
        }
    }
}

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void FormArray(int[,] array, int n)
{
    for (int j = 0; j < array.GetLength(0); j++)
    {
        double result = 0;
        for (int i = 0; i < array.GetLength(1); i++)
        {
            result = result + array[i, j];
        }
        result = result / n;
        System.Console.WriteLine($"Cреднее арифметическое элементов в столбце {j + 1} = {result}");
    }
}