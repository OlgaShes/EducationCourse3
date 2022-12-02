// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1;7 -> такого числа в массиве нет

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

Console.Write("Введите количество строк: ");
int rowsNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columnsNumber = Convert.ToInt32(Console.ReadLine());
int[,] array2D = CreateMatrixRndInt(rowsNumber, columnsNumber, -10, 10);
PrintMatrix(array2D);

Console.WriteLine("Введите позцию искомого элемента: ");
Console.Write("Введите индекс строки: ");
int rowPosition = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбца: ");
int columnPosition = Convert.ToInt32(Console.ReadLine());
if (rowPosition > array2D.GetLength(0) || columnPosition > array2D.GetLength(0))
    Console.WriteLine("Числа с данными индексами в массиве нет");
else if (rowPosition < 0 || columnPosition < 0) Console.WriteLine("Неверно заданны координаты");
else Console.WriteLine($"Число на позиции [{rowPosition}, {columnPosition}] равно {array2D[rowPosition, columnPosition]}");


