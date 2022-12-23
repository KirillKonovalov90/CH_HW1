int number;

Console.Write("Введите число: ");
number = int.Parse(Console.ReadLine()!);

if (number % 2 == 0)
{
    Console.Write("Число чётное");
}
else
{
    Console.Write("Число нечётное");
}
