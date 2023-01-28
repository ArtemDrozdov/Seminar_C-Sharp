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

/*
Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36

Console.WriteLine("Введите число A и выдаст сумму чисел от 1 до А");

int a = Convert.ToInt32(Console.ReadLine());
int sum = 0;

for (int i = 1; i <= a; i++)
{
    sum += i; // sum = sum + i;
}
// string str = "Sum = " + sum;
// Console.WriteLine(str);
Console.WriteLine("Sum = " + sum); //.ToString());
/**/

/*
Общее обсуждение решения:
Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5

Console.WriteLine("Введите число и выдаст количество цифр в числе");
int input_numb = Convert.ToInt32(Console.ReadLine());
int count = 0;


while (input_numb > 0)
{
    input_numb = input_numb / 10;
    count++;
}
Console.WriteLine(count);
*/

/*
Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120

Console.WriteLine("Введите число N и выдаст произведение чисел от 1 до N");
int input_numb = int.Parse(Console.ReadLine());
// int input_numb = Convert.ToInt32(Console.ReadLine());
int tmp_mult = 1;


for (int i = 1; i <= input_numb; i++)
{
    tmp_mult *= i;
    Console.Write(tmp_mult + " ");
}
Console.WriteLine();
Console.WriteLine($"{tmp_mult} - произведение чисел от 1 до N");
*/

/*
Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/
Console.Clear();
Console.WriteLine("Выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке");

int[] array = new int[8];

Random rnd = new Random();
for (int i = 0; i < array.Length; i++) 
{ 
    array[i] = rnd.Next(2);
    Console.Write(array[i] + " ");
}
/**/

/*
Найти все трехзначные числа, чьи квадраты оканчиваются тремя цифрами, которые и составляют искомые числа;
*/