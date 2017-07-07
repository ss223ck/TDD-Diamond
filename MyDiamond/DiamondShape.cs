using System;

namespace MyDiamond
{
    public class DiamondShape
    {
        private int _diamondSize;

        public int DiamondSize { get {return _diamondSize;} }

        public DiamondShape(int diamondSize)
        {
            if(diamondSize%2 != 0)
                this._diamondSize = diamondSize;
            else
                throw new Exception("The constructor can only take uneven numbers");
        }

        public string createDiamond()
        {
            throw new NotImplementedException();
        }

        public string createRow(int rowCount)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    
    }
}