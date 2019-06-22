using System;
using System.Collections.Generic;
using static System.Console;
namespace Chess.Droid
{
    public class Horse
    {
        //Initialize class elements
        private List<int[]> _possibleMoves;

        //Method to Gather moves
        List<int[]> gatherMoves()
        {

            int[] currPos = { PosX, PosY };
            int a = 0;
            int b = 0;

            //2 spaces in one dimension and 1 space in another are allowed - never 2 in both or 1 in both
            while (b < 3)
            {
                //trip integer
                int trip = 0;

                if(a == 0)
                {
                    //a=1 b=2 First
                    a = 1;
                    b = 2;
                }
                else if(a == 1 || b == 2)
                {
                    //If this is 4th interval - set trip
                    if (a == -1)
                        trip = 1;

                    //a=-1 b=-2 Second OR a=1 b=-2 Fourth
                    a = -a;
                    b = -b;
                }
                else
                {
                    //a=-1 b=2 Third
                    b = -b;
                }

                //Adds values if they are within the board parameters
                int Xa = PosX + a;
                int Yb = PosY + b;
                if (Xa < 8 && Xa > 0 && Yb < 8 && Yb > 0)
                    PossibleMoves.Add(new int[] { Xa, Yb });

                int Xb = PosX + b;
                int Ya = PosY + a;
                if (Xb < 8 && Xb > 0 && Ya < 8 && Ya > 0)
                    PossibleMoves.Add(new int[] { Xb, Ya });

                b = b + trip;
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
