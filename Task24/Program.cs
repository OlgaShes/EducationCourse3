// Принимаем число А и выдаем сумму чисел от 1 до А

Console.Clear();

Console.Write("Введите положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Sum(int num)
{
    int result = 0;
    for (int i = 1; i <= num; i++)
    {
        result += i;
    }
    return result;
}

if (number > 0)
{
    int sum = Sum(number);
    Console.WriteLine($"Сумма чисел от 1 до {number} = {sum}");
}
else Console.WriteLine("Введено некорректное число");
