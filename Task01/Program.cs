// Задача 1. Вывести квдрат числа

double Square (double x)
{
    double result =  x*x;
    return result;
}

Console.WriteLine("Введите число");
string Number = Console.ReadLine();
//int numb = Convert.ToInt32(Number);

double numb = Square(Convert.ToDouble(Number)); 

Console.WriteLine($"Квадрат введенного числа равен: {numb}");