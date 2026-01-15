using System;
class Program
{
    static void Main(string[] args)
    {
        string str = "C# (pronounced \"See Sharp\") is a simple, modern, object-oriented, and type-safe programming language. C# has its roots in the C family of languages and will be immediately familiar to C, C++, Java, and JavaScript programmers.";
        char sp=str[1]; int o=str.IndexOf('o'), d=str.IndexOf('-'), p=str.IndexOf('p',d), s=str.IndexOf(sp,p), i=str.IndexOf('i',str.IndexOf('.',p));
        str=str.Substring(o,d-o+10)+sp+str.Substring(p,s-p)+sp+str.Substring(i,2)+sp+str.Substring(0,2);
        Console.WriteLine(str);
    }
}