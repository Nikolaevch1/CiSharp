using System;

class Program
{
static void Main()
{
int M = 1;
int N = 5;

    PrintNumbers(M, N);
}

static void PrintNumbers(int m, int n)
{
    if (m == n)
    {
        Console.WriteLine(m);
        return;
    }

    Console.Write($"{m} ");
    PrintNumbers(m + 1, n);
}
}