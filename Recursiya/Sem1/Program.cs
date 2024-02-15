using System;

class Program
{
    static int GetSumOfDigits(int number)
    {
        if (number == 0)
        {
            return 0;
        }
        else
        {
            return number % 10 + GetSumOfDigits(number / 10);
        }
    }

    static void Main()
    {
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine()!);

        int sumOfDigits = GetSumOfDigits(number);
        Console.WriteLine("Сумма цифр числа: " + sumOfDigits);
    }
}