/*
Console.Write("Введите элементы, используя между ними запятую: ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(","), int.Parse);
int count = array.Count(x => x > 0);
Console.WriteLine($"Количество элементов больше нуля: {count}");
/**/

/**/
Console.WriteLine(
    "Enter an array of integer elements separated by SPASE, SLASH, DOT or COMMA, end press 'ENTER'"
);
string str = Console.ReadLine();

char[] separator = new char[] { ' ', ',', '.', '/' };
string[] array = str.Split(separator, StringSplitOptions.RemoveEmptyEntries);
int[] a = Array.ConvertAll(array, int.Parse);
Console.WriteLine("Your array:");
Console.Write("{" + string.Join(",", a) + "}");

int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (a[i] > 0)
        count++;
}

Console.WriteLine("\nThe number of positive array elements is:");
Console.WriteLine(count);
/**/

/*
int[,] arr = new int[3, 4];
Random rnd = new Random();

System.Console.WriteLine(arr.Length);

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = rnd.Next(100);
    }
}

// System.Console.Write(string.Join(", ", arr));

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(0); j++)
    {
        Console.Write(arr[i, j] + " ");
    }
    System.Console.WriteLine();
}

Console.WriteLine(String.Join(" ", arr.Cast<int>()));

foreach (var item in arr)
{
    Console.Write(item + " ");
}
/**/
/*
Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5
*/
/*
int InputIntNumber(string numberName)
{
    System.Console.Write($"Input {numberName} :");
    int intNumber = Convert.ToInt32(Console.ReadLine());
    return intNumber;
}

void FillArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i + j;
        }
    }
}

void PrintIntArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

int m = InputIntNumber("число m");
int n = InputIntNumber("число n");
int[,] array2D = new int[m, n];
FillArray2D(array2D);
PrintIntArray2D(array2D);
/**/

/*
Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
Например, изначально массив
 выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4
Новый массив будет выглядеть
вот так:
1 4 7 2
5 81 2 9
8 4 2 4
*/
/*
int InputIntNumber(string numberName)
{
    System.Console.Write($"Input {numberName} :");
   int intNumber = Convert.ToInt32(Console.ReadLine());
    return intNumber;}

void FillintArray2Drandom(int[,] array, Random rnd, int min, int max)
{
    for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j]=rnd.Next(min,max+1);
    }
    
}
}

void PrintIntArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
}
void ChangeArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i%2==0 && j%2==0) array[i,j]=array[i,j]*array[i,j];
        }
        
    }
}
int  m =InputIntNumber("число m");
int  n =InputIntNumber("число n");
Random rnd= new Random();
int [,] array2D= new int [m,n];
FillintArray2Drandom(array2D,rnd,1,9);
PrintIntArray2D(array2D);
ChangeArray2D(array2D);
System.Console.WriteLine();
PrintIntArray2D(array2D);
/**/
/*
Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
*/
int InputIntNumber(string numberName)
{
    System.Console.Write($"Input {numberName} :");
    int intNumber = Convert.ToInt32(Console.ReadLine());
    return intNumber;
}

void FillintArray2Drandom(int[,] array, Random rnd, int min, int max)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
        }
    }
}

void PrintIntArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
}
int SumDArray2D(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
                sum = sum + array[i, j];
        }
    }
    return sum;
}
int m = InputIntNumber("число m");
int n = InputIntNumber("число n");
Random rnd = new Random();
int[,] array2D = new int[m, n];
FillintArray2Drandom(array2D, rnd, 1, 9);
PrintIntArray2D(array2D);

System.Console.WriteLine($"Sum = {SumDArray2D(array2D)}");
