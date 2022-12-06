// Составить частотный словарь элементов двумерного массива (сколько раз встречается элемент)
// 1 2 3
// 4 6 1
// 2 1 6
// 1 - 3 раза
// 2 - 2 раза
// 3 - 1 раз
// 4 - 1 раз
// 6 - 2 раза

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
        if (i< arr.Length -1) Console.Write($"{arr[i]}, ");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

int[] MatrixToLine(int[,] matrix)
{
    int[] array = new int[matrix.Length];
    int index = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[index++] = matrix[i, j];
        }
    }
    return array;
}

void CountElements(int[] arr)
{
    Array.Sort(arr);
    int elem = arr[0];
    int count = 1;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] == elem) count++;       
        else
        {
            Console.WriteLine($" Число {elem} встречается {count} раз");
            elem = arr[i];
            count = 1;
        }
    }
    Console.WriteLine($" Число {elem} встречается {count} раз");
}

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2D);
Console.WriteLine();

int[] arrayLine = MatrixToLine(array2D);

PrintArray(arrayLine);
Array.Sort(arrayLine);
PrintArray(arrayLine);

CountElements(arrayLine);
