using System;

class Character
{
    public static bool IsLower(char c)
    {
        
        int asciiValue = (int)c;
        return asciiValue >= 97 && asciiValue <= 122;
    }
}

class Program
{
    static void Main(string[] args)
    {
        char[] letters = { 'a', 'A', 'Q', 'h', '9', 'B', 'g'};
        
        for (int i = 0; i < letters.Length; i++)
        {
            if(Character.IsLower(letters[i]))
                Console.WriteLine("{0} is lowercase", letters[i]);
            else
                Console.WriteLine("{0} is uppercase", letters[i]);
        }
    }
}