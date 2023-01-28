/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
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

Console.WriteLine("Программа, которая задаёт массив и выводит их на экран.");
Console.WriteLine("Введите длину массива N = ");
int array_length = InputIntNumber("N");

int[] array = new int[array_length];
Random rnd = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(-99, 100);
}

for (int i = 0; i < array.Length; i++)
{
    if (i == 0) Console.Write(array[i]);
    else        Console.Write(", " + array[i]);
}
// Console.WriteLine();
// Console.WriteLine();

// foreach (var item in array)
// {
//     if (item == 0)  Console.Write(item);
//     else            Console.Write(", " + item);
// }
