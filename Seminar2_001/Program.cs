// int Max(int a, int b)
// {
//     if (a > b)
//         return a;
//     else
//         return b;
// }

// Random rnd = new Random();

// int a = rnd.Next(10, 100);

// System.Console.WriteLine($"Random = {a}");

// int firstNumber = a / 10;
// int secondNumber = a % 10;

// int max = Max(firstNumber, secondNumber); // Max(2,1)

// System.Console/WriteLine($"Max = {max}");

// Convert.ToInt

// Random rnd = new Random();
// int a = rnd.Next(100, 1000); // от 100 до 999

// int firstNumber = a / 100, 
//  //   secondNumber = a / 10, 
//     thirdNumber = a % 10;

// Console.WriteLine(a);
// Console.WriteLine(firstNumber*10 + thirdNumber);

// // dotnet new console -o task_1

/* Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

34, 5 -> не кратно, остаток 4 
16, 4 -> кратно
*/

Console.Clear();

int x = Convert.ToInt32(Console.ReadLine());
