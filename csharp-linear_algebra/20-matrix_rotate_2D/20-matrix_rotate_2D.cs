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
        double cos = Math.Cos(angle);
        double sin = Math.Sin(angle);
        
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                // Apply rotation to the coordinates and sum them
                double rotatedX = i * cos - j * sin;
                double rotatedY = i * sin + j * cos;
                double transform = rotatedX + rotatedY;
                
                result[i, j] = matrix[i, j] * transform;
            }
        }
        
        return result;
    }
}