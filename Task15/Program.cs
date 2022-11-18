// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();

Console.Write("Введите цифру, соответствующую дню недели: ");
int number = Convert.ToInt32(Console.ReadLine());

// string IfWeekend(int numb)
// {
//     if (numb >= 1 && numb <= 5) return "Не выходной";
//     else if (numb == 6 || numb == 7) return "Выходной";
//     return "Не день недели";
// }

// Console.WriteLine(IfWeekend(number));

bool IfWeekend (int numb)
{
    return numb == 6 || numb == 7 ? true : false;
}

if (number < 1 || number > 7) Console.WriteLine("Нет дня недели с данным номером");
else Console.WriteLine(IfWeekend(number) ? "Этот день недели - выходной" : "Этот день недели не выходной");
