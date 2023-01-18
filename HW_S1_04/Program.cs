/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/
int a_tmp;

Console.WriteLine("Введите целое число N для вывода всех чётных чисел от 1 до N:");
string? a = Console.ReadLine();

Console.WriteLine(int.TryParse(a, out a_tmp));

if (a_tmp > 1)
{
    for (int i = 2; i <= a_tmp; i=i+2)
    {
        // System.Console.Write($"{i}, ");
        System.Console.Write(i + " ");
    }
}
else
{
    System.Console.WriteLine("неправильный ввод");
}
