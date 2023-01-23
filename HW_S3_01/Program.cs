/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
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

/**/
System.Console.WriteLine("Введите пятизначное число и программа проверяет, является ли оно палиндромом");
string? str = Convert.ToString(Math.Abs(Convert.ToInt32(InputIntNumber("Палиндром"))));

int dig_input = Convert.ToInt32(str); // Convert.ToInt32(Console.ReadLine());
int dig_length = dig_input.ToString().Length;

// Console.WriteLine($"{dig_input} - dig_input");
// Console.WriteLine($"{dig_length} - dig_length"); 
// Console.WriteLine($"{(dig_length / 2)} - (dig_length / 2)"); 

bool flag_OK = true;

for (int i = 0; i < (dig_length / 2); i++)
{
    // Console.Write(((dig_input / Convert.ToInt32(Math.Pow(10, /*1+*/i ))) % 10) + " | ");
    // Console.Write( ( dig_input / Convert.ToInt32(Math.Pow(10, /*1+*/i ) ) ) + " | ");
    // Console.Write( Convert.ToInt32(Math.Pow(10, /*1+*/i ) )  + " | ");
    // Console.WriteLine();
    // Console.Write( Convert.ToInt32(Math.Pow(10, (dig_length-1 - i) ) )  + " | ");
    // Console.Write( ((dig_input / Convert.ToInt32(Math.Pow(10, (dig_length-1 - i) ))) % 10)  + " | ");
    // Console.WriteLine();
    // Console.WriteLine();

    if( ((dig_input / Convert.ToInt32(Math.Pow(10, i ))) % 10) != ((dig_input / Convert.ToInt32(Math.Pow(10, (dig_length-1 - i) ))) % 10) ) 
        {
            System.Console.WriteLine("не палиндром"); 
            flag_OK = false; 
            return;
        }
}

if(flag_OK == true) System.Console.WriteLine("палиндром"); 
