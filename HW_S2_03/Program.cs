/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/
int a_tmp;

Console.WriteLine(
    "Введите число, обозначающую день недели, и узнайте, является ли этот день выходным:"
);
string? a = Console.ReadLine();

Console.WriteLine(int.TryParse(a, out a_tmp));

if (a_tmp == 6 || a_tmp == 7)
{
    System.Console.WriteLine("выходной");
}
else if (0 < a_tmp && a_tmp < 6)
{
    System.Console.WriteLine("будни");
}
else
{
    System.Console.WriteLine("ошибочный ввод");
}
