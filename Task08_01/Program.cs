//Задача 8. Показать числа от -N до M

Console.WriteLine("Задача 8. Показать числа от -N до N");

Console.Write("Введите начало диапазона: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите окончание диапазона: ");
int b = Convert.ToInt32(Console.ReadLine());

if (b < a)
{
    int c = b; 
    b = a; a = c;
}

Console.WriteLine($"Вы задали отрезок [{a},{b}]");
Console.WriteLine($"Числовая последовательность на отрезке [{a},{b}]: ");
int i = a;
while(i<=b)
{
    Console.Write($" {i}");
    i++;
}
Console.WriteLine();
