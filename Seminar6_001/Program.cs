/*
Напишите программу, которая перевернет одномерный массив
*/
/*
Console.WriteLine("Введите последовательность массива через пробел");
string str = Console.ReadLine();

var arr = str.Split(" ");

int[] arrint = new int[arr.Length];
int[] arr_tmp = new int[arr.Length];

for (int i = 0; i < arr.Length; i++)
{
    arrint[i] = Convert.ToInt32(arr[i]);
    arr_tmp[(arr.Length -1) - i] = arrint[i];
}

foreach (var item in arr_tmp)
{
    System.Console.Write(item + " ");
}
/**/
/*
Вариант на Семинаре 6 от дмитрия
*/
/*
System.Console.Write("Размер массива: ");
int len = Convert.ToInt32(Console.ReadLine());
int[] array = new int[len];
Random rnd = new Random();

FillRandomArray(array, len);
PrintArray(array, len);
System.Console.WriteLine("");
// ReverseArray(array, len);
RecursReverseArray(array, 0, array.Length-1);
PrintArray(array, len);

void ReverseArray(int[] array, int length)
{
    int temp;
    for (int i = 0; i < length / 2; i++)
    {
        temp = array[i];
        array[i] = array[length - 1 - i];
        array[length - 1 - i] = temp;
    }
}
void FillRandomArray(int[] array, int length)
{
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(100);
    }
}
void PrintArray(int[] array, int length)
{
    Console.Write("[");
    for (int i = 0; i < length; i++)
    {
        if (i < length - 1)
            Console.Write(array[i] + ", ");
        else
            Console.Write(array[i] + "]");
    }
}

void RecursReverseArray(int[] array, int i, int j) // реверсия с рекурсией
{
    if (i >= j)
        return;
    else
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;

        RecursReverseArray(array, i+1, j-1);
    }
}
*/
/*
Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
*/
/*
Console.WriteLine(
    "Напишите программу, которая принимает на вход три числа и проверяет, \n"
        + "может ли существовать треугольник с сторонами такой длины.\n"
        + "Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.\n"
);
Console.Write("Сторона A = ");
int sideA = Convert.ToInt32(Console.ReadLine());
Console.Write("Сторона B = ");
int sideB = Convert.ToInt32(Console.ReadLine());
Console.Write("Сторона C = ");
int sideC = Convert.ToInt32(Console.ReadLine());

if ((sideA < sideB + sideC) &&
    (sideB < sideA + sideC) &&
    (sideC < sideA + sideB))
    Console.WriteLine("это треугольник");
else
    Console.WriteLine("это НЕ треугольник");
/**/
/*
Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/
/*
Console.WriteLine("Напишите программу, которая будет преобразовывать десятичное число в двоичное.");
Console.Write("Десятичное число = ");
int inputNumb = Convert.ToInt32(Console.ReadLine());

string binary = "";
if (inputNumb != 0)
{
    while (inputNumb > 0)
    {
        binary = inputNumb % 2 + binary;
        inputNumb = inputNumb / 2;
    }
}
else
    binary = "0";
Console.WriteLine(binary);
/**/
/*
второй вариант
*/
/*
int InputNumber()
{
    Console.Write("Введите число: ");
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}

int a = InputNumber();
string n = string.Empty;

while (a >= 1)
{
    n = a % 2 + n;
    a = a / 2;
}
Console.WriteLine(n);
/**/
/*
Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/
/*
int InputNumber()
{
    Console.Write("Введите число: ");
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}

int inputNumb = InputNumber();
int a = 0;
int b = 1;
int temp = 0;

for (int i = 0; i < inputNumb; i++)
{
    Console.Write(a + " ");
    temp = a;
    a = b;
    b = a + temp;
}
/**/ 
/*
другой вариант
*/
int InputNumber()
{
    Console.Write("Введите число: ");
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}

Console.Write("N > 3");
int inputNumb = InputNumber();

int[] arrayFibonachi = new int[inputNumb];
arrayFibonachi[0] = 0;
arrayFibonachi[1] = 1;

Console.Write(arrayFibonachi[0] + " ");
Console.Write(arrayFibonachi[1] + " ");

for (int i = 2; i < arrayFibonachi.Length; i++)
{
    arrayFibonachi[i] = arrayFibonachi[i - 1] + arrayFibonachi[i - 2];
    Console.Write(arrayFibonachi[i] + " ");
}

/*
Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
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
Console.Write("Введите длину массива: ");
int arrayLength = InputIntNumber("N");

int[] array = new int[arrayLength];
Random rnd = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(10);
}
foreach (var item in array)
{
    Console.Write(item + ", ");
}
Console.WriteLine();

int[] arrayCopy = new int[arrayLength];

for (int i = 0; i < arrayCopy.Length; i++)
{
    arrayCopy[i] = array[i];
}
foreach (var item in arrayCopy)
{
    Console.Write(item + ", ");
}
/**/