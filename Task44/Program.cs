// Первые n чисел фибоначчи
// 5 -- 0 1 1 2 3
// 7 -- 0 1 1 2 3 5 8 

Console.Clear();

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

int[] Fibonacci(int num)
{
    int[] fib = new int[num];
    if (num > 1)
    {
        fib[1] = 1;
        for (int i = 2; i < num; i++)
        {
            fib[i] = fib[i - 1] + fib[i - 2];
        }
    }
    return fib;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1) Console.WriteLine("Неверно заданно число");
else
{
    int[] fibonacci = Fibonacci(number);
    Console.WriteLine($"Первые {number} чисел Фибоначчи: ");
    PrintArray(fibonacci);
}
