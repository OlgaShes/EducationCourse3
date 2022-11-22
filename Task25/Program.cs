// Задача 25: 
// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();

Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int PowerOfNumber(int numA, int numB)
{
    int result = 1;
    for (int i = 0; i < numB; i++)
    {
        result *= numA;
    }
    return result;
}

if (numberB > 0)
{
    int pow = PowerOfNumber(numberA, numberB);
    Console.WriteLine($"Число {numberA} в степени {numberB} равно {pow}");
}
else Console.WriteLine("Число В не натуральное");

