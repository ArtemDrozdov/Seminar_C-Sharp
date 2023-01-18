/*
- №1 Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное само на себя)
например: 
4   --> 16
-3  --> 9
-7  --> 49
*/
// Console.Clear();
int x;
int q;

Console.WriteLine("Введите число, для вычисления его квадрата:");
string? str = Console.ReadLine();
// int.Parse 
// int.TryParse
// x = Convert.ToInt32(str);
// Console.WriteLine(x*x);
Console.WriteLine(int.TryParse(str, out q));
// System.Console.WriteLine("Квадрат = " + q*q);
System.Console.WriteLine($"Квадрат = {q*q}");
