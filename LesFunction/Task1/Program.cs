// Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

using System;

class Program {
static void Main() {
// Инициализация массива
int[] arr = GetRandomArray(10);

    // Вызов функции для подсчета четных чисел
    Console.WriteLine($"Количество четных чисел: {CountEvenNumbers(arr)}");
}

// Функция для генерации случайного массива чисел
static int[] GetRandomArray(int size) {
    Random random = new Random();
    int[] result = new int[size];

    for (int i = 0; i < size; i++) {
        result[i] = random.Next(100);
    }

    return result;
}

// Функция для подсчета четных чисел в массиве
static int CountEvenNumbers(int[] arr) {
    int count = 0;
    foreach (var number in arr) {
        if (number % 2 == 0) {
            count++;
        }
    }
    return count;
}
}