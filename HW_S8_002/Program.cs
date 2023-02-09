/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
/**/
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

/**/
void PrintArrayInt(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(String.Format("{0, 10}", array[i]));
    }
    Console.WriteLine();
}

/**/
void PrintArray2DInt(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(String.Format("{0, 10}", array[i, j]));
        }
        Console.WriteLine();
    }
}

/**/
void SumRowArray2DInt(int[,] array, int[] arraySum)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            arraySum[i] = arraySum[i] + array[i, j];
        }
        // Console.Write(String.Format("{0, 10}", arraySum[i]));
    }
}

/**/
int FindMinIdxArrayInt(int[] array, int maxRandomRange = 0x7FFFFFFF)
{
    int minNumb = maxRandomRange; //0x7FFFFFFF; // 2147483647;
    int minIdx = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minNumb)
        {
            minNumb = array[i];
            minIdx = i;
        }
    }
    return minIdx;
}

/**/
Random rnd = new Random();
int m = rnd.Next(3, 5);
int n = rnd.Next(3, 5);
int minRandomRange = 0;
int maxRandomRange = 100;

int[,] array2D = new int[m, n];
int[] arraySum = new int[m];

Console.WriteLine("сгенерированный массив:");
FillArray2DRandomInt(array2D, rnd, minRandomRange, maxRandomRange); //, lowerRange, upperRange, minDiv, maxDiv);
PrintArray2DInt(array2D);

Console.WriteLine("массив сумм строк:");
SumRowArray2DInt(array2D, arraySum);
PrintArrayInt(arraySum);

Console.WriteLine(
    $"номер строки с наименьшей суммой элементов (начало счета с единицы): {FindMinIdxArrayInt(arraySum)+1} - строка"
);
