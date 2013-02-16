using System;
using System.Collections;

namespace Craps
{
    /// <summary>
    /// Creates a game of craps - includes players + dice
    /// </summary>
    class Game
    {
        // Member variables
        public Dice dice = new Dice();
        private bool isFirstRoll, isWinner, isLoser;
        private int point, bank, bet;
        public Player player1;

        // Accessors and Mutators
        public bool IsFirstRoll { get { return this.isFirstRoll; } }
        public bool IsWinner { get { return this.isWinner; } }
        public bool IsLoser { get { return this.isLoser; } }
        public int Point { get {return this.point; } }
        public int Bank { get; set; }
        public int Bet { get; set; }
        public int PlayerTotal { get; set; }
        public int HouseTotal { get; set; }

        public Game()
        {
            this.ResetGame();
        }

        public void ResetGame()
        {
            this.dice = new Dice();
            this.isFirstRoll = true;
            this.isWinner = false;
            this.isLoser = false;
            this.point = 0;
        }

        public void RollDice()
        {
            this.dice.Roll();
            this.SetValues();
        }

        /// <summary>
        /// Determines Winner, Loser, or Point
        /// </summary>
        private void SetValues()
        {
            //If this is first roll
            if (true == this.isFirstRoll)
            {
                this.isFirstRoll = false;
                //First Roll + Total of 7 or 11 - Winner
                if (7 == this.dice.Total || 11 == this.dice.Total)
                {
                    //Winner
                    this.isWinner = true;
                }
                //First Roll + Total of 2, 3, or 12 - Loser
                else if (2 == this.dice.Total || 3 == this.dice.Total || 12 == this.dice.Total)
                {
                    //Loser
                    this.isLoser = true;
                }
                //else if (4 == this.dice.Total || 5 == this.dice.Total ||6 == this.dice.Total || 
                //        8 == this.dice.Total || 9 == this.dice.Total || 10 == this.dice.Total)

                //Point
                this.point = this.dice.Total;
            }//end outer if
            //This is not the first roll
            else if (false == this.isFirstRoll)
            {
                //Not First Roll + Total is 7
                if (7 == this.dice.Total)
                {
                    //Loser
                    this.isLoser = true;
                }
                //Not First Roll + Total=Point - Winner
                else if (this.dice.Total == this.point)
                {
                    //Winner
                    this.isWinner = true;
                }//end inner if
            }//end outer if
        }//Set Values
    }
}
