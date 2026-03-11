using System;

public class MatrixMath
{
    /// <summary>
    /// Rotates a square 2D matrix by a given angle in radians
    /// Applies rotation to the value of each element, not changing positions
    /// </summary>
    /// <param name="matrix">The square 2D matrix to rotate</param>
    /// <param name="angle">The rotation angle in radians</param>
    /// <returns>The rotated matrix, or a matrix containing -1 if invalid</returns>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        // Check if matrix is null
        if (matrix == null)
            return new double[,] { { -1 } };
        
        // Get matrix dimensions
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        
        // Check if matrix is square (2x2 or 3x3 or any square size)
        if (rows != cols || rows < 2)
            return new double[,] { { -1 } };
        
        // Calculate rotation matrix values
        double cosTheta = Math.Cos(angle);
        double sinTheta = Math.Sin(angle);
        
        // Create result matrix with same dimensions
        double[,] result = new double[rows, cols];
        
        // Apply rotation to each element
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                // Each element (x, y) is rotated using the rotation matrix:
                // x' = x * cosθ - y * sinθ
                // y' = x * sinθ + y * cosθ
                // Here we treat the matrix element value as a point (value, 0) in 2D space
                // Since we're only rotating the values themselves, we consider the element as a point on the x-axis
                double x = matrix[i, j];
                double y = 0; // We're rotating the scalar value as if it were a point on the x-axis
                
                // Apply 2D rotation transformation
                double newX = x * cosTheta - y * sinTheta;
                double newY = x * sinTheta + y * cosTheta;
                
                // Store the rotated x-component as the new value
                result[i, j] = newX;
            }
        }
        
        return result;
    }
}