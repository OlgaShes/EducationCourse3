// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5      7     -2    -0,2
//   1   -3,3      8    -9,9
//   8    7,8   -7,1       9

Console.Clear();

double[,] CreateMatrixDoubleInt(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(rnd.NextDouble() * (max - min) + min, 1);
        }
    }
    return matrix;
}

void PrintMatrixDouble(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],7} ");
        }
        Console.WriteLine("|");
    }
}

Console.Write("Введите количество строк: ");
int rowsNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columnsNumber = Convert.ToInt32(Console.ReadLine());
double[,] array2D = CreateMatrixDoubleInt(rowsNumber, columnsNumber, -10, 10);
PrintMatrixDouble(array2D);
