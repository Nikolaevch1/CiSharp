// Random rnd = new Random();

// int size = 1000;
// int[] arr_int = new int[size];
// int i = 0;
// while(i < size)
// {
//     arr_int[i] = rnd.Next(1, 10);
// //     i = i + 1;
// // }

// // i = 0;
// // while(i < size)
// // {
// //     System.Console.Write($"{arr_int[i]} ");
// //     i = i + 1;
// // }

//                      Заполнеие с клавиатуры

int size = 10;
int[] arr_int = new int[size];
int i = 0;
while(i < size)
{
    System.Console.WriteLine("Введите целое число: ");
    string input = Console.ReadLine();
    arr_int[i] = Convert.ToInt32(input);
    i = i + 1;
}

i = 0;
while(i < size)
{
    System.Console.Write($"{arr_int[i]} ");
    i = i + 1;
}

int GetArrayFromConsole() // Функция ручнного ввода размера и элементов массива
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


