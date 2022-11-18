// Принимаем на вход N и выдаем таблицу квадратов от 1 до N
// n = 5
// 1 1
// 2 4
// 3 9
// 4 16
// 5 25

Console.Clear();

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

void Squares(int number)
{
    for (int i = 1; i <= number; i++)
    {
        Console.WriteLine(i + " -> " + i * i);
    }
}

if (number < 1) Console.WriteLine("Ведено неверное число");
else Squares(number);