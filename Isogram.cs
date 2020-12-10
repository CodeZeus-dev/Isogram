using System;
using System.Linq;
using System.Collections.Generic;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        word = word.Replace(" ", String.Empty).Replace("-", String.Empty).ToLower();
        char[] charsInWord = word.ToCharArray(0, word.Length);

        IEnumerable<char> uniqueChars = charsInWord.Distinct<char>();

        if (string.Join("", uniqueChars).Length == word.Length)
        {
            return true;
        }

        return false; 
    }
}
