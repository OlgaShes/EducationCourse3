// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void PrintArrayDouble(double[] arr)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i],3} | ");
        else Console.Write($"{arr[i],3}");
    }
    Console.WriteLine(" ]");
}

double[] AverageInColumns(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    double[] averages = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < rows; i++)
        {
            averages[j] += matrix[i, j];
        }
        averages[j] = Math.Round(averages[j] / rows, 1);
    }
    return averages;
}

Console.Write("Введите количество строк: ");
int rowsNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columnsNumber = Convert.ToInt32(Console.ReadLine());
int[,] array2D = CreateMatrixRndInt(rowsNumber, columnsNumber, 1, 10);
PrintMatrix(array2D);
Console.WriteLine("Среднее арифметическое по столбцам:");
double[] averageInColumns = AverageInColumns(array2D);
PrintArrayDouble(averageInColumns);
