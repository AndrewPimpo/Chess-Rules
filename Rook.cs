using System;
using System.Collections.Generic;
using static System.Console;
namespace Chess.Droid
{
    public class Rook
    {
        //Initialize class elements
        private List<int[]> _possibleMoves;

        //Method to Gather moves
        List<int[]> gatherMoves()
        {

            int[] currPos = { PosX, PosY };

            //Single dimensional movement is free (so long as space is not occupied)
            for (int i = 1; i <= 8 - PosX; i++)
            {
                PossibleMoves.Add(new int[] { PosX + i, PosY });
            }
            for (int i = 1; i <= 8 - PosY; i++)
            {
                PossibleMoves.Add(new int[] { PosX, PosY + i });
            }

            //As is negative movement
            for (int i = -1; i >= PosX - 8; i--)
            {
                PossibleMoves.Add(new int[] { PosX + i, PosY });
            }
            for (int i = -1; i >= PosY - 8; i--)
            {
                PossibleMoves.Add(new int[] { PosX, PosY + i });
            }


            //Check
            WriteLine("Rook Moves total: " + PossibleMoves.Count);

            //Send Moves
            return PossibleMoves;
        }

        //Properties
        List<int[]> PossibleMoves { get { return _possibleMoves; } set { _possibleMoves = value; } }
        public int PosX { get; set; }
        public int PosY { get; set; }
        public int[] InitialPos { get; set; }
    }
}
