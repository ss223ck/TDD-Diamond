using System;

namespace MyDiamond
{
    public class DiamondShape
    {
        private int _diamondSize;
        private string[] _diamondRows;

        public int DiamondSize { get {return _diamondSize;} }

        public DiamondShape(int diamondSize)
        {
            if(diamondSize%2 != 0)
                this._diamondSize = diamondSize;
            else
                throw new Exception("The constructor can only take uneven numbers");
        }

        public string CreateDiamond()
        {
            throw new NotImplementedException();
        }

        public string CreateRow(int rowCount)
        {
            string diamondRow = "";
            string diamonds = "";
            int amountOfDiamonds = 0;
            int amountOfWhiteSpaces = 0;
            
            amountOfDiamonds = 1 + ((rowCount - 1) * 2);
            amountOfWhiteSpaces = DiamondSize - amountOfDiamonds;
            
            for(int i = 0; i < amountOfWhiteSpaces; i++)
            {
                diamondRow = diamondRow + " ";
            }

            for(int j = 0; j < amountOfDiamonds; j++)
            {
                diamonds = diamonds + "*";
            }

            diamondRow = diamondRow.Insert(amountOfWhiteSpaces/2, diamonds);

            return diamondRow;
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    
    }
}