using System;

public class VectorMath
{
    /// <summary>
    /// Adds two vectors and returns the resulting vector
    /// </summary>
    /// <param name="vector1">First vector as a double array</param>
    /// <param name="vector2">Second vector as a double array</param>
    /// <returns>The sum vector, or a vector containing -1 if invalid</returns>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        // Check if either vector is null
        if (vector1 == null || vector2 == null)
            return new double[] { -1 };
        
        // Check if vectors are 2D or 3D
        bool vector1Valid = (vector1.Length == 2 || vector1.Length == 3);
        bool vector2Valid = (vector2.Length == 2 || vector2.Length == 3);
        
        // Check if both vectors have the same size
        bool sameSize = (vector1.Length == vector2.Length);
        
        // Validate inputs
        if (!vector1Valid || !vector2Valid || !sameSize)
            return new double[] { -1 };
        
        // Create result array
        double[] result = new double[vector1.Length];
        
        // Add corresponding components
        for (int i = 0; i < vector1.Length; i++)
        {
            result[i] = vector1[i] + vector2[i];
        }
        
        return result;
    }
}