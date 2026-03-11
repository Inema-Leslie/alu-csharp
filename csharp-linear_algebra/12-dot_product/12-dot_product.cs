using System;

public class VectorMath
{
    /// <summary>
    /// Calculates the dot product of two 2D or two 3D vectors
    /// </summary>
    /// <param name="vector1">First vector as a double array</param>
    /// <param name="vector2">Second vector as a double array</param>
    /// <returns>The dot product, or -1 if invalid</returns>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        // Check if either vector is null
        if (vector1 == null || vector2 == null)
            return -1;
        
        // Check if vectors are 2D or 3D
        bool vector1Valid = (vector1.Length == 2 || vector1.Length == 3);
        bool vector2Valid = (vector2.Length == 2 || vector2.Length == 3);
        
        // Check if both vectors have the same size
        bool sameSize = (vector1.Length == vector2.Length);
        
        // Validate inputs
        if (!vector1Valid || !vector2Valid || !sameSize)
            return -1;
        
        double dotProduct = 0;
        
        // Calculate dot product: sum of (x1 * x2) + (y1 * y2) + (z1 * z2) if 3D
        for (int i = 0; i < vector1.Length; i++)
        {
            dotProduct += vector1[i] * vector2[i];
        }
        
        return dotProduct;
    }
}