// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали
//  (с индексами (0,0); (1;1) и т.д.

int[,] CreateRndMatrix(int rowsCount, int columnsCount) // Создание рандомного двухмерного массива
{
int[,] matrix = new int[rowsCount, columnsCount];
Random rnd = new Random();
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i, j] = rnd.Next(1, 10);
}
}
return matrix;
}

//Функция Печать матрицы
void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}
int[,] matrix = CreateRndMatrix(4, 4);

// Функция ссумирования диагонали
int SumDiag(int[,] matrix)
{
    int sum = 0;
    int minLength = Math.Min(matrix.GetLength(0),matrix.GetLength(1));

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum = sum + matrix[i, i];
    }
    return sum;
}

ShowMatrix(matrix);
int sum = SumDiag(matrix);
System.Console.WriteLine($"Сумма = {sum}");