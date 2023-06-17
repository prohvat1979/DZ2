// Принять на вход трехзначное число и вывести вторую цифру этого числа.

Console.Write("Введите трёхзначное число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

if (numberA < 100 || numberA > 999)
{
    Console.WriteLine("Введённое число не трёхзначное!");
}
else
{
    int numberB = numberA / 10 % 10;
    Console.WriteLine($"Вторая цифра введённого числа: {numberB}");
}
