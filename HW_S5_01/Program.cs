/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
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

Console.WriteLine("Введите длину массива");
int array_length = InputIntNumber("Length Number");
int even_number = 0;

int[] array = new int[array_length];
Random rnd = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(99, 1000);
}

for (int i = 0; i < array.Length; i++)
{
    if (i == 0) Console.Write(array[i]);
    else        Console.Write(", " + array[i]);
    // Console.Write(" %2[" + array[i] % 2 +"] ");
    if (array[i] % 2 == 0) even_number++;
}
Console.WriteLine();
Console.WriteLine("количество четных чисел = " + even_number);