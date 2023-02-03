/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
/*
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
*/
/*
решение на основе сдвига двоичного числа
*/
Console.WriteLine("Введите степень");
int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));

Console.WriteLine("Введите число возводимое в степень");
int x = Math.Abs(Convert.ToInt32(Console.ReadLine()));

string binary = Convert.ToString(n, 2);      // перевод в двоичный код
string kx_str = binary.Replace("0", "k");    // замена 0 на k
       kx_str = kx_str.Replace("1", "kx");   // замена 1 на kx
       kx_str = kx_str.Substring(2);         // отсечение первых двух kx
int res = x;

foreach (char V in kx_str) // перебор символов строки
{
    if (V == 'k') res *= res;
    else          res *= x;
}
Console.WriteLine(res);

