/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
/*
/y = k1 * x + b1;
\y = k2 * x + b2;

k1 * x + b1 = k2 * x + b2
(k1 - k2) * x = b2 - b1

x = (b2 - b1) / (k1 - k2) 

y = k1 * x + b1 // любое из уравнений подставив x
y = k2 * x + b2
*/

Console.Write("Введите K1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите B1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите K2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите B2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

double x = 0, y = 0;

if ((k1 == k2) && (b1 == b2))
    Console.WriteLine("Прямые совпадают");
else if (k1 == k2)
    Console.WriteLine("Прямые параллельны");
else
{
    x = (b2 - b1) / (k1 - k2);

    y = k1 * (b2 - b1) / (k1 - k2) + b1;

    Console.WriteLine($"x = {x}, y = {y}");
}
