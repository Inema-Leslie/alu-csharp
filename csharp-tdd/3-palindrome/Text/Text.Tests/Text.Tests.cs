using System;
using Xunit;
using Text;

namespace Text.Tests
{
    public class StrTests
    {
        [Fact]
        public void IsPalindrome_SimplePalindrome_ReturnsTrue()
        {
            // Arrange
            string input = "racecar";
            
            // Act
            bool result = Str.IsPalindrome(input);
            
            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_AnotherSimplePalindrome_ReturnsTrue()
        {
            // Arrange
            string input = "level";
            
            // Act
            bool result = Str.IsPalindrome(input);
            
            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_PalindromeWithMixedCase_ReturnsTrue()
        {
            // Arrange
            string input = "Racecar";
            
            // Act
            bool result = Str.IsPalindrome(input);
            
            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_PalindromeWithSpacesAndPunctuation_ReturnsTrue()
        {
            // Arrange
            string input = "A man, a plan, a canal: Panama.";
            
            // Act
            bool result = Str.IsPalindrome(input);
            
            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_EmptyString_ReturnsTrue()
        {
            // Arrange
            string input = "";
            
            // Act
            bool result = Str.IsPalindrome(input);
            
            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_NullString_ReturnsTrue()
        {
            // Arrange
            string input = null;
            
            // Act
            bool result = Str.IsPalindrome(input);
            
            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_NonPalindrome_ReturnsFalse()
        {
            // Arrange
            string input = "hello";
            
            // Act
            bool result = Str.IsPalindrome(input);
            
            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsPalindrome_NonPalindromeWithMixedCase_ReturnsFalse()
        {
            // Arrange
            string input = "HelloWorld";
            
            // Act
            bool result = Str.IsPalindrome(input);
            
            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsPalindrome_PalindromeWithNumbers_ReturnsTrue()
        {
            // Arrange
            string input = "12321";
            
            // Act
            bool result = Str.IsPalindrome(input);
            
            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_PalindromeWithNumbersAndLetters_ReturnsTrue()
        {
            // Arrange
            string input = "racecar12321racecar";
            
            // Act
            bool result = Str.IsPalindrome(input);
            
            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_NonPalindromeWithNumbers_ReturnsFalse()
        {
            // Arrange
            string input = "12345";
            
            // Act
            bool result = Str.IsPalindrome(input);
            
            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsPalindrome_PalindromeWithOnlyPunctuation_ReturnsTrue()
        {
            // Arrange
            string input = "!@#$%";
            
            // Act
            bool result = Str.IsPalindrome(input);
            
            // Assert
            Assert.True(result); // After removing punctuation, it's empty string
        }

        [Fact]
        public void IsPalindrome_SingleCharacter_ReturnsTrue()
        {
            // Arrange
            string input = "a";
            
            // Act
            bool result = Str.IsPalindrome(input);
            
            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_SingleNumber_ReturnsTrue()
        {
            // Arrange
            string input = "5";
            
            // Act
            bool result = Str.IsPalindrome(input);
            
            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_SingleCharacterWithPunctuation_ReturnsTrue()
        {
            // Arrange
            string input = "!a!";
            
            // Act
            bool result = Str.IsPalindrome(input);
            
            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_PalindromeWithMultipleSpaces_ReturnsTrue()
        {
            // Arrange
            string input = "never   odd  or  even";
            
            // Act
            bool result = Str.IsPalindrome(input);
            
            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_ComplexPalindrome_ReturnsTrue()
        {
            // Arrange
            string input = "Go hang a salami, I'm a lasagna hog.";
            
            // Act
            bool result = Str.IsPalindrome(input);
            
            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_AnotherComplexPalindrome_ReturnsTrue()
        {
            // Arrange
            string input = "Was it a car or a cat I saw?";
            
            // Act
            bool result = Str.IsPalindrome(input);
            
            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_AlmostPalindrome_ReturnsFalse()
        {
            // Arrange
            string input = "racecaar";
            
            // Act
            bool result = Str.IsPalindrome(input);
            
            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsPalindrome_LongPalindrome_ReturnsTrue()
        {
            // Arrange
            string input = "Are we not pure? “No, sir!” Panama’s moody Noriega brags. “It is garbage!” Irony dooms a man; a prisoner up to new era.";
            
            // Act
            bool result = Str.IsPalindrome(input);
            
            // Assert
            Assert.True(result);
        }
    }
}