// Найти произведение пар чисел в массиве - первый и последний, второй и предпоследний и т.д.
// 1 2 3 4 5  --  5 8 3
// 6 7 3 6 -- 36 21

Console.Clear();

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
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

int[] array = CreateArrayRndInt(7, 1, 10);
Console.WriteLine("Исходный массив:");
PrintArray(array);

int[] ArrayPairsMultiply(int[] arr)
{
    int size = arr.Length / 2;
    if (arr.Length % 2 == 1) size += 1;
    int[] newArr = new int[size];
    for (int i = 0; i < arr.Length / 2; i++)
    {
        newArr[i] = arr[i] * arr[arr.Length - i - 1];
    }
    if (arr.Length % 2 == 1) newArr[size - 1] = arr[arr.Length / 2];
    return newArr;
}

int[] newArray = ArrayPairsMultiply(array);
Console.WriteLine("Новый массив:");
PrintArray(newArray);
