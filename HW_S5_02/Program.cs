/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
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
int sum_odd = 0;

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
    // Console.Write(" %2[" + array[i] % 2 +"] ");
    if (i % 2 == 1) sum_odd = sum_odd + array[i];
}
Console.WriteLine();
Console.WriteLine("сумма элементов, стоящих на нечётных позициях = " + sum_odd);