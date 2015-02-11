//Problem 1. Fill the matrix

//Write a program that fills and prints a matrix of size (n, n) as shown below:
//Example for n=4:

//a)
//1	    5	    9	    13
//2	    6	    10	    14
//3	    7	    11	    15
//4 	8	    12	    16
//b)
//1 	8	    9	    16
//2	    7	    10	    15
//3 	6	    11      14
//4 	5	    12	    13
//c)
//7	    11	    14	    16
//4 	8	    12	    15
//2 	5	    9	    13
//1 	3	    6	    10
//d)*
//1	    12	    11	    10
//2 	13	    16	    9
//3	    14	    15  	8
//4 	5	    6	    7

using System;
using System.Collections.Generic;
using System.Linq;



class FillTheMatrix
{
    static void Main()
    {
        Console.WriteLine("n=");
        int n = int.Parse(Console.ReadLine());
        //int n = 4;
        int[,] matrixA = new int[n, n];
        int[,] matrixB = new int[n, n];
        int[,] matrixC = new int[n, n];
        int[,] matrixD = new int[n, n];
        for (int row = 0; row < matrixA.GetLength(0); row++)
        {
            for (int col = 0; col < matrixA.GetLength(1); col++)
            {
                //A
                matrixA[row, col] = row + col * n + 1;
                //B
                if (col % 2 == 0)
                {
                    matrixB[row, col] = row + col * n + 1;
                }
                else
                {
                    matrixB[row, col] = col * n + n - row;
                }
            }
        }
        //C
        int value = 1;
        for (int row = matrixC.GetLength(0) - 1; row >= 0; row--)
        {
            int rows = row;
            int cols = 0;
            while (rows < matrixC.GetLength(0) && cols < matrixC.GetLength(1))
            {
                matrixC[rows++, cols++] = value++;
            }
        }
        for (int col = 1; col < matrixA.GetLength(1); col++)
        {
            int rows = 0;
            int cols = col;
            while (rows < matrixC.GetLength(0) && cols < matrixC.GetLength(1))
            {
                matrixC[rows++, cols++] = value++;
            }
        }
        //D
        int number = 1;
        if (number >= matrixD.GetLength(0) * matrixD.GetLength(1))
        {
            return;
        }
        else
        {
            int row = 0;
            int col = 0;
            // down
            while (matrixD[row, col] == 0)
            {
                while (row < matrixD.GetLength(0) && matrixD[row, col] == 0)
                {
                    matrixD[row, col] = number;
                    row++;
                    number++;
                }
                row--;
                col++;
                // right
                while ((col < matrixD.GetLength(1)) && (matrixD[row, col] == 0))
                {
                    matrixD[row, col] = number;
                    col++;
                    number++;
                }
                col--;
                row--;
                // up
                while ((row >= 0) && (matrixD[row, col] == 0))
                {
                    matrixD[row, col] = number;
                    row--;
                    number++;
                }
                row++;
                col--;
                // left
                while ((col >= 0) && (matrixD[row, col] == 0))
                {
                    matrixD[row, col] = number;
                    col--;
                    number++;
                }
                col++;
                row++;
            }
        }
        //Output
        Console.WriteLine("Matrix A");
        for (int row = 0; row < matrixA.GetLength(0); row++)
        {
            for (int col = 0; col < matrixA.GetLength(1); col++)
            {
                Console.Write("{0,-4}", matrixA[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("Matrix B");
        for (int row = 0; row < matrixB.GetLength(0); row++)
        {
            for (int col = 0; col < matrixB.GetLength(1); col++)
            {
                Console.Write("{0,-4}", matrixB[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("Matrix C");
        for (int row = 0; row < matrixC.GetLength(0); row++)
        {
            for (int col = 0; col < matrixC.GetLength(1); col++)
            {
                Console.Write("{0,-4}", matrixC[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("Matrix D");
        for (int row = 0; row < matrixD.GetLength(0); row++)
        {
            for (int col = 0; col < matrixD.GetLength(1); col++)
            {
                Console.Write("{0,-4}", matrixD[row, col]);
            }
            Console.WriteLine();
        }
    }
}
