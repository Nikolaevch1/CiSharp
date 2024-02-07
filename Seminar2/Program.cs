
// Задание 1. Совместная работа
// Напишите программу, которая принимает на вход трёхзначное число и удаляет вторую цифру этого числа.
int a = 891;
int b = (a / 100 * 10) + a % 10;
Console.WriteLine(b);

//  Задание 2. Работа в сессионных залах
// Напишите программу, которая принимает на вход трёхзначное число и возводит
// вторую цифру этого числа в степень, равную третьей цифре.

int a1 = 487;
int b1 = (a1 / 10 % 10);
int c1 = (a1 % 10);
Console.WriteLine(Math.Pow(b1, c1)); // Math.Pow возведение в степень первую переменную, второй переменой


//Напишите программу, которая будет принимать на вход два числа и выводить, 
//является ли второе число кратным первому. Если второе число некратно первому, 
// то программа выводит остаток от деления.

int num1 = 14;
int num2 = 5;
int delenie = num1 % num2;
if (delenie == 0)
{
    Console.WriteLine("да");
}
else
{
    Console.Write("нет, ");
    Console.WriteLine(delenie);
}

Console.WriteLine($"нет, {delenie}");



// .WriteLineConsole("Введите строку для преобразования в число:");

// int result;

// bool isParse = int.TryParse(Console.ReadLine()!, out result);

// if (isParse)
// {
//     Console.WriteLine($"Успешно. {result}");
// }
// else
// {
//     Console.WriteLine("Попробуйте заного...");
// }

// Напишите программу, которая выводит третью с конца цифру заданного числа или сообщает, что третьей цифры нет.

int nums = 12;
int number = nums / 100;
if (nums/ 100 !=0)
{
    System.Console.WriteLine(number % 10);
}
else
{
    System.Console.WriteLine("Третьей цифры нет");
}