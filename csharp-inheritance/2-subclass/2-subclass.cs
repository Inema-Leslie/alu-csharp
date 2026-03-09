using System;

/// <summary>
/// Contains utility methods for type checking and inheritance.
/// </summary>
public class Obj
{
    /// <summary>
    /// Determines whether derivedType is a strict subclass of baseType.
    /// Returns false if derivedType is the same as baseType.
    /// </summary>
    /// <param name="derivedType">The potential derived type to check.</param>
    /// <param name="baseType">The base type to check against.</param>
    /// <returns>True if derivedType is a subclass of baseType (but not the same type); otherwise, false.</returns>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        if (derivedType == null || baseType == null)
            return false;
            
        return derivedType.IsSubclassOf(baseType);
    }
}