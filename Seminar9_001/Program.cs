/*
Решение в группах задач:
Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/
/*
Console.WriteLine("Введите n: --> ");
int n = Convert.ToInt32(Console.ReadLine());

Numbers(n);

void Numbers(int n, int cnt = 1)
{
    if (cnt < n + 1)
    {
        Console.Write(String.Format("{0,4}", cnt));
        Numbers(n, ++cnt);
    }
    else
    {
        return;
    }
}

/**/
/*
Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"
*/
/*
Console.Write("Введите M: --> ");
int minRange = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: --> ");
int maxRange = Convert.ToInt32(Console.ReadLine());

int cnt = minRange,
    delta = 3;

NumbersMN(maxRange, cnt, delta);

void NumbersMN(int n = 10, int cnt = 0, int delta = 1)
{
    if (cnt > maxRange)
        return;
    else
        Console.Write(String.Format("{0,4}", cnt));
    NumbersMN(n, cnt + delta, delta);
}

/**/
/*
Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/
/*
Console.Write("Введите n: --> ");
int n = Convert.ToInt32(Console.ReadLine());

int Funct(int number)
{
    if (number == 0)
        return 0;
    return number % 10 + Funct(number / 10);
}

Console.Write("Funct(n): --> " + Funct(n));
/**/
/*
Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/
/*
Console.Write("Введите A: --> ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите B: --> ");
int b = Convert.ToInt32(Console.ReadLine());

int FunctPow(int a, int b)
{
    if (b == 0)
        return 1;
    // else if (b == 1)
    //     return a;
    else
        return a * FunctPow(a, --b);
}

Console.Write("Funct(n): --> " + FunctPow(a, b));
/**/
