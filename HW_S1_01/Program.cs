/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5;  b = 7   -> max = 7
a = 2;  b = 10  -> max = 10
a = -9; b = -3  -> max = -3
*/
int a_tmp, b_tmp;

Console.WriteLine("Введите число A и B, для выдачи большего числа:");
string? a = Console.ReadLine();
string? b = Console.ReadLine();

Console.WriteLine(int.TryParse(a, out a_tmp));
Console.WriteLine(int.TryParse(b, out b_tmp));

if (a_tmp > b_tmp)
{
System.Console.WriteLine($"max = {a_tmp}");
}
else
{
System.Console.WriteLine($"max = {b_tmp}");
}
