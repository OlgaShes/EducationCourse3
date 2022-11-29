// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Clear();

int[] FillArray(int num)
{
    int[] arr = new int[num];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите число {i + 1}: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

int CountPositiveInArray(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) result++;
    }
    return result;
}

Console.Write("Введите количество чисел: ");
int amount = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(amount);
int coutPositive = CountPositiveInArray(array);
Console.WriteLine("Количество положительных чисел --> " + coutPositive);
