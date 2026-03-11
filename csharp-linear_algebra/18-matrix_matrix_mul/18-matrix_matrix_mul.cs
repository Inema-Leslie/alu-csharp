using System;

public class MatrixMath
{
    /// <summary>
    /// Multiplies two matrices and returns the resulting matrix
    /// </summary>
    /// <param name="matrix1">First matrix as a 2D double array</param>
    /// <param name="matrix2">Second matrix as a 2D double array</param>
    /// <returns>The product matrix, or a matrix containing -1 if invalid</returns>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        // Check if either matrix is null
        if (matrix1 == null || matrix2 == null)
            return new double[,] { { -1 } };
        
        // Get matrix dimensions
        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int rows2 = matrix2.GetLength(0);
        int cols2 = matrix2.GetLength(1);
        
        // Check if matrices can be multiplied (columns of first must equal rows of second)
        if (cols1 != rows2)
            return new double[,] { { -1 } };
        
        // Check if matrices have at least one dimension
        if (rows1 == 0 || cols1 == 0 || rows2 == 0 || cols2 == 0)
            return new double[,] { { -1 } };
        
        // Create result matrix with dimensions rows1 x cols2
        double[,] result = new double[rows1, cols2];
        
        // Perform matrix multiplication
        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                double sum = 0;
                for (int k = 0; k < cols1; k++)
                {
                    sum += matrix1[i, k] * matrix2[k, j];
                }
                result[i, j] = sum;
            }
        }
        
        return result;
    }
}