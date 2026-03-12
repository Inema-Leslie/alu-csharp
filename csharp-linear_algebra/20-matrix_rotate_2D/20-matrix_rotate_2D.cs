using System;

public class MatrixMath
{
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        // Check if matrix is null or not square
        if (matrix == null || matrix.GetLength(0) != matrix.GetLength(1))
            return new double[,] { { -1 } };
        
        int size = matrix.GetLength(0);
        double[,] result = new double[size, size];
        
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                // Apply rotation transformation to the value based on position
                double rotatedX = i * Math.Cos(angle) - j * Math.Sin(angle);
                double rotatedY = i * Math.Sin(angle) + j * Math.Cos(angle);
                
                // The new value combines the original value with the rotated coordinates
                result[i, j] = matrix[i, j] * (rotatedX + rotatedY);
            }
        }
        
        return result;
    }
}