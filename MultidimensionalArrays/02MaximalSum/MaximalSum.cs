//Problem 2. Maximal sum

//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

using System;
using System.Collections.Generic;
using System.Linq;

class MaximalSum
{
    static void Main()
    {
        Console.Write("Enter how many rows of matrix ROWS=");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter how many cols of matrix COLS=");
        int m = int.Parse(Console.ReadLine());
        if (n < 3 || m < 3)
        {
            Console.WriteLine("ERROR:Your matrix must be with more then 2 rows and cols!");
        }
        else
        {
            //Input matrix
            int[,] matrix = new int[n, m];
            //int[,] matrix = new int[,]
            //{
            //    {1,2,3,4,5},
            //    {2,3,4,5,6},
            //    {3,4,5,6,7},
            //    {4,5,6,7,8},
            //    {5,6,7,8,9}
            //};
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("matrix[{0},{1}]=", row, col);
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }
            //Search best sum
            int bestSum = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    bestSum += matrix[i, j];
                }

            }
            int startIndexRow = 0;
            int StartIndexCol = 0;
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                int currentSum = 0;
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            currentSum += matrix[row + i, col + j];
                        }
                    }
                    if (currentSum > bestSum)
                    {
                        bestSum = currentSum;
                        startIndexRow = row;
                        StartIndexCol = col;
                    }
                    currentSum = 0;
                }
            }
            //Output matrix
            Console.WriteLine("Matrix:");
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0,-4}", matrix[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            //Output mini matrix with best sum
            Console.WriteLine("Element with best sum: ");
            for (int row = startIndexRow; row < startIndexRow + 3; row++)
            {
                for (int col = StartIndexCol; col < StartIndexCol + 3; col++)
                {
                    Console.Write("{0,-4}", matrix[row, col]);
                }
                Console.WriteLine();
            }
            //Output best sum
            Console.WriteLine("Best sum={0}", bestSum);
        }
    }
}

