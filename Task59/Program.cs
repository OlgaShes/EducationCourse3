// Задать двумерный массив. Удалить строку и столбец, на пересечении которых расположен наименьший элемент

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

void MinInMatrix(int[,] matrix, out int minI, out int minJ)
{
    int min = matrix[0, 0];
    minI = 0;
    minJ = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                minI = i;
                minJ = j;
            }
        }
    }
}

int[,] DeleteRowColumnMatrix(int[,] matrix, int row, int column)
{
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int x = 0;
    int y = 0;
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        if (x == row) x++;
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            if (y == column) y++;
            newMatrix[i, j] = matrix[x, y];
            y++;
        }
        x++;
        y = 0;
    }
    return newMatrix;
}

int[,] array2D = CreateMatrixRndInt(5, 6, 1, 20);
PrintMatrix(array2D);
Console.WriteLine();
MinInMatrix(array2D, out int minIndRow, out int minIndColumn);
int[,] newArray2D = DeleteRowColumnMatrix(array2D, minIndRow, minIndColumn);
PrintMatrix(newArray2D);
Console.WriteLine();
