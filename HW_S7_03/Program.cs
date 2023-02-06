/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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

void FillArray2DRandomInt(
    int[,] array,
    Random rnd,
    int minRandomRange = 0,
    int maxRandomRange = 100
)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(minRandomRange, maxRandomRange);
        }
    }
}

void PrintArray2DInt(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(String.Format("{0, 10}", array[i, j]));
        }
        System.Console.WriteLine();
    }
}

void PrintArray2DMeanColumn(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int sumTmp = 0;
        double mean = 0;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            sumTmp += array[i, j];

            if (i == array.GetLength(0) - 1)
            {
                mean = (double)sumTmp / array.GetLength(0);
                Console.Write(String.Format("{0, 10}", Math.Round(mean,2)));
            }
        }
    }
    System.Console.WriteLine();
}

/**/
Console.WriteLine("Введите параметры массива:");

// int m = InputIntNumber("Длина Строки m от 1 до 10 =");
// int n = InputIntNumber("Длина Столбцов n от 1 до 10 =");
int m = InputIntNumber("Длина Строки m =");
int n = InputIntNumber("Длина Столбцов n =");
Random rnd = new Random();
int[,] array2D = new int[m, n];

FillArray2DRandomInt(array2D, rnd, 0, 10);
PrintArray2DInt(array2D);
Console.WriteLine("среднее арифметическое каждого столбца:");
PrintArray2DMeanColumn(array2D);
