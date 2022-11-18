// Принимаем на вход координаты двух точек и находит расстояние между ними
// A(3, 6) B(2, 1)  5.09

Console.Clear();

Console.WriteLine("Ведите координаты точки А");
Console.Write("X: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите координаты точки B");
Console.Write("X: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yb = Convert.ToInt32(Console.ReadLine());

double Length(int x1, int y1, int x2, int y2)
{
    double distance = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
    return Math.Round(distance, 2, MidpointRounding.ToZero);
}

Console.WriteLine(Length(xa, ya, xb, yb));