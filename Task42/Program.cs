// преобразовать десятичное число в двоичное
// 45 - 101101
// 3 -11
// 2 -10

Console.Clear();

string Binary(int num)
{
    string result = string.Empty;
    while (num != 0)
    {
        result = num % 2 + result;
        num = num / 2;
    }
    return result;
}

Console.Write("Введите десятичное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Данное число в двоичной системе: " + Binary(number));
