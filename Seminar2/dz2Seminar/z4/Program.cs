// Задача 4: Напишите программу, которая на вход принимает натуральное число N,
//  а на выходе показывает его цифры через запятую.


Console.WriteLine("Введите любое положительное число:");
int number = Convert.ToInt32(Console.ReadLine());
string result = number.ToString();
foreach (char c in result)
{
    Console.Write(c);
    Console.Write(", ");
}
Console.ReadKey();
