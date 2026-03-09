using System;
using System.Reflection;
using System.Linq;

/// <summary>
/// Contains utility methods for object inspection using Reflection.
/// </summary>
public class Obj
{
    /// <summary>
    /// Prints the names of all available properties and methods of an object.
    /// </summary>
    /// <param name="myObj">The object to inspect.</param>
    public static void Print(object myObj)
    {
        if (myObj == null)
        {
            Console.WriteLine("Object is null");
            return;
        }

        Type objType = myObj.GetType();
        TypeInfo typeInfo = objType.GetTypeInfo();

        // Print Properties
        Console.WriteLine($"{objType.Name} Properties:");
        PropertyInfo[] properties = objType.GetProperties();
        foreach (PropertyInfo prop in properties)
        {
            Console.WriteLine(prop.Name);
        }

        // Print Methods
        Console.WriteLine($"{objType.Name} Methods:");
        MethodInfo[] methods = objType.GetMethods();
        
        // Filter out inherited methods from System.Object (optional - but example shows all methods)
        foreach (MethodInfo method in methods)
        {
            Console.WriteLine(method.Name);
        }
    }
}