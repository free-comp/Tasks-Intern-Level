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
string FirstA = Console.ReadLine();
Console.WriteLine("Введите второе число: ");
string FirstB = Console.ReadLine();

// double a = Convert.ToDouble(FirstA);
// double b = Convert.ToDouble(FirstB);

double A = Max(Convert.ToDouble(FirstA), Convert.ToDouble(FirstB));
double B = Min(Convert.ToDouble(FirstA), Convert.ToDouble(FirstB));

Console.WriteLine($"Наибольшее число равно: {A}");
Console.WriteLine($"Наименьшее число равно: {B}");