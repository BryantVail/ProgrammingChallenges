using StringManagement;

namespace StringManagement_Tests
{
    public class StringManipulator_Tests
    {
        public class ReverseString
        {
            [Theory]
            [InlineData('a', 'b')]
            [InlineData('1', '2')]
            [InlineData(char.MinValue, char.MaxValue)]
            public void given_two_characters_after_swap_first_is_last_and_last_is_first_byRefAndByValOverloads(char charA, char charB)
            {

                if(charA == charB)
                {
                    throw new ArgumentException("test should have two different values to check");
                }
                else
                {
                    // arrange
                    string testString = $"{charA}{charB}";

                    // act
                    var byRef_result = StringManipulator.ReverseString(
                        ref testString);
                    var result = StringManipulator.ReverseString(testString);

                    // assert
                    // byRef
                    Assert.Equal(byRef_result.First(), charB);
                    Assert.Equal(byRef_result.Last(), charA);

                    Assert.Equal(result.First(), charB);
                    Assert.Equal(result.Last(), charA);

                }
            }

        }
    }
}