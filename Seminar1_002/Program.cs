/*
Задача №2. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
a = 25, b = 5 -> да
a = 2, b = 10 -> нет
a = 9, b = -3 -> да
a = -3 b = 9 -> нет
*/
int a_tmp, b_tmp;

Console.WriteLine("Введите число A и B, для проверки, является ли первое число квадратом второго:");
string? a = Console.ReadLine();
string? b = Console.ReadLine();

Console.WriteLine(int.TryParse(a, out a_tmp));
Console.WriteLine(int.TryParse(b, out b_tmp));
/*
if (a_tmp == 0 || b_tmp == 0)
{
System.Console.WriteLine("Одно из чисел - строковая переменная");
}
else */ if /*(b_tmp*b_tmp == a_tmp)*/ (Math.Pow(b_tmp, 2) == a_tmp)
{
System.Console.WriteLine("ДА");
}
else
{
System.Console.WriteLine("НЕТ");
}
