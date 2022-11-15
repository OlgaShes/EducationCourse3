// Принимаем на вход число и проверяем кратно ли 7 и 23

Console.Clear();

bool MultiplicityTwoNumbers(int num, int num1, int num2)
{
    // if (num % 7 == 0 && num % 23 == 0) return true;
    // return false;
    return num % num1 == 0 && num % num2 == 0;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
bool result = MultiplicityTwoNumbers(number, 7, 23);
Console.WriteLine(result ? "Число кратно одновременно 7 и 23" : "Число некратно одновременно 7 и 23");