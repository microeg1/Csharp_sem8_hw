// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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
    static void SortArray(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                for (int x = 0; x < arr.GetLength(1) - 1; x++)
                {
                    if (arr[i,x] < arr[i,x + 1])
                    {
                        int temp = arr[i,x +1];
                        arr[i,x +1] = arr[i,x];
                        arr[i,x] = temp;
                    }
                }
            }
        }
    }
    static void Main(string[] args)
    {
        int[,] array = new int[5,5];

        FillArray(array);
        PrintArray(array);
        Console.WriteLine("Сортированный массив:");
        SortArray(array);
        PrintArray(array);
    }

}