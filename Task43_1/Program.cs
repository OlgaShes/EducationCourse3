// Задача 43: 
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

void Intersection1(double b1, double k1, double b2, double k2, out double x, out double y)
{
    x = Math.Round((b2 - b1) / (k1 - k2), 1);
    y = Math.Round(k1 * x + b1, 1);
}

(double x, double y) Intersection2(double b1, double k1, double b2, double k2)
{
    double x = Math.Round((b2 - b1) / (k1 - k2), 1);
    double y = Math.Round(k1 * x + b1, 1);
    return (x, y);
}

Console.WriteLine("Введите параметры первой прямой");
Console.Write("b = ");
double line1b = Convert.ToDouble(Console.ReadLine());
Console.Write("k = ");
double line1k = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите параметры второй прямой");
Console.Write("b = ");
double line2b = Convert.ToDouble(Console.ReadLine());
Console.Write("k = ");
double line2k = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Метод 1:");
Intersection1(line1b, line1k, line2b, line2k, out double crossXv1, out double crossYv1);
Console.WriteLine("(" + crossXv1 + "; " + crossYv1 + ")");

Console.WriteLine("Метод 2:");
(double crossXv2, double crossYv2) = Intersection2(line1b, line1k, line2b, line2k);
Console.WriteLine("(" + crossXv2 + "; " + crossYv2 + ")");
