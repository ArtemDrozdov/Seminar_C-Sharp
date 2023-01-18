/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
int a_tmp, b_tmp, c_tmp;

Console.WriteLine("Введите число A и B и C, для выдачи большего числа:");
string? a = Console.ReadLine();
string? b = Console.ReadLine();
string? c = Console.ReadLine();

Console.WriteLine(int.TryParse(a, out a_tmp));
Console.WriteLine(int.TryParse(b, out b_tmp));
Console.WriteLine(int.TryParse(c, out c_tmp));

if (a_tmp > b_tmp && a_tmp > c_tmp)
{
System.Console.WriteLine($"max = {a_tmp}");
}
else if (b_tmp > a_tmp && b_tmp > c_tmp)
{
System.Console.WriteLine($"max = {b_tmp}");
}
else
{
System.Console.WriteLine($"max = {c_tmp}");
}
