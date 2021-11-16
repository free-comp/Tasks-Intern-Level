// Задача 10. Показать последнюю цифру трёхзначного числа

Console.WriteLine("Задача 10. Показать последнюю цифру трёхзначного числа.");
Console.WriteLine();

Console.Write("Введите трёхзначное число: ");
int numb = Convert.ToInt32(Console.ReadLine());
if (numb < 0)
{
    numb = -1 * numb;
}

if (numb < 100 || numb > 999)
{
    Console.WriteLine("Вы ввели не трёхзначное число. Попробуйте еще раз.");
    Environment.Exit(0);
}
int ost = numb % 10;
Console.WriteLine($"Последняя цифра введенного числа равна: {ost}");