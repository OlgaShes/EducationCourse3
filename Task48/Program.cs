// Задать массив m*n, каждый элемент находится по формуле Amn = m + n
// m = 3, n = 4
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

Console.Clear();

int[,] CreateMatrixInt(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
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
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int numN = Convert.ToInt32(Console.ReadLine());
int[,] array2D = CreateMatrixInt(numM, numN);
PrintMatrix(array2D);

