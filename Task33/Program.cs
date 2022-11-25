// Задайте массив, напишите программу, проверяющую присутствует ли заданное число в массиве
// массив [6, 7, 19, 345, 3] 4? нет
// массив [6, 7, 19, 345, 3] 3? да

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

bool FindNumberInArray(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num) return true;
    }
    return false;
}

int[] array = CreateArrayRndInt(15, 0, 10);
Console.WriteLine("Исходный массив:");
PrintArray(array);
Console.WriteLine("Введите искомое число: ");
int number = Convert.ToInt32(Console.ReadLine());
bool result = FindNumberInArray(array, number);
Console.WriteLine(result? "Данное число присутствет в массиве" : "Данное число не присутствует в массиве");
