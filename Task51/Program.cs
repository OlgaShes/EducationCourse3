// задать двумерный массив
// Найти сумму элементов по главной диагонали (0,0) (1,1) (2,2)

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

int SumDiadonalInMatrix(int[,] matrix)
{
    int sum = 0;
    int minIndex = matrix.GetLength(0) < matrix.GetLength(1) ? 
                    matrix.GetLength(0) : matrix.GetLength(1);
    for (int i = 0; i < minIndex; i++)
    {
        sum += matrix[i, i];
    }
    return sum;
}


int[,] array2D = CreateMatrixRndInt(4, 3, 1, 10);
PrintMatrix(array2D);
int sumInDiagonal = SumDiadonalInMatrix(array2D);
Console.WriteLine($"Сумма элементов по главной диагонали = {sumInDiagonal}");
