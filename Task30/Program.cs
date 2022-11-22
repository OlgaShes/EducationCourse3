// Написаль программу, котрая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке
// [1,0,1,1,0,1,0,0]

// int size = 8;
// int[] array = new int[size]; - массив размера size, заполненный нулями
// int[] array2 = { 1, 8, 8, 4, 3 };

// Random rnd = new Random();
// array[i] = rnd.Next();

Console.Clear();

int size = 8;
int[] array = new int[size];

void ArrayFilling(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 2);
    }
}

void ArrayPrint(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

ArrayFilling(array);
ArrayPrint(array);
