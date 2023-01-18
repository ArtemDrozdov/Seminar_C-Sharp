/*
Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
456 -> 6
782 -> 2
918 -> 8
*/

int a_tmp;

Console.WriteLine("Введите число от 100 до 999, для вывода последней цифры числа:");
string? a = Console.ReadLine();

Console.WriteLine(int.TryParse(a, out a_tmp));

if (99 < a_tmp && a_tmp < 1000)
{
    System.Console.WriteLine(a_tmp % 10);
}
else
{
    System.Console.WriteLine("Неправильный ввод числа");
}
