using System;

class Program
{
    static void PrintReverse(int[] arr, int index)
    {
        if (index >= 0)
        {
            Console.Write($"{arr[index]} ");
            PrintReverse(arr, index - 1);
        }
    }

    static void Main()
    {
        int[] arr = { 1, 2, 5, 0, 10, 34 };
        PrintReverse(arr, arr.Length - 1);
    }
}
