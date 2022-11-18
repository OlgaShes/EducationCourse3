// Принимаем на вход координаты X и Y, получаем номер четверти плоскости, в которой находится точка
// 2 | 1
// -----
// 3 | 4

Console.Clear();

Console.WriteLine("Введите координаты точки:");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int Quater(int xc, int yc)
{
    if (xc > 0 && yc > 0) return 1;
    if (xc < 0 && yc > 0) return 2;
    if (xc < 0 && yc < 0) return 3;
    if (xc > 0 && yc < 0) return 4;
    return 0;
}

int quater = Quater(x, y);
string result = quater > 0
        ? $"Указанные координаты соответствуют {quater} четверти"
        : "Введены некорректные координаты";
Console.WriteLine(result);