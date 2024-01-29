// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99]
//  и показывает наибольшую цифру числа.

int num;
int maxDigit = 0;

Console.Write("Введите значение от 10 до 99: ");
num = Convert.ToInt32(Console.ReadLine());

if (num < 10 || num > 99)
{
    Console.WriteLine("Число вне указанного отрезка");
    return;
}

while (num != 0)
{

    int currentDigit = num % 10;
    num = num / 10;

    if (currentDigit > maxDigit)
    {
        maxDigit = currentDigit;
    }
}

Console.WriteLine($"Наибольшая цифра числа: {maxDigit}");