using System;

public class MatrixMath
{
    /// <summary>
    /// Multiplies a matrix by a scalar and returns the resulting matrix
    /// </summary>
    /// <param name="matrix">The matrix as a 2D double array</param>
    /// <param name="scalar">The scalar value to multiply by</param>
    /// <returns>The resulting matrix, or a matrix containing -1 if invalid</returns>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        // Check if matrix is null
        if (matrix == null)
            return new double[,] { { -1 } };
        
        // Get matrix dimensions
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        
        // Check if matrix is 2D (2x2) or 3D (3x3)
        bool matrixValid = (rows == 2 && cols == 2) || (rows == 3 && cols == 3);
        
        // Validate input
        if (!matrixValid)
            return new double[,] { { -1 } };
        
        // Create result matrix with same dimensions
        double[,] result = new double[rows, cols];
        
        // Multiply each element by the scalar
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = matrix[i, j] * scalar;
            }
        }
        
        return result;
    }
}