using System;

namespace Craps
{
    class Player
    {
        //Member variables
        private int balance;
        private String name;

        //Constructors
        public Player() : this("Player 1", 0) {}
        public Player(string name) : this(name, 0) {}
        public Player(int balance) : this("Player 1", balance) {}
        public Player(string name, int balance)
        {
            this.name = name; this.balance = balance;
        }

        //Accessors and Mutators - Properties
        public int Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }
        public String Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        
        //Methods
    }
}
