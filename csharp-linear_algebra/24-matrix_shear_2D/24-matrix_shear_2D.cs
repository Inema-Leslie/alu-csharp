using System;

public class MatrixMath
{
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        if (matrix == null || matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return new double[,] { { -1 } };
        
        if (direction != 'x' && direction != 'y')
            return new double[,] { { -1 } };
        
        double[,] result = new double[2, 2];
        
        if (direction == 'x')
        {
            result[0, 0] = matrix[0, 0] + factor * matrix[0, 1];
            result[0, 1] = matrix[0, 1];
            result[1, 0] = matrix[1, 0] + factor * matrix[1, 1];
            result[1, 1] = matrix[1, 1];
        }
        else // direction == 'y'
        {
            result[0, 0] = matrix[0, 0];
            result[0, 1] = factor * matrix[0, 0] + matrix[0, 1];
            result[1, 0] = matrix[1, 0];
            result[1, 1] = factor * matrix[1, 0] + matrix[1, 1];
        }
        
        return result;
    }
}