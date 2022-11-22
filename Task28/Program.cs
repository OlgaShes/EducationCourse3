// Принимаем число N, выдаем произведение чисел от 1 до N

Console.Clear();

Console.Write("Введите положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Multiplication(int num)
{
    int result = 1;
    for (int i = 1; i < num + 1; i++)
    {
        result *= i;
    }
    return result;
}

if (number > 0)
{
int mult = Multiplication(number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {mult}");
}
else Console.WriteLine("Введено некорректное число");