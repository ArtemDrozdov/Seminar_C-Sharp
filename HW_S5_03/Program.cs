/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
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

Console.WriteLine(  "Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.\n" +
                    "Введите длину массива");
int array_length = InputIntNumber("Length Number");

double[] array = new double[array_length];
Random rnd = new Random();

int minDiv = 2;                                 // начальное значение, обязательно > 1
int maxDiv = 10;                                // максимум рандома
double lowerRange = 1.5;                        // нижняя граница генерации 
double upperRange = 3.5;                        // верхняя граница генерации 
double max_numb = lowerRange;
double min_numb = upperRange;                            

for (int i = 0; i < array.Length; i++)
{   // наполнение массива случайными числами
    array[i] = ((double) 1 / rnd.Next(minDiv, maxDiv)) * (upperRange - lowerRange) + lowerRange;
    
    // нахождение минимума и максимума
    if (max_numb < array[i]) max_numb = array[i];
    if (min_numb > array[i]) min_numb = array[i];
    
    // вывод массива
    if (i == 0) {
        Console.WriteLine("Массив:");
        Console.Write(array[i]);
        }
    else
        Console.Write("; " + array[i]);
}

Console.WriteLine();
Console.Write($"min_numb = {min_numb}; ");
Console.WriteLine($"max_numb = {max_numb}; ");
double difference = max_numb - min_numb;
Console.WriteLine("max_numb - min_numb = " + difference);

