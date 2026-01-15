using System;

class Program
{
    static void Main(string[] args)
    {
        string str = "C# (pronounced \"See Sharp\") is a simple, modern, object-oriented, and type-safe programming language. C# has its roots in the C family of languages and will be immediately familiar to C, C++, Java, and JavaScript programmers.";
        
        // Find 'o' of "object" after "modern, "
        int o = str.IndexOf('o', str.IndexOf("modern, ".ToCharArray()[0]));
        // Find '-' after 'o'
        int dash = str.IndexOf('-', o);
        // Find 'p' of "programming" after "type-safe "
        int p = str.IndexOf('p', str.IndexOf("type-safe ".ToCharArray()[0]));
        // Find 'i' of "in" after "language. "
        int i = str.IndexOf('i', str.IndexOf("language. ".ToCharArray()[0]));
        
        str = str.Substring(o, dash - o + 10) + " " + 
              str.Substring(p, 11) + " " + 
              str.Substring(i, 2) + " " + 
              str.Substring(0, 2);
        Console.WriteLine(str);
    }
}