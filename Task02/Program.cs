// Задача 2. По двум заданным числам проверять является ли первое квадратом второго

Console.WriteLine("Введите первое число ");
string FirstNumber = Console.ReadLine();
Console.WriteLine("Введите второе число ");
string SecondNumber = Console.ReadLine();

int FirstNumb = Convert.ToInt32(FirstNumber);
int SecondNumb = Convert.ToInt32(SecondNumber);

if (FirstNumb == (SecondNumb * SecondNumb))
{
    Console.WriteLine($"Число {FirstNumb} является квадратом числа {SecondNumb}");
}
else
{
    Console.WriteLine($"Число {FirstNumb} не является квадратом числа {SecondNumb}");
}