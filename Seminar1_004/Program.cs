/*
Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
2 -> " -2, -1, 0, 1, 2"
*/
int a_tmp;

Console.WriteLine("Введите целое число N для вывода всех целых чисел в промежутке от -N до N:");
string? a = Console.ReadLine();

Console.WriteLine(int.TryParse(a, out a_tmp));

if (a_tmp > 0)
{
    for (int i = -a_tmp; i < a_tmp+1; i++)
    {
        System.Console.Write($"{i}, ");
        // System.Console.Write(i = " ");
    }
}
else
{
    System.Console.WriteLine("неправильный ввод");
}

