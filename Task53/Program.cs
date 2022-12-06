// Задать двумерный массив, поменять местами первую и последнюю строку

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

void ChangeRows(int[,] matrix, int rowFirst, int rowLast)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int temp = matrix[rowFirst, j];
        matrix[rowFirst, j] = matrix[rowLast, j];
        matrix[rowLast, j] = temp;
    }
}

// void ChangeFirstLastRows(int[,] matrix)
// {
//     int lastRow = matrix.GetLength(0) - 1;
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         int temp = matrix[0, j];
//         matrix[0, j] = matrix[lastRow, j];
//         matrix[lastRow, j] = temp;
//     }
// }

int[,] array2D = CreateMatrixRndInt(4, 5, 1, 10);
PrintMatrix(array2D);
Console.WriteLine();

int firstRow = 0;
int lastRow = array2D.GetLength(0) - 1;
ChangeRows(array2D, firstRow, lastRow);
PrintMatrix(array2D);

// Console.WriteLine();
// ChangeFirstLastRows(array2D);
// PrintMatrix(array2D);
