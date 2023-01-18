/*
Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3 -> Среда
5 -> Пятница
*/

int measurement;

Console.WriteLine("Введите номер дня недели: ");
string? measurement_tmp = Console.ReadLine();

Console.WriteLine(int.TryParse(measurement_tmp, out measurement));

switch (measurement)
{
    case 1:
        Console.WriteLine($"{measurement} = Понедельник");
        break;
    case 2:
        Console.WriteLine($"{measurement} = Вторник");
        break;
    case 3:
        Console.WriteLine($"{measurement} = Среда");
        break;
    case 4:
        Console.WriteLine($"{measurement} = Четверг");
        break;
    case 5:
        Console.WriteLine($"{measurement} = Пятница");
        break;
    case 6:
        Console.WriteLine($"{measurement} = Суббота");
        break;
    case 7:
        Console.WriteLine($"{measurement} = Воскресенье");
        break;

    default:
        Console.WriteLine($"{measurement} = неправильное значение");
        break;

}
