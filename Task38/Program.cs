// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.Clear();

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 1, MidpointRounding.ToZero);
    }
    return arr;
}

void PrintArrayDouble(double[] arr)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i< arr.Length -1) Console.Write($"{arr[i]} | ");
        else Console.Write(arr[i]);
    }
    Console.WriteLine(" ]");
}

double[] array = CreateArrayRndDouble(7, 1, 100);
Console.WriteLine("Исходный массив:");
PrintArrayDouble(array);

double MinArrayDouble(double [] arr)
{
    double minNum = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < minNum) minNum = arr[i];
    }
    return minNum;
}

double MaxArrayDouble(double [] arr)
{
    double maxNum = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > maxNum) maxNum = arr[i];
    }
    return maxNum;
}

double minArray = MinArrayDouble(array);
double maxArray = MaxArrayDouble(array);
double diffMinMax = Math.Round(maxArray - minArray, 1, MidpointRounding.ToZero);
Console.WriteLine($"Разница между максимальным и минимальным элементом равна {diffMinMax}");




// double DifferenceMinMax(double[] arr)
// {
//     double minNum = arr[0];
//     double maxNum = arr[0];
//     for (int i = 1; i < arr.Length; i++)
//     {
//         if (arr[i] > maxNum) maxNum = arr[i];
//         if (arr[i] < minNum) minNum = arr[i];
//     }
//     return Math.Round(maxNum - minNum, 1, MidpointRounding.ToZero);
// }

// double diffMinMax = DifferenceMinMax(array);
// Console.WriteLine($"Разница между максимальным и минимальным элементом равна {diffMinMax}");
