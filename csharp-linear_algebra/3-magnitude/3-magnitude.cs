using System;

public class VectorMath
{
    /// <summary>
    /// Calculates the magnitude (length) of a 2D or 3D vector
    /// </summary>
    /// <param name="vector">The vector as a double array</param>
    /// <returns>The magnitude rounded to nearest hundredth, or -1 if invalid</returns>
    public static double Magnitude(double[] vector)
    {
        // Check if vector is null
        if (vector == null)
            return -1;
        
        // Check if vector is 2D or 3D
        if (vector.Length != 2 && vector.Length != 3)
            return -1;
        
        double sumOfSquares = 0;
        
        // Calculate sum of squares
        foreach (double component in vector)
        {
            sumOfSquares += component * component;
        }
        
        // Calculate magnitude
        double magnitude = Math.Sqrt(sumOfSquares);
        
        // Round to nearest hundredth
        return Math.Round(magnitude, 2);
    }
}