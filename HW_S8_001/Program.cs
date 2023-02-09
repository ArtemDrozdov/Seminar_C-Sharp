/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
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
            Console.Write(String.Format("{0, 10}", array[i, j]));
        }
        Console.WriteLine();
    }
}

// void SortArrayIntDecrease(int[] array)
// {
//     int tmp;
//     for (int i = 0; i < array.Length; i++)
//     {
//         for (int j = 0; j < array.Length; j++)
//         {
//             if (array[i] > array[j])
//             {
//                 tmp = array[i];
//                 array[i] = array[j];
//                 array[j] = tmp;
//             }
//         }
//     }
// }

// задать евгению вопрос, как перекинуть на функцию из двумерного массива на одномерный массив,
// без выделения дополнительной памяти развернув полностью массив в одну строчку, или без назначения
// промежуточного одномерного массива, чтобы не занимать лишнюю память
void SortArray2DIntRowDecrease(int[,] array)
{
    int tmp;
    for (int k = 0; k < array.GetLength(0); k++) // перебор строки
    {
        for (int i = 0; i < array.GetLength(1); i++) // сортировка одномерного массива строки с индексом k
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[k, i] > array[k, j])
                {
                    tmp = array[k, i];
                    array[k, i] = array[k, j];
                    array[k, j] = tmp;
                }
            }
        }
    }
}

/**/
Random rnd = new Random();
int m = rnd.Next(3, 10); // 3; //
int n = rnd.Next(3, 10); // 4; //

int[,] array2D = new int[m, n];

// int[] array1D = new int[4] { 4, 5, 3, 5 }; // [n]; //

Console.WriteLine("сгенерированный массив:");
FillArray2DRandomInt(array2D, rnd); //, lowerRange, upperRange, minDiv, maxDiv);
PrintArray2DInt(array2D);

Console.WriteLine("отсортированный массив:");
SortArray2DIntRowDecrease(array2D);
PrintArray2DInt(array2D);
