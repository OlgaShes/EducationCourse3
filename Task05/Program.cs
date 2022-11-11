Console.Clear();
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int count = -number;
Console.WriteLine($"Ряд чисел от {count} до {number}:");
while(count <= number)
{
    Console.Write(count + " ");
    count += 1;
}