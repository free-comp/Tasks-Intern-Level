// Задача 4. По заданному номеру дня недели вывести его название


Console.Write("Введите число от 1 до 7: ");
int Numb = Convert.ToInt16(Console.ReadLine());
switch (Numb)
{
    case 1:
        Console.WriteLine("Первый день недели понедельник");
        break;
    case 2:
        Console.WriteLine("Второй день недели вторник");
        break;
    case 3:
        Console.WriteLine("Третий день недели седа");
        break;
    case 4:
        Console.WriteLine("Четвертый день недели четверг");
        break;
    case 5:
        Console.WriteLine("Пятый день недели пятница");
        break;
    case 6:
        Console.WriteLine("Шестой день недели суббота");
        break;
    case 7:
        Console.WriteLine("Седьмой день недели воскресенье");
        break;
    default:
        Console.WriteLine("Вы ввели число, не соответствующее диапазону от 1 до 7");
        break;
}