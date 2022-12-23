int number1, number2, number3, max;

Console.Write("Введите первое число: ");
number1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
number2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите третье число: ");
number3 = int.Parse(Console.ReadLine()!);

max = number1;

if (number2 > max)
{
    max = number2;
}

if (number3 > max)
{
    max = number3;
}

Console.Write($"Максимум равен = {max}");
