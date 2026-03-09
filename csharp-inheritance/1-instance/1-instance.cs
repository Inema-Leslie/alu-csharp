using System;

/// <summary>
/// Contains utility methods for object type checking.
/// </summary>
public class Obj
{
    /// <summary>
    /// Determines whether the specified object is an instance of Array,
    /// or inherits from Array.
    /// </summary>
    /// <param name="obj">The object to check.</param>
    /// <returns>True if the object is an instance of Array or inherits from Array; otherwise, false.</returns>
    public static bool IsInstanceOfArray(object obj)
    {
        return obj is Array;
    }
}