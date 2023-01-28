/*
Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
*/

/*
int[] arr = new int[12];
int sum1 = 0;
int sum2 = 0;

Random rnd = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(-9, 10);
}

foreach (var item in arr)
{
    Console.Write(item + ", ");
    
}

foreach (var item in arr)
{
    if(item < 0){
        sum1 += item;
    }
    else sum2 += item;
    
}

Console.WriteLine("\n" + sum1 + " " + sum2);
*/

/*
Решение в группах задач:
Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/
/*
Console.WriteLine(
    "Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот"
);

int[] arr = new int[4];
int[] arr_tmp = new int[4];

Random rnd = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(-10, 11);
}

foreach (var item in arr)
{
    Console.Write(item + ", ");
}

Console.WriteLine();
Console.WriteLine();

for (int i = 0; i < arr_tmp.Length; i++)
{
    arr_tmp[i] = arr[i] * (-1);
}

foreach (var item in arr_tmp)
{
    Console.Write(item + ", ");
}
*/

/*
Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/
/*
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

Console.WriteLine(
    "Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве"
);

int[] arr = new int[5];

Random rnd = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(-1000, 1000);
}
foreach (var item in arr)
{
    Console.Write(item + ", ");
}
Console.WriteLine();
Console.WriteLine();

int N = InputIntNumber("N");
bool Flag_OK = false;

for (int i = 0; i < arr.Length; i++)
{
    if (N == arr[i])
    {
        Console.WriteLine("Присутствует число");
        Flag_OK = true;
        return;
    }
}
if(!Flag_OK) Console.WriteLine("отсутсутствует число");
*/

/*
Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/
/*
int[] arr = new int[123];

Random rnd = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(0, 123);
}
foreach (var item in arr)
{
    Console.Write(item + ", ");
}
Console.WriteLine();
Console.WriteLine();
int cnt = 0;

for (int i = 0; i < arr.Length; i++)
{
    if(10 < arr[i] && arr[i] < 100)
        cnt++;
}
    Console.WriteLine(cnt);
*/
/*
Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
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

Console.WriteLine(cnt);

int[] arr = new int[10];
Random rnd = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(0, 123);
}
foreach (var item in arr)
{
    Console.Write(item + ", ");
}
