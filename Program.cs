// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого четная

Console.WriteLine("Добро пожаловать в программу! Введеите двухзначное число: ");
while (true)
{
    string input = Console.ReadLine()!;
    if (input == "q") break;
    else if (!int.TryParse(input, out int number))
        Console.WriteLine($"Некорректный ввод: {input}");
    else
    {
        int sum = 0;
        for (int i = number; i > 0; i /= 10)
            sum += i % 10;

        if (sum % 2 == 0)
            Console.WriteLine($"Введенное число: {number} имеет четную сумму цифр, конец программы!");
            if (sum % 2 == 0)
            {
                break;
            }
        else
            Console.WriteLine($"Введенное число: {number} имеет нечетную сумму цифр");
    }
}

