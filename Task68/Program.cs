// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.Clear();

Console.Write("Введите первое неотрицательное число M: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе неотрицательное число N: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 < 0 || number2 < 0) System.Console.WriteLine("Оба числа должны быть неотрицательными");
else
{
    int ackerman = Ackerman(number1, number2);
    Console.WriteLine("Результат вычисления функции Аккермана:");
    Console.WriteLine($"A({number1}, {number2}) = {ackerman}");
}

int Ackerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return Ackerman(m - 1, 1);
    else return Ackerman(m - 1, Ackerman(m, n - 1));
}

