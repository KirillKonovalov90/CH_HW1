int number1, number2;

Console.Write("Введите первое число: ");
number1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
number2 = int.Parse(Console.ReadLine()!);

if (number1 > number2)
{
    Console.Write($"Максимальное число = {number1}");
}
else
{
    Console.Write($"Максимальное число = {number2}");
}
