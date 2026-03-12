using System;

public class MatrixMath
{
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        if (matrix == null || matrix.GetLength(0) != matrix.GetLength(1))
            return new double[,] { { -1 } };
        
        int size = matrix.GetLength(0);
        double[,] result = new double[size, size];
        
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                result[i, j] = matrix[i, j] * (i * Math.Cos(angle) - j * Math.Sin(angle) + i * Math.Sin(angle) + j * Math.Cos(angle));
            }
        }
        
        return result;
    }
}