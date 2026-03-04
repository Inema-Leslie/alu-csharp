using System;
using System.Text.RegularExpressions;

namespace Text
{
    /// <summary>
    /// Contains string operations
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Determines if a string is a palindrome
        /// </summary>
        /// <param name="s">The string to check</param>
        /// <returns>True if the string is a palindrome, False otherwise</returns>
        public static bool IsPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
                return true;

            // Remove all non-alphanumeric characters and convert to lowercase
            string cleaned = Regex.Replace(s, "[^a-zA-Z0-9]", "").ToLower();
            
            // Check if the cleaned string is a palindrome
            int left = 0;
            int right = cleaned.Length - 1;
            
            while (left < right)
            {
                if (cleaned[left] != cleaned[right])
                    return false;
                
                left++;
                right--;
            }
            
            return true;
        }
    }
}