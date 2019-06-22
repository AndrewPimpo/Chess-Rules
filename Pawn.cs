using System;
using System.Collections.Generic;
using static System.Console;
namespace Chess.Droid
{
    public class Pawn
    {

        //Initialize class elements
        private List<int[]> _possibleMoves;

        //Method to Gather moves
        List<int[]> gatherMoves()
        {

            int[] currPos = { PosX, PosY };

            //If first move, Pawn can move X + 2 and X + 1
            if (currPos == InitialPos)
            {
                PossibleMoves.Add(new int[] { (PosX + 2), PosY });
                PossibleMoves.Add(new int[] { (PosX + 1), PosY });
            }
            else
            {
                PossibleMoves.Add(new int[] { (PosX + 1), PosY });
            }

            //If enemy is at X + 1 and Y + 1
            //We'll do that later

            WriteLine("Pawn Moves total: " + PossibleMoves.Count);

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
