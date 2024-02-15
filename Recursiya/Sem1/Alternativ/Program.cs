// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// Использовать рекурсию.
// Пример 123 => 6; 63 => 9


// int GetSumOfDigits(int number)
// {
//     number = Math.Abs(number);
//     if (number == 0)
//     {
//         return 0;
//     }
//     else
//     {
//         return number % 10 + GetSumOfDigits(number / 10);
//     }
// }

// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);

// int sumOfDigits = GetSumOfDigits(number);
// Console.WriteLine("Сумма цифр числа: " + sumOfDigits);

// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// N=5 => 1 2 3 4 5


void PrintNumbers(int end)
{
    for (int i = 1; i <= end; i++)
    {
        Console.Write($"{i} ");
    }
}

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

PrintNumbers(N);



// Считать строку с консоли, содержащую латинские буквы. Вывести на экран согласные буквы этой строки.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// “hello” => h l l
// “World” => W r l d
// “Hello world!” => H l l w r l d
 