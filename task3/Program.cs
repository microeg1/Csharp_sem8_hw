// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
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
    static void MultyplyMatrix(int[,] firstMatrix, int[,] secondMatrix, int[,] resultMatrix)
    {
        for (int i = 0; i < resultMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < resultMatrix.GetLength(1); j++)
            {
                int sum = 0;
                for (int x = 0; x < firstMatrix.GetLength(1); x++)
                {
                    sum +=firstMatrix[i,x] * secondMatrix[x,j];
                }
                resultMatrix[i,j] = sum;
            }
        }
    }
    static void Main(string[] args)
    {
        int[,] matrix1 = new int[2,2];
        int[,] matrix2 = new int[2,2];
        int[,] SumMatrix = new int[2,2];

        FillArray(matrix1);
        Console.WriteLine($"Первая матрица:");
        PrintArray(matrix1);

        FillArray(matrix2);
        Console.WriteLine($"Вторая матрица:");
        PrintArray(matrix2);
        
        MultyplyMatrix(matrix1, matrix2, SumMatrix);
        Console.WriteLine($"Произведение первой и второй матриц:");
        PrintArray(SumMatrix);
        
    }

}