using Xunit;
using MyMath;

namespace MyMath.Tests
{
    public class OperationsTests
    {
        [Fact]
        public void Add_TwoPositiveNumbers_ReturnsSum()
        {
            int result = Operations.Add(3, 5);
            Assert.Equal(8, result);
        }

        [Fact]
        public void Add_PositiveAndNegative_ReturnsSum()
        {
            int result = Operations.Add(10, -4);
            Assert.Equal(6, result);
        }

        [Fact]
        public void Add_TwoNegativeNumbers_ReturnsSum()
        {
            int result = Operations.Add(-7, -3);
            Assert.Equal(-10, result);
        }

        [Fact]
        public void Add_ZeroAndNumber_ReturnsNumber()
        {
            int result = Operations.Add(0, 42);
            Assert.Equal(42, result);
        }
    }
}