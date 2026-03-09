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

/// <summary>
/// Represents a Rectangle shape that inherits from Shape.
/// </summary>
public class Rectangle : Shape
{
    private int width;
    private int height;

    /// <summary>
    /// Gets or sets the width of the rectangle.
    /// </summary>
    /// <value>The width must be non-negative.</value>
    /// <exception cref="ArgumentException">Thrown when width is set to a negative value.</exception>
    public int Width
    {
        get { return width; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");
            width = value;
        }
    }

    /// <summary>
    /// Gets or sets the height of the rectangle.
    /// </summary>
    /// <value>The height must be non-negative.</</value>
    /// <exception cref="ArgumentException">Thrown when height is set to a negative value.</exception>
    public int Height
    {
        get { return height; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");
            height = value;
        }
    }

    /// <summary>
    /// Calculates the area of the rectangle.
    /// </summary>
    /// <returns>The area of the rectangle (width * height).</returns>
    public new int Area()
    {
        return width * height;
    }

    /// <summary>
    /// Returns a string representation of the rectangle.
    /// </summary>
    /// <returns>String in format [Rectangle] &lt;width&gt; / &lt;height&gt;</returns>
    public override string ToString()
    {
        return $"[Rectangle] {width} / {height}";
    }
}

/// <summary>
/// Represents a Square shape that inherits from Rectangle.
/// </summary>
public class Square : Rectangle
{
    private int size;

    /// <summary>
    /// Gets or sets the size of the square.
    /// Setting this value updates both width and height to maintain square proportions.
    /// </summary>
    /// <value>The size must be non-negative.</value>
    /// <exception cref="ArgumentException">Thrown when size is set to a negative value.</exception>
    public int Size
    {
        get { return size; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Size must be greater than or equal to 0");
            
            size = value;
            Width = value;
            Height = value;
        }
    }

    /// <summary>
    /// Returns a string representation of the square.
    /// </summary>
    /// <returns>String in format [Square] &lt;size&gt; / &lt;size&gt;</returns>
    public override string ToString()
    {
        return $"[Square] {size} / {size}";
    }
}