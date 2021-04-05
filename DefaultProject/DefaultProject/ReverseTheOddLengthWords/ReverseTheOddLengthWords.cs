using System;
using System.Collections.Generic;
using System.Text;

namespace DefaultProject.ReverseTheOddLengthWords
{
    public class ReverseTheOddLengthWords
    {
        public static string ReverseOdd(string str)
        {
            string returnString = null;
            string[] words = str.Split(" ");

            foreach (string word in words)
            {
                string wordToAdd = word;
                char lastCharacter = word[word.Length - 1];
                if (IsWordCharactersOdd(word))
                {
                    if (ContainSpecialCharacter(word))
                    {
                        wordToAdd = ReverseWord(word.Remove(word.Length - 1)) + lastCharacter;
                    }
                    else
                    {
                        wordToAdd = ReverseWord(word);
                    }
                }

                returnString = returnString == null ? wordToAdd : returnString + " " + wordToAdd;
            }

            return returnString;
        }

        public static string ReverseWord(string word)
        {
            string reverseInput = "";

            foreach (char item in word)
            {
                reverseInput = item + reverseInput;
            }

            return reverseInput;
        }

        public static bool IsWordCharactersOdd(string word)
        {
            if (ContainSpecialCharacter(word))
                return (word.Length - 1) % 2 != 0;

            return word.Length % 2 != 0;
        }

        public static bool ContainSpecialCharacter(string word)
        {
            char[] specialCharacters = new char[] { ',', '.', ';', '?', '!' };
            char lastCharacter = word[word.Length - 1];

            if (word.IndexOfAny(specialCharacters) != -1)
                return true;

            return false;
        }
    }
}
