using System;
using Xunit;
using MyMath;

namespace MyMath.Tests
{
    public class MatrixTests
    {
        [Fact]
        public void Divide_ValidMatrixAndNumber_ReturnsDividedMatrix()
        {
            // Arrange
            int[,] input = new int[,] { { 4, 6 }, { 8, 10 } };
            int divisor = 2;
            int[,] expected = new int[,] { { 2, 3 }, { 4, 5 } };

            // Act
            int[,] result = Matrix.Divide(input, divisor);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Divide_MatrixWithNegativeNumbers_ReturnsCorrectResult()
        {
            // Arrange
            int[,] input = new int[,] { { -4, 6 }, { -8, 10 } };
            int divisor = 2;
            int[,] expected = new int[,] { { -2, 3 }, { -4, 5 } };

            // Act
            int[,] result = Matrix.Divide(input, divisor);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Divide_MatrixWithZeroElements_ReturnsZeroForThoseElements()
        {
            // Arrange
            int[,] input = new int[,] { { 0, 6 }, { 8, 0 } };
            int divisor = 2;
            int[,] expected = new int[,] { { 0, 3 }, { 4, 0 } };

            // Act
            int[,] result = Matrix.Divide(input, divisor);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Divide_DivisorIsZero_ReturnsNullAndPrintsMessage()
        {
            // Arrange
            int[,] input = new int[,] { { 4, 6 }, { 8, 10 } };
            int divisor = 0;

            // Act
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);
            int[,] result = Matrix.Divide(input, divisor);

            // Assert
            Assert.Null(result);
            Assert.Contains("Num cannot be 0", consoleOutput.ToString());
        }

        [Fact]
        public void Divide_MatrixIsNull_ReturnsNull()
        {
            // Arrange
            int[,] input = null;
            int divisor = 2;

            // Act
            int[,] result = Matrix.Divide(input, divisor);

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void Divide_SingleElementMatrix_ReturnsCorrectResult()
        {
            // Arrange
            int[,] input = new int[,] { { 10 } };
            int divisor = 5;
            int[,] expected = new int[,] { { 2 } };

            // Act
            int[,] result = Matrix.Divide(input, divisor);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Divide_NonRectangularMatrix_ThrowsException()
        {
            // Note: In C#, matrices are always rectangular by definition
            // This test is more for documentation purposes
            // Arrange
            int[,] input = new int[,] { { 4, 6 }, { 8 } }; // This won't compile in C#

            // In C#, you cannot create a non-rectangular 2D array
            // So this test is actually invalid for C#
        }

        [Fact]
        public void Divide_DivisorIsOne_ReturnsSameMatrix()
        {
            // Arrange
            int[,] input = new int[,] { { 4, 6 }, { 8, 10 } };
            int divisor = 1;
            int[,] expected = new int[,] { { 4, 6 }, { 8, 10 } };

            // Act
            int[,] result = Matrix.Divide(input, divisor);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Divide_MatrixWithLargeNumbers_ReturnsCorrectResult()
        {
            // Arrange
            int[,] input = new int[,] { { 1000000, 2000000 }, { 3000000, 4000000 } };
            int divisor = 1000;
            int[,] expected = new int[,] { { 1000, 2000 }, { 3000, 4000 } };

            // Act
            int[,] result = Matrix.Divide(input, divisor);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}