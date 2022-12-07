// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

int[] SumInRows(int[,] matrix)
{
    int[] sumInRows = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        sumInRows[i] = sum;
    }
    return sumInRows;
}

int MinInArrayIndex(int[] arr)
{
    int min = arr[0];
    int minIndex = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
            minIndex = i;
        }
    }
    return minIndex;
}

int[,] array2D = CreateMatrixRndInt(5, 6, 1, 20);
Console.WriteLine("Исходный массив:");
PrintMatrix(array2D);
int[] rowSum = SumInRows(array2D);
Console.WriteLine("Суммы по строкам:");
PrintArray(rowSum);
int rowWithMinSum = MinInArrayIndex(rowSum);
Console.WriteLine($"{rowWithMinSum + 1} строка является строкой с наименьшей суммой элементов");
