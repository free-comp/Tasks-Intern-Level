// Задача 12. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

Console.WriteLine("Задача 12. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа.");

int numb = new Random().Next(10, 99);
Console.WriteLine($"Дано число: {numb}");

int FirstDigit = numb % 10;
int SecondDigit = (numb - FirstDigit) / 10;

int max = FirstDigit;
if (SecondDigit > max) max = SecondDigit;

Console.WriteLine($"Наибольшая цифра в числе равна: {max}");
