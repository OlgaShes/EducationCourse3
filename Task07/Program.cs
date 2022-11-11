// Напишите программу, которая принимает на вход трехзначное число и на выходе
// показывает последнюю цифру этого числа
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.Clear();
Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if ((number >= 100) && (number < 1000))
{
Console.WriteLine("Последняя цифра данного числа: " + number % 10);
}
else Console.WriteLine("Число не является трехзначным");