using StringManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManagement_Tests
{
    public class StringEvaluator_Tests
    {
        public class IsPalindrome
        {
            [Theory]
            [InlineData("aa")]
            [InlineData("11")]
            public void given_a_string_of_two_of_the_same_characters_returns_true(
                string palindrome)
            {
                // arrange

                // act
                // assert
                Assert.True(StringEvaluator.IsPalindrome(palindrome));

            }

            [Theory]
            [InlineData("ab")]
            public void given_a_string_of_two_different_characters_returns_false(
                string nonPalindrome)
            {
                // arrange
                // act
                // assert
                Assert.False(StringEvaluator.IsPalindrome(nonPalindrome));

            }

            [Theory]
            [InlineData("carac")]
            [InlineData("racecar")]
            public void given_palindrom_of_4_to_10_characters_returns_true(
                string moderateSizedPalindrome)
            {
                // arrange
                // act
                // assert
                Assert.True(
                    StringEvaluator.IsPalindrome(
                        moderateSizedPalindrome));

            }

            [Theory]
            [InlineData("a")]
            [InlineData("b")]
            [InlineData("1")]
            public void given_a_string_with_a_length_of_1_returns_true(
                string value)
            {
                // arrange
                // act
                // assert
                Assert.True(
                    StringEvaluator.IsPalindrome(
                        value));
            }
        }
    }
}
