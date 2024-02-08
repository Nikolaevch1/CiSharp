int[,] GreateMatrix(int rowsCount, int columnsCount) // Функция создания двумерного массива
{
    int[,] matrix = new int[rowsCount, columnsCount];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 1000);
        }
    }
    return matrix;
}

void ShowMatrix(int[,] matrix) // Функция ввывода матицы
{
    for (int i = 0; i < matrix.GetLength(0); i++) // интерплояция строк
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}


int[,] matrix = GreateMatrix(3, 4);
ShowMatrix(matrix);
System.Console.WriteLine();

foreach (int element in matrix) // Проход по элементам массива ...
{
    if(IsInteresting(element) == true)
    {
        Console.Write($"{element}");
    }
}

bool IsInteresting(int value) // Сообщает интересен нам элемент или нет;
{
    int sumOfDigits = GetSumOfDigits(value);
    if (sumOfDigits % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

int GetSumOfDigits(int value) // подсчет целых чисел
{
    int sum = 0;
    while (value > 0)
    {
        sum += value % 10;
        value /= 10;
    }
    return sum;
}


