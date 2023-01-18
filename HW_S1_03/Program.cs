/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4   -> да
-3  -> нет
7   -> нет
*/
int a_tmp;

Console.WriteLine("Введите число, для проверки четности:");
string? a = Console.ReadLine();

Console.WriteLine(int.TryParse(a, out a_tmp));

if (a_tmp % 2 == 0)
{
System.Console.WriteLine($"{a_tmp} - четное");
}
else
{
System.Console.WriteLine($"{a_tmp} - нечетное");
}
