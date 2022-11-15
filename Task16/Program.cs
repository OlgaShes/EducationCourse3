//  Принять два числа и проверить, является ли одно квадратом второго
// 5, 25 - да
// 16, -4 - да

Console.Clear();

bool IfSquare(int num1, int num2)
{
    return num1 == num2 * num2 || num2 == num1 * num1;
}

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

bool result = IfSquare(firstNumber, secondNumber);
Console.WriteLine(result ? "Одно число является квадратом другого" : "Ни одно число не является квадратом другого");