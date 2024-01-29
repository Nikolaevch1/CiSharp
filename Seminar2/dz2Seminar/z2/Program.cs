// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.


Console.Write("Введите значение X: ");
double x = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение Y: ");
double y = Convert.ToDouble(Console.ReadLine());

if (x != 0 && y != 0)
{
    if (x > 0 && y > 0)
    {
        Console.WriteLine("I четверть");
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine("II четверть");
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine("III четверть");
    }
    else
    {
        Console.WriteLine("IV четверть");
    }
}
else
{
    Console.WriteLine("Ошибка: Координаты не могут быть равны нулю.");
}
