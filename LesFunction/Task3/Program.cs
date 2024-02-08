// Задача 3: Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReverseArray
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random rndGen = new Random();
            int[] inputArray = Enumerable.Range(1, 10).Select(i => rndGen.Next(0, 20)).ToArray();
            
            ReverseArray reverseArray = new ReverseArray();
            inputArray = reverseArray.Reverse(inputArray);
            

            foreach (int i in inputArray)
            {
                Console.Write($"{i} "!);
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }

    internal class ReverseArray
    {
        public int[] Reverse(int[] input)
        {
            List<int> list = new List<int>(input);
            list.Reverse();
            return list.ToArray();
        }
    }
}