/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
int InputIntNumber(string numberName)
{
    Console.Write($"Input {numberName} integer number: ");
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("You inputed something wrong! Try again.");
        Console.Write($"Input {numberName} integer number: ");
    }
    return number;
}
/**/
System.Console.WriteLine("Введите координаты двух точек и найдите расстояние между ними в 3D пространстве");
System.Console.WriteLine("Последовательность ввода координат: точка A (x1, y1, z1), точка B (x2, y2, z2)");
int x1 = InputIntNumber("X1");
int y1 = InputIntNumber("Y1");
int z1 = InputIntNumber("Z1");

int x2 = InputIntNumber("X2");
int y2 = InputIntNumber("Y2");
int z2 = InputIntNumber("Z2");

double d = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2)); // значение длины

Console.WriteLine($"d = {d}");
Console.WriteLine($"d округление = {Math.Round(d, 2, MidpointRounding.AwayFromZero)}");

