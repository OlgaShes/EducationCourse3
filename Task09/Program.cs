// Вывести случайное число из отрезка 10 - 99 и показать наибольшую цифру числа

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка от 10 до 99 --> {number}");

// int firstDigit = number / 10;
// int secondDigit = number % 10;

// if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа --> {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа --> {secondDigit}");

int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    // if (firstDigit > secondDigit) return firstDigit;
    // return secondDigit;

    // int max = firstDigit > secondDigit ? firstDigit : secondDigit; - тернарный оператор

    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа --> {maxDigit}");