// Задача 60
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

Console.Clear();

int[] CreateArrayNonRepeating(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
        while (Array.IndexOf(arr, arr[i]) != i)
        {
         arr[i] = rnd.Next(min, max + 1);   
        }
    }
    return arr;
}

int[,,] CreateArray3DRndInt(int rows, int columns, int depth, int min, int max)
{
    int[,,] arr3D = new int[rows, columns, depth];
    int[] arr = CreateArrayNonRepeating(arr3D.Length, min, max);
    int index = 0;
    for (int i = 0; i < arr3D.GetLength(0); i++)
    {
        for (int j = 0; j < arr3D.GetLength(1); j++)
        {
            for (int k = 0; k < arr3D.GetLength(2); k++)
            {
                arr3D[i, j, k] = arr[index];
                index++;
            }
        }
    }
    return arr3D;
}

void PrintArray3D(int[,,] arr3D)
{
    for (int i = 0; i < arr3D.GetLength(0); i++)
    {
        for (int j = 0; j < arr3D.GetLength(1); j++)
        {
            for (int k = 0; k < arr3D.GetLength(2); k++)
            {
                Console.Write($"{arr3D[i, j, k]} ({i}, {j}, {k})   ");
            }
        }
        Console.WriteLine();
    }
}

int[,,] array3D = CreateArray3DRndInt(3, 2, 2, 10, 99);
PrintArray3D(array3D);

