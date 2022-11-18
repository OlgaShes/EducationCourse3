// По заданному номеру четверти показывем диапазон возможных точек четверти
// 2 | 1
// -----
// 3 | 4

Console.Clear();

Console.Write("Ведите номер четверти: ");
string quoter = Console.ReadLine();

string Range(string quot)
{
    if (quot == "1") return "x > 0, y > 0";
    if (quot == "2") return "x < 0, y < 0";
    if (quot == "3") return "x < 0, y < 0";
    if (quot == "4") return "x > 0, y < 0";
    return "Неверно задана четверть";
}

Console.WriteLine(Range(quoter));