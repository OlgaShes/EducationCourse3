// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Clear();

int CountPositiveInArray(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) result++;
    }
    return result;
}

int[] FillArray(string numb)
{
    string[] arr = numb.Split(new char[] { ' ' , ',' }, StringSplitOptions.RemoveEmptyEntries);
    int[] numbArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        numbArr[i] = Convert.ToInt32(arr[i]);
    }
    return numbArr;
}

Console.Write("Введите числа через пробел или запятую: ");
string numbers = Console.ReadLine();
int[] numbersArray = FillArray(numbers);
System.Console.WriteLine($"Введено {numbersArray.Length} чисел");
int countPositive = CountPositiveInArray(numbersArray);
Console.WriteLine("Количество положительных чисел --> " + countPositive);

