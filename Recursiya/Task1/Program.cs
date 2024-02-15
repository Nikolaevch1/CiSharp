void OpenMatrsyoshka(int size)
{
    // Базовый случай: самая маленькая матрешка
    if (size == 1)
    {
        return;
    }
OpenMatrsyoshka(size - 1);
System.Console.WriteLine($"Opening matryoshka of size {size} ...");
}

OpenMatrsyoshka(5);

void OpenMatrsyoshka(int size)
{
    // Базовый случай: самая маленькая матрешка
    if (size == 1)
    {
        return;
    }
System.Console.WriteLine($"Opening matryoshka of size {size} ...");
OpenMatrsyoshka(size - 1);
}

OpenMatrsyoshka(5);



void ShowMessage(string msg)
{
    System.Console.WriteLine(msg);
}
ShowMessage("Hello");
Console.WriteLine("World");