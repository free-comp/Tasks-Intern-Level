// Задача 7. Выяснить является ли число чётным

Console.Write("Введите целое число: ");
int numb = Convert.ToInt32(Console.ReadLine());


if (numb % 2 == 0)
{
    Console.WriteLine("Введенное число четное");
}
else
{
    Console.WriteLine("Введенное число нечетное");
}
