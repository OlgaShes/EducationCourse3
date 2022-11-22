// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.Clear();

int[] ArrayFilling(int size, int minNum, int maxNum)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(minNum, maxNum + 1);
    }
    return arr;
}

void ArrayPrint(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

Console.Write("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальную границу диапазона: ");
int minNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальную границу диапазона: ");
int maxNumber = Convert.ToInt32(Console.ReadLine());
int[] array = ArrayFilling(length, minNumber, maxNumber);
Console.WriteLine($"Массив длинной {length} cо случайными числами от {minNumber} до {maxNumber}:");
ArrayPrint(array);

