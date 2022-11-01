using System;
using System.Collections.Generic;
using Xunit;

namespace Statistics.Tests
{
    public class AverageTest
    {
        [Fact]
        public void TestMeanOfTwoNumbers()
        {
            List<int> numbers = new List<int> { 7, 8 };
            double expected = 7.5;
            Average average = new Average();

            double actual = average.Mean(numbers);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestMeanOfFiveNumbers()
        {
            List<int> numbers = new List<int> { 7, 8, 9, 1, 3 };
            double expected = 5.6;
            Average average = new Average();

            double actual = average.Mean(numbers);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestMeanOfNoNumbers()
        {
            List<int> numbers = new List<int> { };
            Average average = new Average();

            Assert.Throws<ArgumentException>(() => average.Mean(numbers));
        }
        [Fact]
        public void TestMedianForOddNumberOfElements()
        {
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            Average average = new Average();
            int expected = 2;
            double actual;

            actual = average.Median(numbers);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestMedianForEvenNumberOfElements()
        {
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            Average average = new Average();
            double expected = 1.5, actual;

            actual = average.Median(numbers);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestMedianForNoElements()
        {
            List<int> numbers = new List<int>();
            Average average = new Average();

            Assert.Throws<ArgumentException>(()=> average.Median(numbers));
        }
    }
}
