﻿// Задача 1. Вывести квдрат числа

int Square (int x)
{
    int result =  x*x;
    return result;
}

Console.WriteLine("Введите число");
string Number = Console.ReadLine();
//int numb = Convert.ToInt32(Number);


int numb = Square(Convert.ToInt32(Number)); 

Console.WriteLine($"Квадрат введенного числа равен: {numb}");

