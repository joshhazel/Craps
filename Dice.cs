using System;
namespace Craps
{
    /// <summary>
    /// Creates a pair of two dice values 1-6
    /// </summary>
    class Dice
    {
        //Member variables
        private int die1, die2, dieTotal;

        //Constructors
        public Dice() 
        { 
            this.Roll();
        }

        //Accessors and Mutators
        public int Die1 { get { return this.die1;} }
        public int Die2 { get { return this.die2; } }
        public int Total { get { return this.dieTotal; } }

        //Methods
        public void Roll()
        {
            //Create 2 random int betwen 1-6
            Random rnd = new Random();
            this.die1 = rnd.Next(1, 7);
            this.die2 = rnd.Next(1, 7);
            //Set die1 and die 2 values
            this.dieTotal = die1 + die2;
        }
    }
}
