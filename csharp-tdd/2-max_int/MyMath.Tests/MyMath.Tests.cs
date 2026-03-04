using System;
using System.Collections.Generic;
using Xunit;
using MyMath;

namespace MyMath.Tests
{
    public class OperationsTests
    {
        [Fact]
        public void Max_ValidListWithPositiveNumbers_ReturnsMax()
        {
            // Arrange
            List<int> numbers = new List<int> { 1, 5, 3, 7, 2 };
            int expected = 7;

            // Act
            int result = Operations.Max(numbers);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Max_ValidListWithNegativeNumbers_ReturnsMax()
        {
            // Arrange
            List<int> numbers = new List<int> { -1, -5, -3, -7, -2 };
            int expected = -1;

            // Act
            int result = Operations.Max(numbers);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Max_ValidListWithMixedNumbers_ReturnsMax()
        {
            // Arrange
            List<int> numbers = new List<int> { -10, 0, 15, -5, 8 };
            int expected = 15;

            // Act
            int result = Operations.Max(numbers);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Max_ListWithSingleElement_ReturnsThatElement()
        {
            // Arrange
            List<int> numbers = new List<int> { 42 };
            int expected = 42;

            // Act
            int result = Operations.Max(numbers);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Max_ListWithSingleNegativeElement_ReturnsThatElement()
        {
            // Arrange
            List<int> numbers = new List<int> { -42 };
            int expected = -42;

            // Act
            int result = Operations.Max(numbers);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Max_EmptyList_ReturnsZero()
        {
            // Arrange
            List<int> numbers = new List<int>();
            int expected = 0;

            // Act
            int result = Operations.Max(numbers);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Max_NullList_ReturnsZero()
        {
            // Arrange
            List<int> numbers = null;
            int expected = 0;

            // Act
            int result = Operations.Max(numbers);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Max_ListWithDuplicateMax_ReturnsCorrectMax()
        {
            // Arrange
            List<int> numbers = new List<int> { 5, 3, 9, 2, 9, 1 };
            int expected = 9;

            // Act
            int result = Operations.Max(numbers);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Max_ListWithAllSameNumbers_ReturnsThatNumber()
        {
            // Arrange
            List<int> numbers = new List<int> { 7, 7, 7, 7, 7 };
            int expected = 7;

            // Act
            int result = Operations.Max(numbers);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Max_ListWithMaxAtBeginning_ReturnsCorrectMax()
        {
            // Arrange
            List<int> numbers = new List<int> { 100, 50, 75, 25, 30 };
            int expected = 100;

            // Act
            int result = Operations.Max(numbers);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Max_ListWithMaxAtEnd_ReturnsCorrectMax()
        {
            // Arrange
            List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };
            int expected = 50;

            // Act
            int result = Operations.Max(numbers);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Max_ListWithLargeNumbers_ReturnsCorrectMax()
        {
            // Arrange
            List<int> numbers = new List<int> { 1000000, 2000000, 1500000, 3000000 };
            int expected = 3000000;

            // Act
            int result = Operations.Max(numbers);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Max_ListWithIntMinValue_ReturnsCorrectMax()
        {
            // Arrange
            List<int> numbers = new List<int> { int.MinValue, -5, 0, 10 };
            int expected = 10;

            // Act
            int result = Operations.Max(numbers);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Max_ListWithIntMaxValue_ReturnsIntMaxValue()
        {
            // Arrange
            List<int> numbers = new List<int> { 10, 20, int.MaxValue, 30 };
            int expected = int.MaxValue;

            // Act
            int result = Operations.Max(numbers);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}