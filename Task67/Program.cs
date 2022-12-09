//  Принимаем число и возвращаем сумму его цифр
// 453 --> 12

Console.Clear();

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sum = SumOfDigits(number);
Console.WriteLine($"Сумма цифр данного числа = {sum}");

int SumOfDigits(int num)
{
    return num < 10 ? num : num % 10 + SumOfDigits(num / 10);
}
