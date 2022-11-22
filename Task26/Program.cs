// Принимаем на вход число и выдаем количество цифр в числе
// 456 -> 3
// 78 -> 2
// 89754 -> 5

Console.Clear();

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int CountDigits(int num)
{
    int count = 1;
    num = Math.Abs(num);
    while (num >= 10)
    {
        count++;
        num = num / 10;
    }
    return count;
}

int countDigits = CountDigits(number);
Console.WriteLine($"Количество цифр в числе {number} --> {countDigits}");
