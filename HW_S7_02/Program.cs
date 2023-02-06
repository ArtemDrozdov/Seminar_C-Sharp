/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
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

/**/
Console.WriteLine("Введите параметры массива:");
// int m = InputIntNumber("Длина Строки m от 1 до 10 =");
// int n = InputIntNumber("Длина Столбцов n от 1 до 10 =");
int m = InputIntNumber("Длина Строки m =");
int n = InputIntNumber("Длина Столбцов n =");
Random rnd = new Random();
int[,] array2D = new int[m, n];

FillArray2DRandomInt(array2D, rnd);
PrintArray2DInt(array2D);
int row = 0;
int col = 0;

// Console.WriteLine(
//     "Введите позицию извлекаемого элемента двумерного массива, где первое число идет строка[от 0 до 9], второе - столбец[от 0 до 9]:"
// );
// int position = Convert.ToInt32(Console.ReadLine());
// int row = position / 10;
// int col = position % 10;
// Console.WriteLine($"row = {row}, col = {col}");

// if (m > 10 || n > 10 || m < row || n < col)
//     Console.WriteLine("такого элемента в массиве нет");
// else
//     Console.WriteLine(array2D[row, col]);

Console.WriteLine("Введите позицию извлекаемого элемента двумерного массива через запятую: столбец, строка");
Console.WriteLine(
    "Enter the position of the extracted element of the two-dimensional array, \nof integer elements separated by SPASE, SLASH, DOT or COMMA, end press 'ENTER'"
);
string str = Console.ReadLine();
int[] arrayPosition = new int[2];

char[] separator = new char[] { ' ', ',', '.', '/' };
string[] arraySeparator = str.Split(separator, StringSplitOptions.RemoveEmptyEntries);
arrayPosition = Array.ConvertAll(arraySeparator, int.Parse);

// Console.WriteLine("test:");
// foreach (var item in arrayPosition)
// {
//     Console.Write(item + " ");
// }

row = arrayPosition[0];
col = arrayPosition[1];
Console.WriteLine($"row = {row}, col = {col}");

if (m <= row || n <= col)
    Console.WriteLine("такого элемента в массиве нет");
else
    Console.WriteLine(array2D[row, col]);

/**/
