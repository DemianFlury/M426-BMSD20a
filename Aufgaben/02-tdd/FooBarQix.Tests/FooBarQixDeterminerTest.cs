using Xunit;

namespace FooBarQix.Tests
{
    public class FooBarQixDeterminerTest
    {
        [Theory]
        [InlineData(2, "2")]
        [InlineData(3, "Foo")]
        [InlineData(5, "Bar")]
        [InlineData(7, "Qix")]
        [InlineData(21,"FooQix")]
        [InlineData(105,"FooBarQix")]
        [InlineData(420,"FooBarQix")]

        public void Determine_WhenNumberNotDivisible_MustReturnNumberAsString(int number, string expected)
        {
            FooBarQixDeterminer determiner = new FooBarQixDeterminer();

            string result = determiner.Determine(number);

            Assert.Equal(expected, result);
        }
    }
}