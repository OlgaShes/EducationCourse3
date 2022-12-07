// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] multiply = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < multiply.GetLength(0); i++)
    {
        for (int j = 0; j < multiply.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLongLength(1); k++)
            {
                multiply[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return multiply;
}

int[,] firstArray2D = CreateMatrixRndInt(3, 2, 1, 10);
Console.WriteLine("Первая матрица:");
PrintMatrix(firstArray2D);
int[,] secondArray2D = CreateMatrixRndInt(2, 3, 1, 10);
Console.WriteLine("Вторая матрица:");
PrintMatrix(secondArray2D);

if (firstArray2D.GetLength(1) != secondArray2D.GetLength(0))
{
    Console.WriteLine("Матрицы не совместимы, умножение невозможно");
}
else
{
    int[,] multiplyArray2D = MultiplyMatrix(firstArray2D, secondArray2D);
    Console.WriteLine("Произведение матриц:");
    PrintMatrix(multiplyArray2D);
}
