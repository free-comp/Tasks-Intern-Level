// Найти максимальное из трех чисел
int Max(int x1, int x2, int x3)
{
    int result = x1;
    if (x2 > result) result = x2;
    if (x3 > result) result = x3;
    return result;
}

int a = new Random().Next(-1000, 1000);
int b = new Random().Next(-1000, 1000);
int c = new Random().Next(-1000, 1000);
Console.WriteLine($" Даны числа: {a}, {b}, {c}");

int max = Max(a, b, c);

Console.WriteLine($"Максимальное из трех чисел: {max}");
