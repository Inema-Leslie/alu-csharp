using System;
using Xunit;
using Text;

namespace Text.Tests
{
    public class StrTests
    {
        [Fact]
        public void UniqueChar_SimpleStringWithUnique_ReturnsCorrectIndex()
        {
            // Arrange
            string input = "leetcode";
            int expected = 0; // 'l' is the first unique character

            // Act
            int result = Str.UniqueChar(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void UniqueChar_AnotherStringWithUnique_ReturnsCorrectIndex()
        {
            // Arrange
            string input = "loveleetcode";
            int expected = 2; // 'v' is the first unique character

            // Act
            int result = Str.UniqueChar(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void UniqueChar_StringWithUniqueAtEnd_ReturnsCorrectIndex()
        {
            // Arrange
            string input = "aabbcdd";
            int expected = 4; // 'c' is unique and at index 4

            // Act
            int result = Str.UniqueChar(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void UniqueChar_StringWithUniqueAtBeginning_ReturnsCorrectIndex()
        {
            // Arrange
            string input = "caabbd";
            int expected = 0; // 'c' is unique and at index 0

            // Act
            int result = Str.UniqueChar(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void UniqueChar_AllCharactersRepeated_ReturnsNegativeOne()
        {
            // Arrange
            string input = "aabbcc";
            int expected = -1;

            // Act
            int result = Str.UniqueChar(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void UniqueChar_EmptyString_ReturnsNegativeOne()
        {
            // Arrange
            string input = "";
            int expected = -1;

            // Act
            int result = Str.UniqueChar(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void UniqueChar_NullString_ReturnsNegativeOne()
        {
            // Arrange
            string input = null;
            int expected = -1;

            // Act
            int result = Str.UniqueChar(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void UniqueChar_SingleCharacter_ReturnsZero()
        {
            // Arrange
            string input = "a";
            int expected = 0;

            // Act
            int result = Str.UniqueChar(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void UniqueChar_TwoDifferentCharacters_ReturnsZero()
        {
            // Arrange
            string input = "ab";
            int expected = 0; // 'a' is the first unique character

            // Act
            int result = Str.UniqueChar(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void UniqueChar_TwoSameCharacters_ReturnsNegativeOne()
        {
            // Arrange
            string input = "aa";
            int expected = -1;

            // Act
            int result = Str.UniqueChar(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void UniqueChar_StringWithMultipleUniqueCharacters_ReturnsIndexOfFirst()
        {
            // Arrange
            string input = "abacabad";
            int expected = 3; // 'c' is the first unique character (index 3)
            // 'a' appears multiple times, 'b' appears multiple times, 'c' appears once, 'd' appears later

            // Act
            int result = Str.UniqueChar(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void UniqueChar_AllCharactersSame_ReturnsNegativeOne()
        {
            // Arrange
            string input = "aaaaa";
            int expected = -1;

            // Act
            int result = Str.UniqueChar(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void UniqueChar_ComplexPattern_ReturnsCorrectIndex()
        {
            // Arrange
            string input = "abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxy";
            int expected = 25; // 'z' is the only unique character at index 25

            // Act
            int result = Str.UniqueChar(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void UniqueChar_StringWithUniqueInMiddle_ReturnsCorrectIndex()
        {
            // Arrange
            string input = "aabbcddee";
            int expected = 4; // 'c' is unique at index 4

            // Act
            int result = Str.UniqueChar(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void UniqueChar_StringWithNoUniqueButDifferentPattern_ReturnsNegativeOne()
        {
            // Arrange
            string input = "aabbccddeeffgghhiijj";
            int expected = -1;

            // Act
            int result = Str.UniqueChar(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void UniqueChar_StringWithUniqueAtDifferentPositions_VerifyFirst()
        {
            // Arrange
            string input = "xxyzzy";
            int expected = 2; // 'y' is repeated, 'z' is repeated, 'x' is repeated, so no unique? Wait, let's check:
            // 'x' appears twice (indices 0,1)
            // 'y' appears twice (indices 2,4)
            // 'z' appears twice (indices 3,5)
            // Actually no unique characters, so expected should be -1
            int correctedExpected = -1;

            // Act
            int result = Str.UniqueChar(input);

            // Assert
            Assert.Equal(correctedExpected, result);
        }

        [Fact]
        public void UniqueChar_StringWithUniqueAtFirstPosition_ReturnsZero()
        {
            // Arrange
            string input = "zabcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwx";
            int expected = 0; // 'z' is unique at the beginning

            // Act
            int result = Str.UniqueChar(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void UniqueChar_StringWithAllLettersOnce_ReturnsZero()
        {
            // Arrange
            string input = "abcdefghijklmnopqrstuvwxyz";
            int expected = 0; // 'a' is the first unique character

            // Act
            int result = Str.UniqueChar(input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}