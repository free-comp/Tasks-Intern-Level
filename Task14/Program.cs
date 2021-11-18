// Задача 14. Выяснить, кратно ли число заданному, если нет, вывести остаток.

Console.WriteLine("Задача 14. Выяснить, кратно ли число заданному, если нет, вывести остаток.");

int OriginalNumb = new Random().Next(-1000, 1000);
int CheckNumb = new Random().Next(1, 100);

Console.WriteLine($"Проверим число {OriginalNumb} на кратность числу: {CheckNumb}");

int result = OriginalNumb % CheckNumb;
if (result < 0) result = -1 * result;

if (result == 0)
{
    Console.WriteLine($"Число {CheckNumb} кратно {OriginalNumb}");
}
else
{
    Console.WriteLine($"Число {CheckNumb} не кратно {OriginalNumb}. Остаток деления равен: {result}");
}


