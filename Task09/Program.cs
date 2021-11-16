// Задача 9. Показать четные числа от 1 до N

Console.WriteLine("Задача 9. Показать четные числа от 1 до N");
Console.WriteLine();
Console.Write("Введите положительное число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n <= 0)
{
    Console.WriteLine("Вы ввели отрицательное число или 0. Попробуйте еще раз");
    Environment.Exit(0);
}

Console.WriteLine($"Будем рассматривать отрезок [1,{n}]");

Console.WriteLine($"Четные числа на отрезке [1,{n}]:");
for (int i=2; i<=n; i++)
{
    if(i%2==0)
    {
        Console.Write($" {i}");
    }
}
Console.WriteLine();

// второй вариант для цикла, без условия
// for (int i=2; i<=n; i=i+2)
// {
//     Console.Write($" {i}");
// }


