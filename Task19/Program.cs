// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool Palindrome(int numb)
{
    int firstDigit = numb / 10000;
    int secondDigit = numb / 1000 % 10;
    int fourthDigit = numb / 10 % 10;
    int fifthDigit = numb % 10;
    return firstDigit == fifthDigit && secondDigit == fourthDigit ? true : false;
}

if (Math.Abs(number) < 10000 || Math.Abs(number) > 99999) Console.WriteLine("Введено не пятизначное число");
else Console.WriteLine(Palindrome(number) ? "Число является палиндромом" : "Число не является палиндромом");

// bool PalindromeGeneral(int numb)
// {
//     int count = numb;
//     int newNumb = 0;
//     while (count != 0)
//     {
//         newNumb = newNumb * 10 + count % 10;
//         count = count / 10;
//     }
//     return numb == newNumb ? true : false;
// }

// Console.WriteLine(PalindromeGeneral(number) ? "Число является палиндромом" : "Число не является палиндромом");
