// Задайте массив из 123 случайных чисел
// Найдите количество элементов в отрезке [10, 99]

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

int[] array = CreateArrayRndInt(15, 0, 500);
Console.WriteLine("Исходный массив:");
PrintArray(array);

int FindAmountNumbers(int[] arr, int minNumber, int maxNumber)
{
    int amount = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= minNumber && arr[i] <= maxNumber) amount++;
    }
    return amount;
}

int result = FindAmountNumbers(array, 10, 99);
Console.WriteLine(result > 0 ? 
                  $"В массиве {result} чисел из заданного диапазона": 
                    "В массивет нет чисел из указанного дапазона");

