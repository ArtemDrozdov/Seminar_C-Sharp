/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
Console.Write("Введите M: --> ");
int minRange = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: --> ");
int maxRange = Convert.ToInt32(Console.ReadLine());

int SumNumbersMN(int m = 1, int n = 15)
{
    if (m == n)
        return n;
    else
        return n + SumNumbersMN(m, --n);
}

Console.WriteLine($"сумма натуральных элементов в промежутке от {minRange} до {maxRange} = " + SumNumbersMN(minRange, maxRange));
