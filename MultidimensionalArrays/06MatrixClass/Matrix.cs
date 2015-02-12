using System;

class Matrix
{
    private int[,] matrix;
    public Matrix(int rows, int cols)
    {
        this.matrix = new int[rows, cols];
    }

    public int Rows
    {
        get
        {
           return this.matrix.GetLength(0);
        }
    }
    public int Cols
    {
        get
        {
            return this.matrix.GetLength(1);
        }
    }

    public int this[int row, int col]
    {
        get
        {
            return this.matrix[row, col];
        }
        set
        {
            this.matrix[row, col] = value;
        }
    }

    //Plus
    public static Matrix operator +(Matrix first, Matrix second)
    {
        Matrix result = new Matrix(first.Rows,first.Cols);
        for (int row = 0; row < first.Rows; row++)
        {
            for (int col = 0; col < first.Cols; col++)
            {
                result[row,col] = first[row, col] + second[row, col];
            }
        }
        return result;
    }
   
    //Minuse
    public static Matrix operator -(Matrix first, Matrix second)
    {
        Matrix result = new Matrix(first.Rows, first.Cols);

        for (int row = 0; row < first.Rows; row++)
        {
            for (int col = 0; col < first.Cols; col++)
            {
                result[row, col] = first[row, col] - second[row, col];
            }
        }
        return result;
    }

    //Multiply
    public static Matrix operator *(Matrix first, Matrix second)
    {
        Matrix result = new Matrix(first.Rows, first.Cols);

        for (int row = 0; row < first.Rows; row++)
        {
            for (int col = 0; col < first.Cols; col++)
            {
                for (int k = 0; k < first.Cols; k++) 
                {
                    result[row, col] += first[row, col] * second[row, col];
                }
            }
        }
        return result;
    }

    //ToString
    public override string ToString()
    {
        string result = null;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                result+= matrix[row, col]+" ";
            }
            result += Environment.NewLine;
        }
        return result;
    }
}

