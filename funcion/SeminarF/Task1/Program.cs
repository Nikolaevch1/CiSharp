// int MyFunction(int a, int b, int c)
// {
//     int res = a * b * c;
//     return res;
// }

// int Add(int a, int b, int c)
// {
//     int res = a + b + c;
//     return res;
// }
// int res = MyFunction(5, 6, 7);

// System.Console.WriteLine(MyFunction(5, 6, 7));
// System.Console.WriteLine(res);

// System.Console.WriteLine(Add(1, 2, 3));

//          Задание 1. Совместная работа
// Семинар 4. Функции
// 20 мин
// Задайте одномерный массив, заполненный случайными
// числами. Определите количество простых чисел в этом
// массиве.
// Примеры
// [1 3 4 19 3] => 2
// [4 3 4 1 9 5 21 13] => 3

bool IsPrime(int number)
{
    for (int i = 2; i < number; i++)
    {
        if (number % i == 0)
            return false;
    }
    return true;
}

int[] GetRandomArray(int size, int minValue, int maxValue) // Фукция рандомного массива
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue + 1);
    }
    return array;
}
// int[] GetRandomArray(int size, int minValue = 1, int maxValue = 99) // Установка минимальных и максимальных значений

int[] GetArrayFromConsole() // Функция ручнного ввода размера и элементов массива
{
    Console.Write("add Size: ");
    int size = int.Parse(Console.ReadLine()!);
    int[] array = new int[size];

    Console.WriteLine($"Enter {size} element:  ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = int.Parse(Console.ReadLine()!);
    }
    return array;
}

void PrintArray(int[] array) // Функция вывода 
{
    Console.Write("[");
    foreach (int number in array)
    {
        Console.Write(number + " ");
    }
    Console.WriteLine("]");
}

int CountPrimeNumbers(int[] array) // Функция определение простых чисел в массиве
{
    int count = 0;

    foreach (var elem in array)
    {
        if (IsPrime(elem))
        {
            count++;
        }
    }
    return count;
}


int[] array = GetRandomArray(6, 1, 99);
PrintArray(array);

int[] array2 = GetArrayFromConsole();
PrintArray(array2);

System.Console.WriteLine($"Количество простых чисел:  {CountPrimeNumbers(array)}");
System.Console.WriteLine($"Количество простых чисел:  {CountPrimeNumbers(array2)}");