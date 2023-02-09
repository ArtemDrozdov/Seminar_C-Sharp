/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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
void MatrixMultInt(int[,] arrayA, int[,] arrayB, int[,] arrayC)
{
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
            for (int k = 0; k < arrayB.GetLength(0); k++)
            {
                arrayC[i, j] += arrayA[i, k] * arrayB[k, j];
            }
        }
    }
}

/**/
Random rnd = new Random();
int mA = rnd.Next(3, 5); // строки A матрицы
int nA = rnd.Next(3, 5); // столбцы A матрицы
int mB = nA; // rnd.Next(3, 5); // строки B матрицы
int nB = mA; // rnd.Next(3, 5); // столбцы B матрицы
int mC = mA;
int nC = nB;

int minRandomRange = 0;
int maxRandomRange = 10;

int[,] aArray2D = new int[mA, nA];
int[,] bArray2D = new int[mB, nB];
int[,] cArray2D = new int[mC, nC];

Console.WriteLine("сгенерированный A массив:");
FillArray2DRandomInt(aArray2D, rnd, minRandomRange, maxRandomRange); //, lowerRange, upperRange, minDiv, maxDiv);
PrintArray2DInt(aArray2D);

Console.WriteLine("сгенерированный B массив:");
FillArray2DRandomInt(bArray2D, rnd, minRandomRange, maxRandomRange); //, lowerRange, upperRange, minDiv, maxDiv);
PrintArray2DInt(bArray2D);

if (nA != mB)
    Console.WriteLine("nA != mB - матрицы не согласованы");
else
{
    Console.WriteLine("nA == mB - матрицы согласованы");
    Console.WriteLine("C = A * B = ");
    MatrixMultInt(aArray2D, bArray2D, cArray2D);
    PrintArray2DInt(cArray2D);
}
