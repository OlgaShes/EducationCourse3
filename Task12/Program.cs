// На вход два числа, если число 1 не кратно числу 2, то вывести остаток
// 34, 5 не кратно остаток 4
//16 4 кратно

Console.Clear();
Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

// if (firstNumber % secondNumber == 0) Console.WriteLine ("Числа кратны");
// else Console.WriteLine($"Числа не кратны, остаток {firstNumber % secondNumber}");

// void Multiplicity(int num1, int num2)
// {
//     if (num1 % num2 == 0) Console.WriteLine("Числа кратны");
//     else Console.WriteLine($"Числа не кратны, остаток {num1 % num2}");
// }

// Multiplicity(firstNumber, secondNumber);

// bool Multiplicity1(int number1, int number2)
// {
//     // if(number1 % number2 == 0) return true;
//     // return false;
//     return number1 % number2 == 0;
// }

// bool result = Multiplicity1(firstNumber, secondNumber);
// Console.WriteLine(result ? "Первое число кртано второму" : $"Первое число некратно второму, остаток {firstNumber % secondNumber}");

int Multiplicity2(int number1, int number2)
{
    return number1 % number2;
}

int result2 = Multiplicity2(firstNumber, secondNumber);
Console.WriteLine(result2 == 0 ? "Первое число кртано второму" : $"Первое число некратно второму, остаток {result2}");