using System;

/// <summary>
/// Contains utility methods for object type checking.
/// </summary>
public class Obj
{
    /// <summary>
    /// Determines whether the specified object is of type int.
    /// </summary>
    /// <param name="obj">The object to check.</param>
    /// <returns>True if the object is an int; otherwise, false.</returns>
    public static bool IsOfTypeInt(object obj)
    {
        return obj is int;
    }
}