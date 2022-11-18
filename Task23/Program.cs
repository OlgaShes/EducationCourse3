// // Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.Clear();

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

void Cube(int numb)
{
    for (int i = 1; i <= numb; i++)
    {
        Console.WriteLine(i + " | " + i * i * i);
    }
}

if (number < 1) Console.WriteLine("Введено некорректное число");
else
{
    Console.WriteLine($"Таблица кубов чисел от 1 до {number}:");
    Cube(number);
}
