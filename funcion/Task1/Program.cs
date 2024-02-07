int n = 5;

int i = 1;
while (i <= n)
{
    System.Console.WriteLine($"{i * i} ");
    i = i + 1:
}

n = 10;
i = 1;
while (i <= n)
{
    System.Console.WriteLine($"{i * i} ");
    i = i + 1:
}

n = 15;
i = 1;
while (i <= n)
{
    System.Console.WriteLine($"{i * i} ");
    i = i + 1:
}

// функция возведения в степень
int Square (int value)
{
    int result = value * value;
    return result;
}

// функция перемножения
int Mutiply (int value1, int value2)
{
    int result = value1 * value2;
    return result;
}

// Тип возрощаемого значения
void ShowSquare (int value)
{
    int result = value * value;
System.Console.WriteLine(result);
}

// Функции без параметров
// без параметров, бeз возвращаемого значения
void ShowHellMassage ()
{
System.Console.WriteLine("Hello Word!");
}

// без параметров, c возвращаемым значением
double GetPi()
{
    return 3.14159;
}

// Функции с папрметрами
// с параметрами, бeз возвращаемого значения
void ShowHellMassage (string message)
{
System.Console.WriteLine(message);
}

// с параметрами, c возвращаемым значением
int AddValues(int a, int b)
{
    int result = a + b;
    return result;
}