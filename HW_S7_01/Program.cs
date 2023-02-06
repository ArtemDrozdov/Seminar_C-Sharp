/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
/**/
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

void FillArray2DRandomDouble(
    double[,] array,
    Random rnd,
    double lowerRange = 1.5, // нижняя граница генерации
    double upperRange = 3.5, // верхняя граница генерации
    int minDiv = 2, // начальное значение, ОБЯЗАТЕЛЬНО > 1
    int maxDiv = 100 // максимум рандома
)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] =
                ((double)1 / rnd.Next(minDiv, maxDiv)) * (upperRange - lowerRange) + lowerRange;
        }
    }
}

void PrintArray2DDouble(double[,] array, int round = 2)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(String.Format("{0, 10}", Math.Round(array[i, j], round)));
        }
        System.Console.WriteLine();
    }
}

int m = InputIntNumber("Длина Строки m =");
int n = InputIntNumber("Длина Столбцов n =");
Random rnd = new Random();
double[,] array2D = new double[m, n];

FillArray2DRandomDouble(array2D, rnd); //, lowerRange, upperRange, minDiv, maxDiv);
PrintArray2DDouble(array2D);
/**/
