// Задача 3. Даны два числа. Показать большее и меньшее число

double Max(double x1, double x2)
{
    double result = x1;
    if (x2 > x1) result = x2;
    return result;
}
double Min(double x1, double x2)
{
    double result = x1;
    if (x2 < x1) result = x2;
    return result;
}

Console.WriteLine("Введите первое число: ");
double FirstA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
double FirstB = Convert.ToDouble(Console.ReadLine());

double A = Max(FirstA, FirstB);
double B = Min(FirstA, FirstB);

Console.WriteLine($"Наибольшее число равно: {A}");
Console.WriteLine($"Наименьшее число равно: {B}");