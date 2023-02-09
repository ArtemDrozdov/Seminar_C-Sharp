/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

/**/
void PrintArray2DInt(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(String.Format("{0, 10}", array[i, j] + $"[{i},{j}]"));
            // Thread.Sleep(10);
        }
        Console.WriteLine();
    }
}

/**/
void SpiralArray2DInt(int[,] array)
{
    int m = array.GetLength(1);
    int n = array.GetLength(0);
    int cnt = 1;
    int i = 0,
        j = 0;

    while (n != 0 && m != 0)
    {
        int k = 0;
        for (k = 0; k < m - 1; k++) array[i, j++] = cnt++;
        for (k = 0; k < n - 1; k++) array[i++, j] = cnt++;
        for (k = 0; k < m - 1; k++) array[i, j--] = cnt++;
        for (k = 0; k < n - 1; k++) array[i--, j] = cnt++;

        i++;
        j++;
        n = (n < 2)? 0 : n - 2;
        m = (m < 2)? 0 : m - 2;
    }
}

/**/
Random rnd = new Random();
int m = rnd.Next(3, 10); // строки, больше 1
int n = rnd.Next(3, 10); // столбцы, больше 1

int[,] array2D = new int[m, n];

SpiralArray2DInt(array2D);

Console.WriteLine("вывод спиральной матрицы");
PrintArray2DInt(array2D);
