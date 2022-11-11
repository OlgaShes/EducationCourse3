// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе 
// показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 2) Console.WriteLine("Неправильно задан диапазон");
else
{
    int count = 2;
    Console.WriteLine($"Все четные числа в диапазоне от 1 до {number}:");
    while (count <= number)
    {
        Console.Write(count + " ");
        count += 2;
    }
}