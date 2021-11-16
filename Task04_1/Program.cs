// Задача 4. По заданному номеру месяца вывести его название


Console.Write("Введите число от 1 до 12: ");
int Numb = Convert.ToInt16(Console.ReadLine());
switch (Numb)
{
    case 1:
        Console.WriteLine("Первый месяц года январь");
        break;
    case 2:
        Console.WriteLine("Второй месяц года февраль");
        break;
    case 3:
        Console.WriteLine("Третий месяц года март");
        break;
    case 4:
        Console.WriteLine("Четвертый месяц года апрель");
        break;
    case 5:
        Console.WriteLine("Пятый месяц года май");
        break;
    case 6:
        Console.WriteLine("Шестой месяц года июнь");
        break;
    case 7:
        Console.WriteLine("Седьмой месяц года июль");
        break;
    case 8:
        Console.WriteLine("Восьмой месяц года август");
        break;
    case 9:
        Console.WriteLine("Девятый месяц года сентябрь");
        break;
    case 10:
        Console.WriteLine("Десятый месяц года октябрь");
        break;
    case 11:
        Console.WriteLine("Одиннадцатный месяц года ноябрь");
        break;
    case 12:
        Console.WriteLine("Двенадцатый месяц года декабрь");
        break;
    default:
        Console.WriteLine("Вы ввели число, не соответствующее диапазону от 1 до 12");
        break;
}
