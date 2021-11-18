// Задача 13. Удалить вторую цифру трёхзначного числа

Console.WriteLine("Задача 13. Удалить вторую цифру трёхзначного числа.");

int numb = new Random().Next(100, 999);
Console.WriteLine($"Дано число: {numb}");

//Вариант решения через мат.операции
int FirstDigit = numb % 10;
int SecondDigit = (numb % 100 - numb % 10) / 10;
int ThirdDigit = (numb - numb % 100) / 100;

int rezult = ThirdDigit * 10 + FirstDigit;

Console.WriteLine($"Если удалить вторую цифру из данного числа, получим новое число, равное: {rezult}");

// Вариант решения через строки и символы
// string Numb = Convert.ToString(numb);
// char [] mas = Numb.ToCharArray();
// char n1 = mas[0];
// char n2 = mas[2];
// string N = string.Concat(n1,n2);
// int rezult = Convert.ToInt32(N);
// Console.WriteLine($"Если удалить вторую цифру из данного числа, получим новое число, равное: {rezult}");
