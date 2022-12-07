// Задача 60
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

Console.Clear();

int[,,] CreateArray3DRndInt(int rows, int columns, int depth, int min, int max)
{
    int[,,] arr3D = new int[rows, columns, depth];
    int index = 10;
    for (int i = 0; i < arr3D.GetLength(0); i++)
    {
        for (int j = 0; j < arr3D.GetLength(1); j++)
        {
            for (int k = 0; k < arr3D.GetLength(2); k++)
            {
                arr3D[i, j, k] = index;
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

int[,,] array3D = CreateArray3DRndInt(2, 2, 2, 1, 10);
PrintArray3D(array3D);
