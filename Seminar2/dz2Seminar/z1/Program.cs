﻿// Задача 1: Напишите программу,
//  которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23

// 50
// 7
// 322

Console.WriteLine("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());

if (number % 7 == 0 && number % 23 == 0)

{
    Console.WriteLine($"Число {number} кратно 7 и 23.");
}

else
{
    Console.WriteLine($"Число {number} не кратно 7 и 23.");
}