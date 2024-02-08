﻿// Задание 1. Совместная работа
// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.

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
ShowMatrix(matrix);
System.Console.WriteLine();
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
if (i % 2 == 0 && j % 2 == 0 && i == j)
{
matrix[i, j] = matrix[i, j] * matrix[i, j];
}
}
}

ShowMatrix(matrix);