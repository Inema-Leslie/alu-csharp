using System;

/// <summary>
/// Represents a base Shape class.
/// </summary>
public class Shape
{
    /// <summary>
    /// Calculates the area of the shape.
    /// This is a virtual method meant to be overridden by derived classes.
    /// </summary>
    /// <returns>The area of the shape.</returns>
    /// <exception cref="System.NotImplementedException">Thrown when the method is not overridden in a derived class.</exception>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}