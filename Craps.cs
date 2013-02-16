/*
 * Joshua Hazel
 * CSCD 306 .NET
 * Assignment 3
 * Craps Dice Game
 * 
 * Notes:
 * 1)   Created 'Game', 'Player', 'Dice' classes.
 *          Game contains player and dice objects
 *          Game handles general game stuff (check win, contains dice and players)
 *          Player handles player stuff (name, cash)
 *          Dice handles the dice stuff (rolling, counting)
 * 2)   System Tray Icon
 * 3)   ToolStrip (Toolbar)
 * 4)   Music Playing (Toolbar Control)
 * 5)   Sound effects (rolling dice, winning, losing)
 * 6)   PictureBox (die1 & die2, shuffles dice images as well)
 * 
 */

using System; //General
using System.Media; //Audio
using System.Text; //StringBuilder
using System.Windows.Forms; //Form
using Microsoft.VisualBasic;
using System.IO; //InputBox


namespace Craps
{
    public partial class Craps : Form 
    {
        //Member variables
        private MainMenu mainMenu;
        private StatusBar statusBar = new StatusBar();
            private StatusBarPanel sbPnlPrompt = new StatusBarPanel();
            private StatusBarPanel sbPnlTime = new StatusBarPanel();
            private Timer timer1 = new Timer();
        private Game game;
        private SoundPlayer sound = new SoundPlayer();
        private bool endDiceRoll;

        public Craps()
        {
            InitializeComponent();
            
            // Configure the timer.
                timer1.Interval = 1000;
                timer1.Enabled = true;
                timer1.Tick += new EventHandler(timer1_Tick);
                this.MenuComplete += new EventHandler(StatusForm_MenuDone); 

            CreateMenu();
            CreateStatusBar();
            SetFormLayout();

            this.game = new Game();
        }

        //****************************
        // Create the Menu
        //****************************

        private void CreateMenu()
        {
            //Create menu
            mainMenu = new MainMenu();

            //Create Game menu
            MenuItem miGame = mainMenu.MenuItems.Add("&Game");
            //Add items
            miGame.MenuItems.Add(new MenuItem("&Start",
                new EventHandler(this.GameStart_Clicked),
                Shortcut.CtrlS));
                miGame.MenuItems[0].Select += new EventHandler(GameStart_Selected);
            miGame.MenuItems.Add(new MenuItem("&Reset",
                new EventHandler(this.GameReset_Clicked),
                Shortcut.CtrlR));
                miGame.MenuItems[1].Select += new EventHandler(GameReset_Selected);
            miGame.MenuItems.Add(new MenuItem("E&xit",
                new EventHandler(this.GameExit_Clicked),
                Shortcut.CtrlX));
                miGame.MenuItems[2].Select += new EventHandler(GameExit_Selected);

            //Create 'Help' menu
            MenuItem miHelp = mainMenu.MenuItems.Add("&Help");
            //Add items
            miHelp.MenuItems.Add(new MenuItem("&Rules",
                new EventHandler(this.HelpRules_Clicked),
                Shortcut.CtrlU));
                miHelp.MenuItems[0].Select += new EventHandler(this.HelpRules_Selected);
            miHelp.MenuItems.Add(new MenuItem("&About",
                    new EventHandler(this.HelpAbout_Clicked),
                    Shortcut.CtrlH));
                miHelp.MenuItems[1].Select += new EventHandler(this.HelpAbout_Selected);

            //Attach main menu to the Form object.
            this.Menu = mainMenu;
        }//CreateMenu



        //*************************
        //Game Menu Event Handlers
        //*************************
        
        // Game | Exit
        private void GameExit_Clicked(object sender, EventArgs e)
        {
            this.Close();
        }
        private void GameExit_Selected(object sender, EventArgs e)
        {
            sbPnlPrompt.Text = "Exit the Program";
        }

        private void GameStart_Clicked(object sender, EventArgs e)
        {
            this.GameStart();
            this.GameReset();
        }
        private void GameStart_Selected(object sender, EventArgs e)
        {
            sbPnlPrompt.Text = "Start Game";
        }
        private void GameStart()
        {
            //Fields specific to starting a new session, not a new roll/bet
            this.btnRollDice.Enabled = true;
            this.btnRollDice.Select();
            this.txtPlayerTotal.Text = "0";
            this.txtHouseTotal.Text = "0";
            this.game.PlayerTotal = 0;
            this.game.HouseTotal = 0;

            //Fields specific to starting a new roll/bet only, not a new game
            this.GameReset();

            GetStartingAmount();

            //Play music
            PlaySound("Music");
        }

        private void GetStartingAmount()
        {
            string input = "";
            int amount = 0;
            while (true)
            {
                input = Microsoft.VisualBasic.Interaction.InputBox(
                    "Provide initial bank account amount\n" + 
                    "(Enter 0, leave blank, or press cancel if you are not betting)",
                    "Enter Starting Balance for Betting", "");

                //"" means doesnt want to bet
                if ("" == input)
                {
                    this.groupBet.Visible = false;
                    return;
                }
                //Valid number given
                else if (Int32.TryParse(input, out amount) == true)
                {
                    //0 means doesnt want to bet
                    if (0 == amount)
                    {
                        this.groupBet.Visible = false;
                        return;
                    }
                    //User wants to make bets
                    else
                    {
                        this.groupBet.Visible = true;
                        this.txtBalance.Text = amount.ToString();
                        this.game.player1 = new Player(amount);
                        return;
                    }//end inner if
                }//end outer if
            }//end while
        }

        // Game | Reset
        private void GameReset_Clicked(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to reset your game?", "Reset Game",
                MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
            if (result == DialogResult.No)
                return;
                
            this.GameReset();
        }
        private void GameReset_Selected(object sender, EventArgs e)
        {
            sbPnlPrompt.Text = "Reset Game";
        }
        private void GameReset()
        {
            //Reset dice & point
            this.txtDie1.Text = "";
            this.txtDie2.Text = "";
            this.txtTotal.Text = "";
            this.txtPoint.Text = "";

            //Reset the values in game
            this.game.ResetGame();
            
            //Reset WinLose label
            this.lblWinLose.Text = "";
            this.lblWinLose.Visible = false;
            
            //Reset the bet
            if (this.groupBet.Visible == true)
            {
                this.spinBet.Enabled = true;
                this.spinBet.Maximum = this.game.player1.Balance;

                //Check if bet amount > remaining balance, if so set bet to max allowed
                if (this.spinBet.Value > this.spinBet.Maximum)
                    this.spinBet.Value = this.spinBet.Maximum;
            }

            //Reset buttons
            this.btnPlayAgain.Enabled = false;
            this.btnRollDice.Enabled = true;
            this.btnRollDice.Select();
            
        }

        //*************************
        //Help Menu Event Handlers
        //*************************

        //Help | Game Rules
        private void HelpRules_Clicked(object sender, EventArgs e)
        {
            this.HelpRules();
        }
        private void HelpRules()
        {
            string str = 
                "The rules of the Game of craps are as follows:\n" + 
                "A player rolls two dice where each die has six faces in the usual way (values 1 through 6).\n\n" +

                "After the dice have come to rest the sum of the two upward faces is calculated.\n\n" +

                "The first roll\n" +
                "If the sum is 7 or 11 on the first throw the roller/player wins.\n" +
                "If the sum is 2, 3 or 12 the roller/player loses, that is the house wins.\n" +
                "If the sum is 4, 5, 6, 8, 9, or 10, that sum becomes the player's 'point'.\n\n" +
            
                "Continue given the player's point\n" +
                "Now the player must roll the 'point' total before rolling a 7 to win.\n" +
                "If they roll a 7 before rolling the point value they got on the first roll the roller/player loses (the 'house' wins).";

            MessageBox.Show(this, str, "Rules", MessageBoxButtons.OK,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }
        private void HelpRules_Selected(object sender, EventArgs e)
        {
            sbPnlPrompt.Text = "Game Rules";
        }

        //Help | About
        private void HelpAbout_Clicked(object sender, EventArgs e)
        {
            HelpAbout();
        }
        private void HelpAbout()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine("Developed by Joshua Hazel\n");
            str.AppendLine("Version 1.0.0");
            str.AppendLine(".NET Version");
            str.AppendLine(Environment.Version.ToString());
            str.AppendLine(Environment.OSVersion.ToString());
            if (Environment.Is64BitOperatingSystem)
                str.AppendLine("64-Bit");
            else
                str.AppendLine("32-Bit");

            MessageBox.Show(this, str.ToString(), "About", MessageBoxButtons.OK,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }//About
        private void HelpAbout_Selected(object sender, EventArgs e)
        {
            sbPnlPrompt.Text = "About";
        }

        //*************************
        // Menu Done Event Handler
        //*************************
        private void StatusForm_MenuDone(object sender, EventArgs e)
        {
            this.sbPnlPrompt.Text = "Ready";
        }

        
        //*************************
        // Context Menu Events
        // ************************
        private void contextMenuStrip1Show_Click(object sender, EventArgs e)
        {
            this.Show();
        }
        private void contextMenuStrip1Hide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void contextMenuStrip1Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //*************************
        // ToolBar Handlers
        //*************************
        private void ToolBarMusic_Click(object sender, EventArgs e)
        {
            if (toolBtnMusic.Checked == false)
            {
                toolBtnMusic.Image = Properties.Resources.Speaker_On;
                sound.PlayLooping();
            }
            else
            {
                sound.Stop();
                toolBtnMusic.Image = Properties.Resources.Speaker_Off;
            }
        }

        //*************************
        // Create Status Bar
        //*************************

        //Create status bar
        private void CreateStatusBar()
        {
                //Configure the status bar.
                statusBar.ShowPanels = true;
                statusBar.Panels.AddRange(new StatusBarPanel[] { sbPnlPrompt, sbPnlTime });

                // Configure prompt panel.
                sbPnlPrompt.BorderStyle = StatusBarPanelBorderStyle.None;
                sbPnlPrompt.AutoSize = StatusBarPanelAutoSize.Spring;
                sbPnlPrompt.Width = 62;
                sbPnlPrompt.Text = "Ready";

                // Configure time pane.
                //sbPnlTime.BorderStyle = StatusBarPanelBorderStyle.Sunken;
                sbPnlTime.Alignment = HorizontalAlignment.Right;
                sbPnlTime.Width = 76;
                sbPnlTime.ToolTipText = System.DateTime.Now.ToShortTimeString();
            
            this.Controls.Add(statusBar);
        }
        //Timer tick event for status bar
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime t = DateTime.Now;
            string s = t.ToLongTimeString();
            sbPnlTime.Text = s;
        }

        /// <summary>
        /// Sets properties for the form and controls
        /// </summary>
        private void SetFormLayout()
        {
            //Form properties
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Craps Game";
            this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle; //Disable resizing

            //Disable Controls
            this.btnPlayAgain.Enabled = false;
            this.btnRollDice.Enabled = false;
            
            //Invisible Controls
            this.groupBet.Visible = false;
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            this.GameReset();
        }

        // Handle Form Closing
        private void Craps_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Quit Game", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        //Handle Roll Dice button click
        private void btnRollDice_Click(object sender, EventArgs e)
        {

            //Play dice rolling sound, disable roll button, and enable timer
            this.PlaySound("Dice");
            btnRollDice.Enabled = false;
            this.timerDice.Enabled = true;

            //Disable the betting after first dice roll
            if (this.spinBet.Enabled == true)
            {
                this.spinBet.Enabled = false;
                this.game.Bet = (int)this.spinBet.Value;
            }

            //Roll the Game 'dice'
            this.game.RollDice();

            //Do not check for winner until time has elapsed for
            //Dice and Sound to finish playing on timer as well
            //CheckWin() is called from the timer event for dice sound below
        }

        
        private void CheckWin()
        {
            //Set final dice image
            SetDicePicture(this.game.dice.Die1, pictureDie1);
            SetDicePicture(this.game.dice.Die2, pictureDie2);


            //Set dice values in user form
            this.txtDie1.Text = this.game.dice.Die1.ToString();
            this.txtDie2.Text = this.game.dice.Die2.ToString();
            this.txtTotal.Text = this.game.dice.Total.ToString();

            //Check if Won-Lost-Point
            if (this.game.IsWinner)
            { this.Won(); }
            else if (this.game.IsLoser)
            { this.Lost(); }
            else if (this.game.Point > 0)
            { 
                this.txtPoint.Text = this.game.Point.ToString();
                this.btnRollDice.Enabled = true;
            }

            
        }

        //Randomly display two different dice images
        private void RandomDicePicture()
        {
            Random rnd = new Random();
            int rndNum = 0;
            rndNum = rnd.Next(1, 7);
            SetDicePicture(rndNum,pictureDie1);
            rndNum = rnd.Next(1, 7);
            SetDicePicture(rndNum, pictureDie2);
        }
        private void SetDicePicture(int die, PictureBox picture)
        {

            switch (die)
            {
                case 1:
                    picture.Image = Properties.Resources.dice1;
                    break;
                case 2:
                    picture.Image = Properties.Resources.dice2;
                    break;
                case 3:
                    picture.Image = Properties.Resources.dice3;
                    break;
                case 4:
                    picture.Image = Properties.Resources.dice4;
                    break;
                case 5:
                    picture.Image = Properties.Resources.dice5;
                    break;
                case 6:
                    picture.Image = Properties.Resources.dice6;
                    break;
            }
        }

        //Player wins
        private void Won()
        {
            //Play sound
            this.PlaySound("Won");

            //Betting controls, allow betting again
            if (this.groupBet.Visible == true)
            {
                this.game.player1.Balance += this.game.Bet;
                this.txtBalance.Text = this.game.player1.Balance.ToString();
            }
            this.game.PlayerTotal += 1;
            this.txtPlayerTotal.Text = this.game.PlayerTotal.ToString();

            //Winner Label
            this.lblWinLose.Text = "Winner!!";
            this.lblWinLose.Visible = true;

            //Enable-Disable Buttons
            this.btnRollDice.Enabled = false;
            this.btnPlayAgain.Enabled = true;
            this.btnPlayAgain.Select();
        }

        //Player loses
        private void Lost()
        {
            //Play sound
            this.PlaySound("Lost");

            //Betting == true
            if (this.groupBet.Visible == true)
            {
                this.game.player1.Balance -= this.game.Bet;
                this.txtBalance.Text = this.game.player1.Balance.ToString();
                if (this.game.player1.Balance > 0)
                {
                    this.btnPlayAgain.Enabled = true;
                    this.btnPlayAgain.Select();
                    this.lblWinLose.Text = "Loser!";
                }
                else
                {
                    this.btnPlayAgain.Enabled = false;
                    this.lblWinLose.Text = "Loser!\nOUT OF MONEY!";
                }
            }
            else //Betting == false
            {
                this.lblWinLose.Text = "Loser!";
                this.btnPlayAgain.Enabled = true;
            }

            //Player-House Total Wins
            this.game.HouseTotal += 1;
            this.txtHouseTotal.Text = this.game.HouseTotal.ToString();

            //Enable-Disable Buttons (btnPlayAgain under if[])
            this.btnRollDice.Enabled = false;

            //Loser Label
            this.lblWinLose.Visible = true;
        }//end Lost()

        private void PlaySound(string media)
        {
            //Do not play sound if muted
            if (this.toolBtnMusic.Checked == true)
                return;

            //Select sound to play
            switch(media)
            {
                //Play sound basd on timer / length of sound
                case "Won":
                    //Play sound
                    this.sound.Stream = Properties.Resources.applause_light_02;
                    timerSound.Interval = 2000;
                    break;
                case "Lost":
                    this.sound.Stream = Properties.Resources.crowd_groan_02;
                    timerSound.Interval = 1500;
                    break;
                case "Dice":
                    this.sound.Stream = Properties.Resources.Shake_And_Roll_Dice;
                    timerSound.Interval = 2000;
                    timerCheckWin.Interval = 2100;
                    timerCheckWin.Enabled = true;
                    break;
                case "Music":
                    this.sound.Stream = Properties.Resources.PhotoOp;
                    this.sound.PlayLooping();
                    return;
                default:
                    return;
            }

            //Enable timer
            timerSound.Enabled = true;

            //Play sound
            this.sound.Play();
        }

        //Timer for sound
        private void timerSound_Elapsed(object sender, EventArgs e)
        {
            //Set sound back to music, and play it
            this.sound.Stream = Properties.Resources.PhotoOp;
            this.sound.PlayLooping();
            this.timerSound.Enabled = false;

            //Make sure dice are not still rolling
            this.timerDice.Enabled = false;
        }

        //Display random dice image ever 50 ms until timerDice disabled
        private void timerDice_Tick(object sender, EventArgs e)
        {
            RandomDicePicture();
        }

        private void timerCheckWin_Tick(object sender, EventArgs e)
        {
            timerCheckWin.Enabled = false;
            CheckWin();
        }


    }//Craps Form
}
