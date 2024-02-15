class Program
{
    static int Ackermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (m > 0 && n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }

    static void Main(string[] args)
    {
        int m = 2;
        int n = 3;
        int result = Ackermann(m, n);
        Console.WriteLine("Результат функции Аккермана для m = {0} и n = {1}: {2}", m, n, result);
    }
}