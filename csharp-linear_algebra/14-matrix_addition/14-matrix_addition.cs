using System;

public class MatrixMath
{
    /// <summary>
    /// Adds two matrices and returns the resulting matrix
    /// </summary>
    /// <param name="matrix1">First matrix as a 2D double array</param>
    /// <param name="matrix2">Second matrix as a 2D double array</param>
    /// <returns>The sum matrix, or a matrix containing -1 if invalid</returns>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        // Check if either matrix is null
        if (matrix1 == null || matrix2 == null)
            return new double[,] { { -1 } };
        
        // Check if matrices are square (2D or 3D)
        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int rows2 = matrix2.GetLength(0);
        int cols2 = matrix2.GetLength(1);
        
        // Check if matrices are 2D (2x2) or 3D (3x3)
        bool matrix1Valid = (rows1 == 2 && cols1 == 2) || (rows1 == 3 && cols1 == 3);
        bool matrix2Valid = (rows2 == 2 && cols2 == 2) || (rows2 == 3 && cols2 == 3);
        
        // Check if both matrices have the same dimensions
        bool sameSize = (rows1 == rows2 && cols1 == cols2);
        
        // Validate inputs
        if (!matrix1Valid || !matrix2Valid || !sameSize)
            return new double[,] { { -1 } };
        
        // Create result matrix with same dimensions
        double[,] result = new double[rows1, cols1];
        
        // Add corresponding elements
        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols1; j++)
            {
                result[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }
        
        return result;
    }
}