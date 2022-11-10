using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hi", false)]
        [InlineData("racecar", true)]
        public void PalindromeTester(string word, bool expected)
        {
            var wordSmith = new WordSmith();


            var actual = wordSmith.IsAPalindrome(word);


            Assert.Equal(expected, actual);
        }
    }
}