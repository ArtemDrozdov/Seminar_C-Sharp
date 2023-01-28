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

/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
Console.WriteLine(
    "Принимает на вход два числа (A и B) и возводит число A в натуральную степень B: "
);
int A = InputIntNumber("A");
int B = InputIntNumber("B");
int A_tmp = A;

if (B == 0) {
    Console.WriteLine("A^B = 1"); return;
}
else
    for (int i = 1; i < B; i++)
    {
        A_tmp = A_tmp * A;
        Console.Write(A_tmp + " ");
    }

Console.WriteLine("A^B = " + A_tmp);
