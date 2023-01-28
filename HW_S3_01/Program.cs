/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
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
    // Console.Write(((dig_input / Convert.ToInt32(Math.Pow(10, i ))) % 10) + " | ");
    int dig_lsb = (dig_input / (int)Math.Pow(10, i )) % 10;
    // Console.Write( ( dig_input / Convert.ToInt32(Math.Pow(10, i ) ) ) + " | ");
    // Console.Write( Convert.ToInt32(Math.Pow(10, i ) )  + " | ");
    // Console.WriteLine();
    // Console.Write( Convert.ToInt32(Math.Pow(10, (dig_length-1 - i) ) )  + " | ");
    // Console.Write( ((dig_input / Convert.ToInt32(Math.Pow(10, (dig_length-1 - i) ))) % 10)  + " | ");
    int dig_msb = (dig_input / (int)Math.Pow(10, (dig_length-1 - i))) % 10;
    // Console.WriteLine();
    // Console.WriteLine();

    if(dig_lsb != dig_msb) 
        {
            System.Console.WriteLine("не палиндром"); 
            flag_OK = false; 
            return;
        }
}

if(flag_OK == true) System.Console.WriteLine("палиндром"); 
*/

/*
ПРИМЕР текстового палиндрома
*/
Console.Clear();
System.Console.Write("Введите число/фразу (Примеры: А роза упала на лапу Азора; Чем нежен меч; Аргентина манит негра; Нажал кабан на баклажан; Уж редко рукою окурок держу): ");
string? input = Console.ReadLine();
if(input == null) return;
input = input.ToLower();                        // Перевод всех символов в нижний регистр

input = input.Replace(" ","");                  // Удалили пробелы
// System.Console.WriteLine(input);

char[] array = input.ToCharArray();             // Заполнили массив символами

System.Console.WriteLine(CheckPalindr(array));  // Проверка и вывод результата

string CheckPalindr(char[] array)
{
    int len = array.Length;
    int i = 0;
    while (i < (len / 2))
    {
        if (array[i] == array[len - i -1]) {i++;}
        else return "Не палиндром";
    }
    return "Палиндром";
}
