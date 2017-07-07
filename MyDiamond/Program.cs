using System;

namespace MyDiamond
{
    class Program
    {
        static void Main(string[] args)
        {
            DiamondShape myDiamond = new DiamondShape(5);

            myDiamond.CreateRow(1);
        }
    }
}
