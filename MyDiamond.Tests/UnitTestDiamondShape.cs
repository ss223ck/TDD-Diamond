using System;
using Xunit;
using MyDiamond;

namespace MyDiamond.Tests
{
    public class UnitTestDiamondShape
    {
        [Fact]
        public void TestConstructor()
        {
            int expected = 11;
            int actual;
            DiamondShape diamondShape = new DiamondShape(expected);

            actual = diamondShape.DiamondSize;

            Assert.Equal(expected, actual);
        }
    }
}
