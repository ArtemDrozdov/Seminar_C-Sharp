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

/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
Console.WriteLine("Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
Console.WriteLine("Введите последовательность массива через пробел");
string str = Console.ReadLine();

var arr = str.Split(" ");
int[] arrint = new int[arr.Length];
int positiveNumber = 0;

for (int i = 0; i < arr.Length; i++)
{
    arrint[i] = Convert.ToInt32(arr[i]);
    if(arrint[i] > 0) positiveNumber += 1;
}

PrintArray(arrint, arrint.Length);
Console.Write(" <- в массиве чисел больше нуля = " + positiveNumber);