// Вывести случайное трехзначное число и удалить вторую цифру числа
// 456 -> 46
// 782 -> 72

Console.Clear();
int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число --> {number}");

int RemoveSecondDigit(int num)
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    return firstDigit * 10 + thirdDigit;
}

Console.WriteLine($"Полученное двухзначное число --> {RemoveSecondDigit(number)}");
