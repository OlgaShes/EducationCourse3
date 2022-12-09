// Принимаем целые числа A и B, возводим A в степерь B

Console.Clear();

Console.Write("Введите первое натуральное число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе натуральное число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int pow = PowerOfNumber(number1, number2);
Console.WriteLine($"Число {number1} в степени {number2} равно {pow}");

int PowerOfNumber(int numA, int numB)
{
    if (numB == 1) return numA;
    else if (numB % 2 == 0) return PowerOfNumber(numA * numA, numB / 2);
    else return numA * PowerOfNumber(numA, numB - 1);
}
