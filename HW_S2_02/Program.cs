/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

int a_tmp;

Console.WriteLine("Введите число, для проверки вывода ТРЕТЬЕЙ ЦИФРЫ СЛЕВА:");
string? a = Console.ReadLine();

if (a == null) // проверка на ввод пустой строки
    return;

Console.WriteLine(int.TryParse(a, out a_tmp));
int b = Math.Abs(Convert.ToInt32(a));

// System.Console.WriteLine($"модуль " + b);

string str = Convert.ToString(b);

/*
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
        if (i == length - 4)
            System.Console.WriteLine($"ТРЕТЬЯ ЦИФРА СЛЕВА: {y}");
    }
}

// System.Console.WriteLine($"ТРЕТЬЕЙ ЦИФРЫ СЛЕВА: {y}");
*/
// ---  --- --- --- --- --- --- ---
// ---  --- --- --- --- --- --- ---
// ---- Вариант №2 из Семинара2

// System.Console.WriteLine(str[2]);

// ---  --- --- --- --- --- --- ---
// ---  --- --- --- --- --- --- ---
// ---- Вариант №3 из Семинара2
/*
int n = b;

while (n > 999)
{
    n = n / 10;
    System.Console.WriteLine(n);
}
System.Console.WriteLine(n % 10);
*/

// ---  --- --- --- --- --- --- ---
// ---  --- --- --- --- --- --- ---
// ---- Вариант №4 из Семинара2

int a_yana = Convert.ToInt32(str); // Convert.ToInt32(Console.ReadLine());
int b_yana = a_yana.ToString().Length;
int divider = Convert.ToInt32(Math.Pow(10, b_yana - 3));

if (b_yana < 3)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine((a_yana / divider) % 10);
}

// ---  --- --- --- --- --- --- ---
// ---  --- --- --- --- --- --- ---
/*
int a = 5;
string b = "5";
string str = a.ToString();

System.Console.WriteLine(a == b);
// System.Console.WriteLine(a.ToString()); // делается в любом случае отдельно не нужно

int a = (int)Math.Pow(5, 3); // равноценно Convert.ToInt32(Math.Pow(5, 3));

*/
