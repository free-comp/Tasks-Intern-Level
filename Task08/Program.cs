//Задача 8. Показать числа от -N до N

Console.WriteLine("Задача 8. Показать числа от -N до N");

// Console.Write("Введите начало диапазона: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите окончание диапазона: ");
// int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
int b=-1*a;;

if (b < a)
{
    int c = b; 
    b = a; a = c;
}

Console.WriteLine($"Будем рассматривать отрезок [{a},{b}]");
Console.WriteLine($"Числовая последовательность на отрезке [{a},{b}]: ");
int i = a;
while(i<=b)
{
    Console.Write($" {i}");
    i++;
}
Console.WriteLine();