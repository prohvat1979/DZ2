// Принять на ввод число и вывести третью цифру этого числа либо сообщить что третьей цифры нет.

Console.Write("Введите число: ");
string? input = Console.ReadLine();

if (string.IsNullOrEmpty(input))
{
    Console.Error.WriteLine("Ничего не введено.");
    return;
}

for (int i = 0; i < input.Length; i++)
{
    if (!char.IsDigit(input[i]))
    {
        Console.Error.WriteLine("Введено не число.");
        return;
    }
}

if (input.Length < 3)
{
    Console.WriteLine("Третьей цифры нет.");
}
else
{
    Console.WriteLine($"Третья цифра: {input[2]}");
}
