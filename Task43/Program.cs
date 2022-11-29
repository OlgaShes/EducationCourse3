// Задача 43: 
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

double[] Intersection(double b1, double k1, double b2, double k2)
{
    double[] point = new double[2];
    point[0] = Math.Round((b2 - b1) / (k1 - k2), 1);
    point[1] = Math.Round(k1 * point[0] + b1, 1);
    return point;
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
double[] crossing = Intersection(line1b, line1k, line2b, line2k);
Console.WriteLine("(" + crossing[0] + "; " + crossing[1] + ")");
