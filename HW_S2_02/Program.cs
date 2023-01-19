/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

int a_tmp;

Console.WriteLine("Введите число, для проверки вывода ТРЕТЬЕЙ ЦИФРЫ СЛЕВА:");
string? a = Console.ReadLine();

Console.WriteLine(int.TryParse(a, out a_tmp));
int b = Math.Abs(Convert.ToInt32(a));
// System.Console.WriteLine($"модуль " + b);

string str = Convert.ToString(b);
int length = str.Length;
System.Console.WriteLine($"длина числа = {length}");
int x = b;
int y;

if (a_tmp < 100 && a_tmp > -100)
{
    System.Console.WriteLine($"третьей цифры нет");
}
else
{
    for (int i = 0; i < length - 3; i++)
    {
        x = x / 10;
        y = x % 10;

    //     System.Console.WriteLine($"деление на 10 в цикле = {x}");
    //     System.Console.WriteLine($"деление на %10 в цикле = {y}");
    if(i == length - 4) System.Console.WriteLine($"ТРЕТЬЯ ЦИФРА СЛЕВА: {y}");
    }
}

// System.Console.WriteLine($"ТРЕТЬЕЙ ЦИФРЫ СЛЕВА: {y}");
