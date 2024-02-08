int[,] GreateMatrix(
    int rowsCount, int columnsCount) // Функция создания двумерного массива
{
    int[,] matrix = new int[rowsCount, columnsCount];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 11);
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

int[,] matrix = GreateMatrix(4, 5);

ShowMatrix(matrix);
