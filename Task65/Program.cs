// Задайте m и n. Вывести все натуральные числа в промежутке от m до n
// m = 4, n = 8 -->  4, 6, 7, 8
// m = 7, n = 3 -->  7, 6, 5, 4, 3

Console.Clear();

Console.Write("Введите первое натуральное число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе натуральное число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

NaturalNumbers(number1, number2);

void NaturalNumbers(int m, int n)
{
    if (m < n)
    {
        Console.Write($"{m} ");
        NaturalNumbers(m + 1, n);

    }
    else if (m > n)
    {
        Console.Write($"{m} ");
        NaturalNumbers(m - 1, n);
    }
    else
    {
        Console.Write($"{n} ");
    }
}
