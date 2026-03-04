using System;

namespace Text
{
    /// <summary>
    /// Contains string operations
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Counts the number of words in a camelCase string
        /// Each word begins with a capital letter except the first word
        /// </summary>
        /// <param name="s">The camelCase string to analyze</param>
        /// <returns>The number of words in the string</returns>
        public static int CamelCase(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;

            // Start with 1 word (the first word, which starts with lowercase)
            int wordCount = 1;

            // Count each capital letter as the start of a new word
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsUpper(s[i]))
                {
                    wordCount++;
                }
            }

            return wordCount;
        }
    }
}