// Семинар 4. Функции
// 20 мин
// Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем.
// Пример
// [1 3 2 4 2 3] => 132423
// [2 3 1] => 231

int[] GetRandomArrayFromConcole() // Фукция рандомного массива
{
    Console.Write("add Size <= 8: ");
    int size = int.Parse(Console.ReadLine()!);
    int[] array = new int[size];

    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 10);
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

int ConvertDigToInt(int[] array) // Деление каждого числа массива
{
    int res = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int tmpResult = array[i] * (int)Math.Pow(10, array.Length - i - 1);
        System.Console.WriteLine($"{tmpResult} ");
        res += tmpResult;
    }

    return res;
}   

int[] array = GetRandomArrayFromConcole();
PrintArray(array);
System.Console.WriteLine($" результат: {ConvertDigToInt(array)}");