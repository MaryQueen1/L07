// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();
Console.WriteLine("Задача 50.");

Console.Write("Введите кол-во строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите кол-во столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите искомую позицию (строка): ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите искомую позицию (столбец): ");
int y = Convert.ToInt32(Console.ReadLine());


double[,] Array = new double[m, n];

RandomArray(Array);
Print(Array);
Find(Array);

void RandomArray(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(0, 10));
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

void Find(double[,] array)
{
    if (x > array.GetLength(0) || y > array.GetLength(1))
    {
        Console.WriteLine("Такого элемента нет");
    }
    else
    {
        Console.WriteLine($"Значение элемента в {x} строке и в {y} столбце равно {array[x - 1, y - 1]}");
    }
}

// не забыть в задачах в вызове метода вписать m & n

// ? если if - это условие, а else - это цикл, т.е. for, то как  сделать так, что если if не выполныется, чтобы пошел else, т.е. цикл for?

