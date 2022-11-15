// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();

int LastDigit(int numb)
{
    return numb % 10;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (Math.Abs(number) < 100) Console.WriteLine("Третьей цифры нет");
else
{
    while (Math.Abs(number) > 999)
    {
        number = number / 10;
    }
    Console.WriteLine("Третья цифра числа --> " + LastDigit(number));
}
