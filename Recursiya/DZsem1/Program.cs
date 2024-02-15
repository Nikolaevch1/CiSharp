void PrintRange(int n, int m = 1)
{
    if (m > n)
    {
        Console.WriteLine();
        return;
    }
    
    Console.Write($"{m} ");

    PrintRange(n, m+1);
}

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);

PrintRange(n);