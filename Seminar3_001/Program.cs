/*
Напишите программу, которая принимает на вход координаты точки (X, Y), причем X != 0, Y != 0,
и выдает номер четверти пллоскости в которой находится эта точка
*/
/*
System.Console.WriteLine("Координата X:");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Координата Y:");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0) {
    System.Console.WriteLine("Первая четверть");
}
else if (x < 0 && y > 0) {
    System.Console.WriteLine("Вторая четверть");
}
else if (x < 0 && y < 0) {
    System.Console.WriteLine("Третья четверть");
}
else if (x > 0 && y < 0) {
    System.Console.WriteLine("Четвертая четверть");
}
*/
/*
Отличие работы && и &
*/
/*
bool BL(string name, bool f)
{
    System.Console.Write(name);
    return f;
}
if (BL("hello | ", false) && BL("chao | ", true) && BL("bonjour | ", true))
    System.Console.Write("OK");

*/
/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
от 1 до N.

5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/
/*
int N;
int[] Array;

Console.WriteLine("Введите целое число N, для вывода таблицы квадратов чисел от 1 до N:");
string? a = Console.ReadLine();

Console.WriteLine(int.TryParse(a, out N));

// if (N != 0)
// {
    for (int i = 1; i <= Math.Abs(N); i++)
    {
        // System.Console.Write($"{i}, ");
        System.Console.Write(i*i + " ");
        // Array[i] = i * i;
    }
// }
// else
// {
//     System.Console.WriteLine("неправильный ввод");
// }

    // for (int i = 1; i <= Math.Abs(N); i++)
    // {
    //     System.Console.WriteLine(Array[i]);
    // }

*/
/*
    вариант №2 на семинаре
*/
int InputIntNumber(string numberName)
{
    Console.Write($"Input {numberName} integer number: ");
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("You inputed something wrong! Try again.");
        Console.Write($"Input {numberName} integer number: ");
    }
    return number;
}

int a = InputIntNumber("Любое");
int[] array = new int[Math.Abs(a)];

for (int i = 1; i < Math.Abs(a)+1; i++)
{
    System.Console.WriteLine(i * i);
    array[i - 1] = i * i;
}
System.Console.WriteLine();
for (int i = 0; i < Math.Abs(a); i++)
{
    System.Console.Write($"{array[i]} ");
}