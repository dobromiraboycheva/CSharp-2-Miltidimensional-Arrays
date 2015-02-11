//Problem 7.* Largest area in matrix

//Write a program that finds the largest area of equal neighbour elements in a rectangular matrix and prints its size.
//Example:

//matrix	                        result
//1 	3	    2	    2	    2	    4               //13
//3	    3	    3	    2   	4	    4
//4	    3	    1	    2   	3	    3
//4	    3	    1	    3   	3	    1
//4	    3	    3	    3	    1	    1

//Hint: you can use the algorithm Depth-first search or Breadth-first search.

using System;
using System.Collections.Generic;
using System.Linq;

class LargestAreaInMatrix
{


    //static int n;
    //static int m;
    static int[,] matrix;
    static bool[,] check ;//= new bool[matrix.GetLength(0), matrix.GetLength(1)];
    //static int[,] matrix = {
    //                       { 1, 3, 2, 2, 2, 4},
    //                       { 3, 3, 3, 2, 4, 4},
    //                       { 4, 3, 1, 2, 3, 3},
    //                       { 4, 3, 1, 3, 3, 1},
    //                       { 4, 3, 3, 3, 1, 1}
    //                       };
    static void Main()
    {
        Console.Write("Rows=");
       int n = int.Parse(Console.ReadLine());
        Console.Write("Cols=");
        int m = int.Parse(Console.ReadLine());
        matrix = new int[n, m];
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("matrix[{0},{1}]=", row, col);
                matrix[row, col] = int.Parse(Console.ReadLine());
            }
        }
        check= new bool[matrix.GetLength(0), matrix.GetLength(1)];
        Result();
    }
    static int Search(int row, int col, int value)
    {
        if (row < 0 || col < 0 || row >= matrix.GetLength(0) || col >= matrix.GetLength(1))
        {
            return 0;
        }
        if (check[row, col])
        {
            return 0;
        }
        if (matrix[row, col] != value)
        {
            return 0;
        }
        check[row, col] = true;

        return Search(row, col + 1, value) + Search(row, col - 1, value) +
            Search(row + 1, col, value) + Search(row - 1, col, value) + 1;
    }

    static void Result()
    {
        int result = 0;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                result = Math.Max(result, Search(row, col, matrix[row, col]));
            }
        }
        Console.WriteLine("Result:{0}",result);
    }
}


