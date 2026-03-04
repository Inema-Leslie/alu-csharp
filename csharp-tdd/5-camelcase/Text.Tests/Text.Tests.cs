using System;
using Xunit;
using Text;

namespace Text.Tests
{
    public class StrTests
    {
        [Fact]
        public void CamelCase_SimpleCamelCase_ReturnsCorrectCount()
        {
            // Arrange
            string input = "helloWorld";
            int expected = 2;

            // Act
            int result = Str.CamelCase(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CamelCase_MultipleWords_ReturnsCorrectCount()
        {
            // Arrange
            string input = "helloWorldHowAreYou";
            int expected = 5;

            // Act
            int result = Str.CamelCase(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CamelCase_SingleWord_ReturnsOne()
        {
            // Arrange
            string input = "hello";
            int expected = 1;

            // Act
            int result = Str.CamelCase(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CamelCase_SingleWordWithCapital_ReturnsOne()
        {
            // Note: In proper camelCase, first word starts with lowercase
            // But method should still work even if input doesn't follow convention
            // Arrange
            string input = "Hello";
            int expected = 1; // Counts as 1 word even though it starts with capital

            // Act
            int result = Str.CamelCase(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CamelCase_EmptyString_ReturnsZero()
        {
            // Arrange
            string input = "";
            int expected = 0;

            // Act
            int result = Str.CamelCase(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CamelCase_NullString_ReturnsZero()
        {
            // Arrange
            string input = null;
            int expected = 0;

            // Act
            int result = Str.CamelCase(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CamelCase_TwoWordsWithMultipleCapitals_ReturnsCorrectCount()
        {
            // Arrange
            string input = "helloWORLD";
            int expected = 2; // 'hello' and 'WORLD' (capital letters indicate word starts)

            // Act
            int result = Str.CamelCase(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CamelCase_AllCaps_ReturnsLength()
        {
            // Arrange
            string input = "HELLO";
            int expected = 5; // Each capital indicates a new word

            // Act
            int result = Str.CamelCase(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CamelCase_MixedCase_ReturnsCorrectCount()
        {
            // Arrange
            string input = "hElLoWoRlD";
            int expected = 5; // 'h', 'E', 'L', 'W', 'R' each start a new word

            // Act
            int result = Str.CamelCase(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CamelCase_CommonProgrammingExample_ReturnsCorrectCount()
        {
            // Arrange
            string input = "camelCaseStringExample";
            int expected = 4;

            // Act
            int result = Str.CamelCase(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CamelCase_WithNumbers_IgnoresNumbers()
        {
            // Arrange
            string input = "hello123World456";
            int expected = 2; // Numbers don't affect word count

            // Act
            int result = Str.CamelCase(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CamelCase_WithSpecialCharacters_CountsCapitalsOnly()
        {
            // Arrange
            string input = "hello@World#How$Are%You";
            int expected = 5; // Special characters don't count as word starts

            // Act
            int result = Str.CamelCase(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CamelCase_ConsecutiveCapitals_CountsEachAsNewWord()
        {
            // Arrange
            string input = "helloWORLDHowAREYou";
            int expected = 7; // 'hello', 'W', 'O', 'R', 'L', 'D', 'H', 'A', 'R', 'E', 'You'? Let's count properly:
            // hello (word 1), W (word 2), O (word 3), R (word 4), L (word 5), D (word 6), H (word 7), A (word 8), R (word 9), E (word 10), You (word 11)
            // Actually, each capital indicates a new word, so:
            // hello, W, O, R, L, D, H, A, R, E, You = 11 words
            int expected11 = 11;

            // Act
            int result = Str.CamelCase(input);

            // Assert
            Assert.Equal(expected11, result);
        }

        [Fact]
        public void CamelCase_LongString_ReturnsCorrectCount()
        {
            // Arrange
            string input = "theQuickBrownFoxJumpsOverTheLazyDog";
            int expected = 9; // the, Quick, Brown, Fox, Jumps, Over, The, Lazy, Dog

            // Act
            int result = Str.CamelCase(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CamelCase_StringWithUnderscores_CountsCapitalsOnly()
        {
            // Arrange
            string input = "hello_World_How_Are_You";
            int expected = 5; // Underscores don't count, only capitals: hello, World, How, Are, You

            // Act
            int result = Str.CamelCase(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CamelCase_SingleCharacter_ReturnsOne()
        {
            // Arrange
            string input = "a";
            int expected = 1;

            // Act
            int result = Str.CamelCase(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CamelCase_SingleCapitalCharacter_ReturnsOne()
        {
            // Arrange
            string input = "A";
            int expected = 1;

            // Act
            int result = Str.CamelCase(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CamelCase_TwoCharacters_ReturnsCorrectCount()
        {
            // Arrange
            string input = "aB";
            int expected = 2; // 'a' and 'B' are two words

            // Act
            int result = Str.CamelCase(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CamelCase_StringWithAllCapitals_ReturnsLength()
        {
            // Arrange
            string input = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int expected = 26; // Each capital is a new word

            // Act
            int result = Str.CamelCase(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CamelCase_StringWithNoCapitals_ReturnsOne()
        {
            // Arrange
            string input = "abcdefghijklmnopqrstuvwxyz";
            int expected = 1;

            // Act
            int result = Str.CamelCase(input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}