// Напишите программу замены элементов массива с положительных на отрицательные и наоборот
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

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

void InverseArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = -arr[i];
    }
}

int[] array = CreateArrayRndInt(15, -10, 10);
Console.WriteLine("Исходный массив:");
PrintArray(array);
InverseArray(array);
Console.WriteLine("Новый массив:");
PrintArray(array);
