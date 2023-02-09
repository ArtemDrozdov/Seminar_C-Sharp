/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
/*
void FillArray3DRandomInt(
    int[,,] array,
    Random rnd,
    int minRandomRange = 0,
    int maxRandomRange = 100
)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = rnd.Next(minRandomRange, maxRandomRange);
            }
        }
    }
}

/*
void PrintArray3DInt(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(String.Format("{0, 10}", array[i, j, k] + $"[{i},{j},{k}]"));
            }
        }
        Console.WriteLine();
    }
}

/**/
void FillArray3DCntInt(int[,,] array, int minCntRange = 10, int maxCntRange = 100)
{
    int cnt = minCntRange;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (cnt < maxCntRange)
                    array[i, j, k] = cnt++;
                // Console.Write(String.Format("{0, 10}", array[i, j, k] + $"[{i},{j},{k}]"));
            }
            // Console.WriteLine();
        }
        // Console.WriteLine();
    }
}

/**/
void Array3Dto1DInt(int[,,] array3D, int[] array1D)
{
    int idx1D = 0;
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                array1D[idx1D] = array3D[i, j, k];

                // Console.Write(String.Format("{0, 10}", array1D[idx1D] + $"[{idx1D}]"));
                idx1D++;
            }
        }
    }
    // Console.WriteLine();
}

/**/
void MixingArray1DInt(int[] array, Random rnd)
{
    int j = 0,
        tmp = 0;
    for (int i = array.Length - 1; i > 0; i--)
    {
        j = rnd.Next(i);
        tmp = array[j];
        array[j] = array[i];
        array[i] = tmp;

        // Console.Write(String.Format("{0, 10}", array[i] + $"[{i}]"));
    }
    // Console.WriteLine();
}

/**/
void Array1Dto3DInt(int[,,] array3D, int[] array1D)
{
    int idx1D = 0;
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                array3D[i, j, k] = array1D[idx1D++];
                Console.Write(String.Format("{0, 20}", array3D[i, j, k] + $"[{i},{j},{k}] = {array3D[i, j, k]+i+j+k}"));
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

/**/
Random rnd = new Random();
int xA = rnd.Next(4, 4);
int yA = rnd.Next(5, 5);
int zA = rnd.Next(4, 4);
int[] array1Dfrom3D = new int[xA * yA * zA];
int[] array1DTmp = new int[xA * yA * zA];

// int minRandomRange = 10;
// int maxRandomRange = 100;

int[,,] array3D = new int[xA, yA, zA];

// Console.WriteLine("FillArray3DCntInt:");
FillArray3DCntInt(array3D);

Array3Dto1DInt(array3D, array1Dfrom3D);
// Console.WriteLine("MixingArray1DInt:");
MixingArray1DInt(array1Dfrom3D, rnd);
// Console.WriteLine("Array1Dto3DInt:");
Array1Dto3DInt(array3D, array1Dfrom3D);
