/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
// Random rnd = new Random();
// int a = rnd.Next(100, 1000); // от 100 до 999

int a_tmp;

Console.WriteLine("Введите трехзначное число от 99 до 999, для проверки вывода второго числа:");
string? a = Console.ReadLine();

Console.WriteLine(int.TryParse(a, out a_tmp));

if (99 < a_tmp && a_tmp < 1000)
{
    int secondNumber = a_tmp / 10;
    int secondNumber_tmp = secondNumber % 10;
    System.Console.WriteLine($"вторая цифра: {secondNumber_tmp}");
}
else
{
    System.Console.WriteLine("неправильный ввод числа");
}
