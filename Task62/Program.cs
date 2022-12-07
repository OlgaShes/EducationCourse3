// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();

void RotateSquareMatrix(int[,] matrix)
{
    int size = matrix.GetLength(0);
    int column = matrix.GetLength(1);
    for (int i = 0; i < size - 2; i++)
    {
        for (int j = i; j < size - 1 - i; j++)
        {
            int temp = matrix[size - j - 1, i];
            matrix[size - j - 1, i] = matrix[i, j];
            matrix[i, j] = matrix[j, size - i - 1];
            matrix[j, size - i - 1] = matrix[size - i - 1, size - j - 1];
            matrix[size - i - 1, size - j - 1] = temp;
        }
    }
}


int[,] CreateMatrixSpiral(int size)
{
    int[,] matrix = new int[size, size];
    int index = 1;
    for (int i = 0; i < size; i++)
    {
        for (int k = 0; k < 4; k++)
        {
            for (int j = i; j < size - 1 - i; j++)
            {
                matrix[i, j] = index;
                index++;
            }
            RotateSquareMatrix(matrix);
        }
    }
    if (size % 2 != 0) {matrix[size / 2, size / 2] = index;}
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

int[,] array2D = CreateMatrixSpiral(6);
PrintMatrix(array2D);
Console.WriteLine();
