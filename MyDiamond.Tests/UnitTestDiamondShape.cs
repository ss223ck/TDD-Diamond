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

        [Fact]
        public void TestConstructorOnlyAcceptUneven()
        {   
            bool constructThrewExcept = false;
            
            try
            {
                MyDiamond.DiamondShape myDiamond = new MyDiamond.DiamondShape(2);
            }
            catch (System.Exception)
            {
                constructThrewExcept = true;
            }

            Assert.True(constructThrewExcept);
        }

        [Fact]
        public void TestCreateRow()
        {   
            MyDiamond.DiamondShape myDiamond = new MyDiamond.DiamondShape(3);
            string expected = " * ";
            string actual;

            actual = myDiamond.createRow(1);
            
            Assert.Equal(expected, actual);
        }
    }
}
