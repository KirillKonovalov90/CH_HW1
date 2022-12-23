int N, i;

Console.Write("Введите число N: ");
N = int.Parse(Console.ReadLine()!);

// тут, конечно, явно не общий случай, а только при условии подсчёта чётных от 1

i = 2; 

while (i <= N)
{
    Console.Write($"{i} ");
    i += 2;
}