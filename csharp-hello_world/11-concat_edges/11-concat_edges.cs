using System;
class Program
{
    static void Main(string[] args)
    {
        string str = "C# (pronounced \"See Sharp\") is a simple, modern, object-oriented, and type-safe programming language. C# has its roots in the C family of languages and will be immediately familiar to C, C++, Java, and JavaScript programmers.";
        str = str.Substring(str.IndexOf('o'), str.IndexOf('-') - str.IndexOf('o') + 10) + str[1] + str.Substring(str.IndexOf('p', str.IndexOf('-')), str.IndexOf(str[1], str.IndexOf('p', str.IndexOf('-'))) - str.IndexOf('p', str.IndexOf('-'))) + str[1] + str.Substring(str.IndexOf('i', str.IndexOf('.', str.IndexOf('p', str.IndexOf('-')))), 2) + str[1] + str.Substring(0, 2);
        Console.WriteLine(str);
    }
}