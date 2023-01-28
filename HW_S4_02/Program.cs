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
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.WriteLine("Программа принимает на вход число N и выдаёт сумму цифр в числе. Введите N = ");
int input_numb = InputIntNumber("N");
int numb_tmp = Math.Abs(input_numb);
int sum = 0;

while (input_numb > 0)
{
    // Console.Write(input_numb + " ");
    numb_tmp = input_numb % 10;
    input_numb = input_numb / 10;
    sum = sum + numb_tmp;
    // Console.Write("[[" + input_numb + "]]" + " ");
    // Console.Write("[" + numb_tmp + "]" + " ");
}
Console.WriteLine("sum = " + sum);
