using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DefaultProject.Tests.ReverseTheOddLengthWordsTest
{
    public class ReverseTheOddLengthWordsTest
    {
        [Theory]
        [InlineData("Hello world!", "olleH dlrow!")]
        [InlineData("Hell world!", "Hell dlrow!")]
        [InlineData("Hello worl!", "olleH worl!")]
        [InlineData("Bananas", "sananaB")]
        [InlineData("One two three four", "enO owt eerht four")]
        [InlineData("Make sure uoy only esrever sdrow of ddo length", "Make sure you only reverse words of odd length")]
        public void ReverseOdd_ReturnReverseOddWords(string strInput, string strOutput)
        {
            string reverseInput = DefaultProject.ReverseTheOddLengthWords.ReverseTheOddLengthWords.ReverseOdd(strInput);

            Assert.Equal(strOutput, reverseInput);
        }

        [Theory]
        [InlineData("Hello", "olleH")]
        public void ReverseWord_ReturnReverseString(string strInput, string strOutput)
        {
            string reverseInput = DefaultProject.ReverseTheOddLengthWords.ReverseTheOddLengthWords.ReverseWord(strInput);

            Assert.Equal(strOutput, reverseInput);
        }

        [Theory]
        [InlineData("Hello!", true)]
        [InlineData("Hello.", true)]
        [InlineData("Hello,", true)]
        [InlineData("Hello?", true)]
        [InlineData("Hello;", true)]
        [InlineData("Hello", false)]
        public void ContainSpecialCharacter_ReturnFalseIfContainsOneOfSpecialCharacter(string strInput, bool outputValue)
        {
            bool hasSpecialCharacter = DefaultProject.ReverseTheOddLengthWords.ReverseTheOddLengthWords.ContainSpecialCharacter(strInput);

            Assert.Equal(outputValue, hasSpecialCharacter);
        }

        [Theory]
        [InlineData("Hello!", true)]
        [InlineData("Hell.", false)]
        [InlineData("Hell", false)]
        [InlineData("Hello", true)]
        [InlineData("H", true)]
        [InlineData("He", false)]
        public void IsWordCharacterOdd_ReturnTrueIfTheWordIsOddWithoutSpecialCharacters(string strInput, bool outputValue)
        {
            bool isOdd = DefaultProject.ReverseTheOddLengthWords.ReverseTheOddLengthWords.IsWordCharactersOdd(strInput);

            Assert.Equal(outputValue, isOdd);
        }
    }
}
