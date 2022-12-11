// Задача 66: 
// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int sum = 0;
if (number1 < 1 && number2 < 1) sum = 0;
else if (number1 < 1 && number2 > 0) sum = SumNaturalNumbers(0, number2);
else if (number1 > 0 && number2 < 1) sum = SumNaturalNumbers(0, number1);
else if (number1 <= number2) sum = SumNaturalNumbers(number1, number2);
else sum = SumNaturalNumbers(number2, number1);

if (sum == 0) Console.WriteLine("Натуральных чисел в промежутке нет");
else Console.WriteLine($"Сумма натуральных числе в промежутке от {number1} до {number2} равна {sum}");

int SumNaturalNumbers(int num1, int num2)
{
    if (num1 == num2) return num1;
    else
    {
        return num1 + SumNaturalNumbers(num1 + 1, num2);
    }
}
