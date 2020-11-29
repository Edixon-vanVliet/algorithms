using System;
using Xunit;
using Algorithms;

namespace Tests
{
    public class Test
    {
        [Fact]
        public void TestBinarySearch()
        {
            // arrange
            int[] input = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int key = 8;
            int expectedIndex = 7;

            // act
            var actualIndex = BinarySearch.IndexOf(input, key);

            // assert
            Assert.Equal(expectedIndex, actualIndex);
        }
    }
}
