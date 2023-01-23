/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
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
/*  --- Основная программа  --- */
System.Console.WriteLine("Программа принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N");

int N = InputIntNumber("Любое N");
int[] array = new int[Math.Abs(N)];


for (int i = 1; i < Math.Abs(N) + 1; i++)
{
    // System.Console.WriteLine(Math.Pow(i, 3) + " ");
    array[i - 1] = (int)Math.Pow(i, 3); // куб i
}

// System.Console.WriteLine();
for (int i = 0; i < Math.Abs(N); i++)
{
    if (i == 0)
        System.Console.Write($"{array[i]}");
    else
        System.Console.Write($", {array[i]}");
}
