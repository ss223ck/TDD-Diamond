using System;

namespace MyDiamond
{
    public class DiamondShape
    {
        private int _diamondSize;
        private string[] _diamondRows;

        public int DiamondSize { get {return _diamondSize;} }
        public string[] DiamondRows { get {return _diamondRows;} }

        public DiamondShape(int diamondSize)
        {
            if(diamondSize%2 != 0)
            {
                this._diamondSize = diamondSize;
                this._diamondRows = new string[diamondSize];
            }
            else
                throw new Exception("The constructor can only take uneven numbers");
        }

        public void CreateDiamond()
        {
            int loopCount = (DiamondSize + 1) / 2;
            string diamondRow = "";

            for(int i = 1; i <= loopCount; i++)
            {
                diamondRow = CreateRow(i);
                _diamondRows[i-1] = diamondRow;
                _diamondRows[DiamondSize-i] = diamondRow;
            }
        }

        public string CreateRow(int rowCount)
        {
            string diamondRow = "";
            string diamonds = "";
            int amountOfDiamonds = 0;
            int amountOfWhiteSpaces = 0;
            
            amountOfDiamonds = 1 + ((rowCount - 1) * 2);
            amountOfWhiteSpaces = DiamondSize - amountOfDiamonds;
            
            diamondRow = CreateWhiteSpaceString(amountOfWhiteSpaces);
            
            diamonds = CreateDiamondsString(amountOfDiamonds);

            diamondRow = diamondRow.Insert(amountOfWhiteSpaces/2, diamonds);

            return diamondRow;
        }

        public string CreateWhiteSpaceString(int amountOfWhiteSpaces)
        {
            string diamondRow = "";
            for(int i = 0; i < amountOfWhiteSpaces; i++)
            {
                diamondRow = diamondRow + " ";
            }
            return diamondRow;
        }

        public string CreateDiamondsString(int amountOfDiamonds)
        {
            string diamonds = "";

            for(int j = 0; j < amountOfDiamonds; j++)
            {
                diamonds = diamonds + "*";
            }
            return diamonds;
        }

        public override string ToString()
        {
            string consoleFormat = "";

            foreach(string s in DiamondRows)
            {
                consoleFormat = consoleFormat + "\n " + s;
            }

            return consoleFormat;
        }
    
    }
}