/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29

https://ru.wikipedia.org/wiki/%D0%A4%D1%83%D0%BD%D0%BA%D1%86%D0%B8%D1%8F_%D0%90%D0%BA%D0%BA%D0%B5%D1%80%D0%BC%D0%B0%D0%BD%D0%B0
в таблице поменяны M и N
*/
Console.Write("Введите M: --> ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: --> ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("ack = ");
Console.WriteLine(ack(m, n));
Console.Write("ack2 = ");
Console.WriteLine(ack2(m, n));

int ack(int n, int m)
{
    if (n == 0)
        return m + 1;
    else if (m == 0)
        return ack(n - 1, 1);

    return ack(n - 1, ack(n, m - 1));
}

int ack2(int n, int m)
{
    while (n != 0)
    {
        if (m == 0)
            m = 1;
        else
            m = ack2(n, m - 1);
        n = n - 1;
    }
    return m + 1;
}
