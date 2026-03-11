using System;

public class VectorMath
{
    /// <summary>
    /// Multiplies a vector by a scalar and returns the resulting vector
    /// </summary>
    /// <param name="vector">The vector as a double array</param>
    /// <param name="scalar">The scalar value to multiply by</param>
    /// <returns>The resulting vector, or a vector containing -1 if invalid</returns>
    public static double[] Multiply(double[] vector, double scalar)
    {
        // Check if vector is null
        if (vector == null)
            return new double[] { -1 };
        
        // Check if vector is 2D or 3D
        if (vector.Length != 2 && vector.Length != 3)
            return new double[] { -1 };
        
        // Create result array
        double[] result = new double[vector.Length];
        
        // Multiply each component by the scalar
        for (int i = 0; i < vector.Length; i++)
        {
            result[i] = vector[i] * scalar;
        }
        
        return result;
    }
}