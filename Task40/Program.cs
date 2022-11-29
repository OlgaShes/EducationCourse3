// Принимаем на вход 3 числа и выясняем, существует ли треугольник с данными длинами
// каждая сторона меньше суммы двух других

Console.Clear();

bool IsTriangle(int num1, int num2, int num3)
{
    return num1 + num2 > num3 && num1 + num3 > num2 && num2 + num3 > num1;
}

Console.Write("Введите длину первой стороны: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину второй стороны: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину третьей стороны: ");
int number3 = Convert.ToInt32(Console.ReadLine());
if (number1 < 1 || number2 < 1 || number3 < 1) Console.WriteLine("Неверно заданы стороны");
else
{
    bool triangle = IsTriangle(number1, number2, number3);
    Console.WriteLine(triangle ? "Данный треугольник существует" : "Данный треугольник не существует");
}
