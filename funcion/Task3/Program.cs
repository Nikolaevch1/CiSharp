// void Foo (int a)
// {
//     System.Console.Write(a);
// }
// int value = 5;
// Foo (value);

// void Bar (int a)
// {
//     a = 0;
// }
// int value = 5;
// Bar(value);
// System.Console.WriteLine(value);

void ZeroEvenElement(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            arr[i] = 0;
        }
    }
}
void PrintArry(int[] arr)
{
    foreach (int e in arr)
    {
        Console.Write($"{e} ");
    }
}

int[] array = { 1, 2, 3, 4, 5 };
ZeroEvenElement(array);
PrintArry(array);