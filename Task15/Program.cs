// Задача 15. Найти третью цифру числа или сообщить, что её нет.

Console.WriteLine("Задача 15. Найти третью цифру числа или сообщить, что её нет");

int numb = new Random().Next(-300, 300);
Console.WriteLine($"Дано число: {numb}");
if (numb < 0) numb = -1 * numb;

numb = numb % 1000;
if (numb < 100)
{
    Console.WriteLine("В числе нет третьей цифры");
}
else
{
    int ThirdDigit = (numb - numb % 100) / 100;
    Console.WriteLine($"Третья цифра числа равна {ThirdDigit}");
}


