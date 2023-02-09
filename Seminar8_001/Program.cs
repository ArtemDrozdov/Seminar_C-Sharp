/*
Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
*/


// int InputIntNumber(string numberName)
// {
//     Console.Write($"Input {numberName} integer number: ");
//     int number;
//     while (!int.TryParse(Console.ReadLine(), out number))
//     {
//         Console.WriteLine("You inputed something wrong! Try again.");
//         Console.Write($"Input {numberName} integer number: ");
//     }
//     return number;
// }

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

/**/
Random rnd = new Random();
int m = 5; // rnd.Next(4,10); 
int n = 5; // rnd.Next(4,10); 


int[,] array2D = new int[m, n];
int[,] array2DTmp = new int[m, n];
/**/
FillArray2DRandomInt(array2D, rnd); //, lowerRange, upperRange, minDiv, maxDiv);
PrintArray2DInt(array2D);

for (int i = 0; i < array2D.GetLength(1); i++)
{
var tmp = array2D[m-1, i];
array2D[m-1,i] = array2D[0, i];
array2D[0, i] = tmp;
}

Console.WriteLine("новый массив");
PrintArray2DInt(array2D);
/**/
/*
Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
*/
void ReverseMNtoNMArray2DInt(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i; j < array.GetLength(1); j++)
        {
        var tmp = array [i, j];
        array [i, j] = array [j, i];
        array [j, i] = tmp;
        // Console.Write(String.Format("{0, 10}", array[i, j]));
        }
        // Console.WriteLine();
    }
}


FillArray2DRandomInt(array2D, rnd); //, lowerRange, upperRange, minDiv, maxDiv);
PrintArray2DInt(array2D);
Console.WriteLine("новый массив");

if(n != m) 
    Console.WriteLine("не совпадают M и N");
else {
    ReverseMNtoNMArray2DInt(array2D);
    PrintArray2DInt(array2D);
}