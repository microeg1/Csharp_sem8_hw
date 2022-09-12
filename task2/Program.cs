// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
using System;


class Program
{
    static void FillArray(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i,j] = new Random().Next(1,10);
            }
        }
    }
    static void PrintArray(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"{arr[i,j]} ");
            }
            Console.WriteLine();
        }
    }
    static int RowNum(int[,] arr)
    {
        int row = 0;
        int minsum = 0;
        for (int i = 0; i < arr.GetLength(1); i++)
        {
            minsum += arr[0, i];
        }
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                sum +=arr[i,j];
            }
            if (minsum > sum)
            {
                minsum = sum;
                row = i;
            }
        }
        return row;
    }
    static void Main(string[] args)
    {
        int[,] array = new int[5,5];

        FillArray(array);
        PrintArray(array);
        Console.WriteLine($"Строкой с наименьшей суммой элементов является строка под номером {RowNum(array)+1}");
    }

}