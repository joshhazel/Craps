namespace Craps
{
    partial class Craps
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Craps));
            this.btnRollDice = new System.Windows.Forms.Button();
            this.txtPoint = new System.Windows.Forms.TextBox();
            this.groupCurrRoll = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDie2 = new System.Windows.Forms.Label();
            this.lblDie1 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtDie1 = new System.Windows.Forms.TextBox();
            this.txtDie2 = new System.Windows.Forms.TextBox();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.lblWinLose = new System.Windows.Forms.Label();
            this.lblPoint = new System.Windows.Forms.Label();
            this.txtPlayerTotal = new System.Windows.Forms.TextBox();
            this.txtHouseTotal = new System.Windows.Forms.TextBox();
            this.groupWinTotals = new System.Windows.Forms.GroupBox();
            this.lblHouseTotal = new System.Windows.Forms.Label();
            this.lblPlayerTotal = new System.Windows.Forms.Label();
            this.spinBet = new System.Windows.Forms.NumericUpDown();
            this.lblBet = new System.Windows.Forms.Label();
            this.groupBet = new System.Windows.Forms.GroupBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolbar = new System.Windows.Forms.ToolStrip();
            this.toolBtnHelp = new System.Windows.Forms.ToolStripButton();
            this.toolBtnMusic = new System.Windows.Forms.ToolStripButton();
            this.pictureDie1 = new System.Windows.Forms.PictureBox();
            this.pictureDie2 = new System.Windows.Forms.PictureBox();
            this.timerSound = new System.Windows.Forms.Timer(this.components);
            this.timerDice = new System.Windows.Forms.Timer(this.components);
            this.timerCheckWin = new System.Windows.Forms.Timer(this.components);
            this.groupCurrRoll.SuspendLayout();
            this.groupWinTotals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinBet)).BeginInit();
            this.groupBet.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.toolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDie1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDie2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRollDice
            // 
            this.btnRollDice.Enabled = false;
            this.btnRollDice.Location = new System.Drawing.Point(12, 28);
            this.btnRollDice.Name = "btnRollDice";
            this.btnRollDice.Size = new System.Drawing.Size(147, 35);
            this.btnRollDice.TabIndex = 0;
            this.btnRollDice.Text = "&Roll Dice";
            this.btnRollDice.UseVisualStyleBackColor = true;
            this.btnRollDice.Click += new System.EventHandler(this.btnRollDice_Click);
            // 
            // txtPoint
            // 
            this.txtPoint.Location = new System.Drawing.Point(56, 118);
            this.txtPoint.Name = "txtPoint";
            this.txtPoint.ReadOnly = true;
            this.txtPoint.Size = new System.Drawing.Size(108, 20);
            this.txtPoint.TabIndex = 2;
            this.txtPoint.TabStop = false;
            // 
            // groupCurrRoll
            // 
            this.groupCurrRoll.Controls.Add(this.lblTotal);
            this.groupCurrRoll.Controls.Add(this.lblDie2);
            this.groupCurrRoll.Controls.Add(this.lblDie1);
            this.groupCurrRoll.Controls.Add(this.txtTotal);
            this.groupCurrRoll.Controls.Add(this.txtDie1);
            this.groupCurrRoll.Controls.Add(this.txtDie2);
            this.groupCurrRoll.Location = new System.Drawing.Point(208, 32);
            this.groupCurrRoll.Name = "groupCurrRoll";
            this.groupCurrRoll.Size = new System.Drawing.Size(200, 112);
            this.groupCurrRoll.TabIndex = 3;
            this.groupCurrRoll.TabStop = false;
            this.groupCurrRoll.Text = "Current Roll";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(14, 89);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "Total";
            // 
            // lblDie2
            // 
            this.lblDie2.AutoSize = true;
            this.lblDie2.Location = new System.Drawing.Point(14, 54);
            this.lblDie2.Name = "lblDie2";
            this.lblDie2.Size = new System.Drawing.Size(32, 13);
            this.lblDie2.TabIndex = 10;
            this.lblDie2.Text = "Die 2";
            // 
            // lblDie1
            // 
            this.lblDie1.AutoSize = true;
            this.lblDie1.Location = new System.Drawing.Point(14, 28);
            this.lblDie1.Name = "lblDie1";
            this.lblDie1.Size = new System.Drawing.Size(32, 13);
            this.lblDie1.TabIndex = 7;
            this.lblDie1.Text = "Die 1";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(84, 86);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 7;
            this.txtTotal.TabStop = false;
            // 
            // txtDie1
            // 
            this.txtDie1.Location = new System.Drawing.Point(84, 25);
            this.txtDie1.Name = "txtDie1";
            this.txtDie1.ReadOnly = true;
            this.txtDie1.Size = new System.Drawing.Size(100, 20);
            this.txtDie1.TabIndex = 9;
            this.txtDie1.TabStop = false;
            // 
            // txtDie2
            // 
            this.txtDie2.Location = new System.Drawing.Point(84, 51);
            this.txtDie2.Name = "txtDie2";
            this.txtDie2.ReadOnly = true;
            this.txtDie2.Size = new System.Drawing.Size(100, 20);
            this.txtDie2.TabIndex = 8;
            this.txtDie2.TabStop = false;
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.Location = new System.Drawing.Point(12, 331);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(147, 35);
            this.btnPlayAgain.TabIndex = 1;
            this.btnPlayAgain.Text = "&Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // lblWinLose
            // 
            this.lblWinLose.AutoSize = true;
            this.lblWinLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinLose.ForeColor = System.Drawing.Color.Red;
            this.lblWinLose.Location = new System.Drawing.Point(160, 328);
            this.lblWinLose.Name = "lblWinLose";
            this.lblWinLose.Size = new System.Drawing.Size(126, 31);
            this.lblWinLose.TabIndex = 5;
            this.lblWinLose.Text = "WinLose";
            this.lblWinLose.Visible = false;
            // 
            // lblPoint
            // 
            this.lblPoint.AutoSize = true;
            this.lblPoint.Location = new System.Drawing.Point(10, 125);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(31, 13);
            this.lblPoint.TabIndex = 6;
            this.lblPoint.Text = "Point";
            // 
            // txtPlayerTotal
            // 
            this.txtPlayerTotal.Location = new System.Drawing.Point(120, 19);
            this.txtPlayerTotal.Name = "txtPlayerTotal";
            this.txtPlayerTotal.ReadOnly = true;
            this.txtPlayerTotal.Size = new System.Drawing.Size(100, 20);
            this.txtPlayerTotal.TabIndex = 10;
            this.txtPlayerTotal.TabStop = false;
            this.txtPlayerTotal.Text = "0";
            // 
            // txtHouseTotal
            // 
            this.txtHouseTotal.Location = new System.Drawing.Point(120, 64);
            this.txtHouseTotal.Name = "txtHouseTotal";
            this.txtHouseTotal.ReadOnly = true;
            this.txtHouseTotal.Size = new System.Drawing.Size(100, 20);
            this.txtHouseTotal.TabIndex = 11;
            this.txtHouseTotal.TabStop = false;
            this.txtHouseTotal.Text = "0";
            // 
            // groupWinTotals
            // 
            this.groupWinTotals.Controls.Add(this.lblHouseTotal);
            this.groupWinTotals.Controls.Add(this.lblPlayerTotal);
            this.groupWinTotals.Controls.Add(this.txtPlayerTotal);
            this.groupWinTotals.Controls.Add(this.txtHouseTotal);
            this.groupWinTotals.Location = new System.Drawing.Point(157, 225);
            this.groupWinTotals.Name = "groupWinTotals";
            this.groupWinTotals.Size = new System.Drawing.Size(235, 100);
            this.groupWinTotals.TabIndex = 4;
            this.groupWinTotals.TabStop = false;
            this.groupWinTotals.Text = "Win Totals";
            // 
            // lblHouseTotal
            // 
            this.lblHouseTotal.AutoSize = true;
            this.lblHouseTotal.Location = new System.Drawing.Point(6, 67);
            this.lblHouseTotal.Name = "lblHouseTotal";
            this.lblHouseTotal.Size = new System.Drawing.Size(87, 13);
            this.lblHouseTotal.TabIndex = 13;
            this.lblHouseTotal.Text = "House Win Total";
            // 
            // lblPlayerTotal
            // 
            this.lblPlayerTotal.AutoSize = true;
            this.lblPlayerTotal.Location = new System.Drawing.Point(6, 26);
            this.lblPlayerTotal.Name = "lblPlayerTotal";
            this.lblPlayerTotal.Size = new System.Drawing.Size(90, 13);
            this.lblPlayerTotal.TabIndex = 12;
            this.lblPlayerTotal.Text = "Player Win Totals";
            // 
            // spinBet
            // 
            this.spinBet.Location = new System.Drawing.Point(20, 50);
            this.spinBet.Name = "spinBet";
            this.spinBet.Size = new System.Drawing.Size(83, 20);
            this.spinBet.TabIndex = 1;
            // 
            // lblBet
            // 
            this.lblBet.AutoSize = true;
            this.lblBet.Location = new System.Drawing.Point(17, 31);
            this.lblBet.Name = "lblBet";
            this.lblBet.Size = new System.Drawing.Size(52, 13);
            this.lblBet.TabIndex = 8;
            this.lblBet.Text = "Amount $";
            // 
            // groupBet
            // 
            this.groupBet.Controls.Add(this.txtBalance);
            this.groupBet.Controls.Add(this.lblBalance);
            this.groupBet.Controls.Add(this.spinBet);
            this.groupBet.Controls.Add(this.lblBet);
            this.groupBet.Location = new System.Drawing.Point(13, 189);
            this.groupBet.Name = "groupBet";
            this.groupBet.Size = new System.Drawing.Size(137, 136);
            this.groupBet.TabIndex = 9;
            this.groupBet.TabStop = false;
            this.groupBet.Text = "Make a Bet";
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(6, 112);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBalance.Size = new System.Drawing.Size(97, 20);
            this.txtBalance.TabIndex = 2;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(6, 96);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(58, 13);
            this.lblBalance.TabIndex = 9;
            this.lblBalance.Text = "Balance: $";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.hideToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 70);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.showToolStripMenuItem.Text = "&Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.contextMenuStrip1Show_Click);
            // 
            // hideToolStripMenuItem
            // 
            this.hideToolStripMenuItem.Name = "hideToolStripMenuItem";
            this.hideToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.hideToolStripMenuItem.Text = "&Hide";
            this.hideToolStripMenuItem.Click += new System.EventHandler(this.contextMenuStrip1Hide_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.contextMenuStrip1Exit_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Craps";
            this.notifyIcon1.Visible = true;
            // 
            // toolbar
            // 
            this.toolbar.AllowItemReorder = true;
            this.toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnHelp,
            this.toolBtnMusic});
            this.toolbar.Location = new System.Drawing.Point(0, 0);
            this.toolbar.Name = "toolbar";
            this.toolbar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolbar.Size = new System.Drawing.Size(415, 25);
            this.toolbar.TabIndex = 10;
            this.toolbar.Text = "ToolStrip";
            // 
            // toolBtnHelp
            // 
            this.toolBtnHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnHelp.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnHelp.Image")));
            this.toolBtnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnHelp.Name = "toolBtnHelp";
            this.toolBtnHelp.Size = new System.Drawing.Size(23, 22);
            this.toolBtnHelp.Text = "He&lp";
            this.toolBtnHelp.Click += new System.EventHandler(this.HelpAbout_Clicked);
            // 
            // toolBtnMusic
            // 
            this.toolBtnMusic.CheckOnClick = true;
            this.toolBtnMusic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnMusic.Image = global::Craps.Properties.Resources.Speaker_On;
            this.toolBtnMusic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnMusic.Name = "toolBtnMusic";
            this.toolBtnMusic.Size = new System.Drawing.Size(23, 22);
            this.toolBtnMusic.Text = "Music On/Off";
            this.toolBtnMusic.Click += new System.EventHandler(this.ToolBarMusic_Click);
            // 
            // pictureDie1
            // 
            this.pictureDie1.Location = new System.Drawing.Point(257, 148);
            this.pictureDie1.Name = "pictureDie1";
            this.pictureDie1.Size = new System.Drawing.Size(59, 70);
            this.pictureDie1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureDie1.TabIndex = 11;
            this.pictureDie1.TabStop = false;
            // 
            // pictureDie2
            // 
            this.pictureDie2.Location = new System.Drawing.Point(333, 148);
            this.pictureDie2.Name = "pictureDie2";
            this.pictureDie2.Size = new System.Drawing.Size(59, 70);
            this.pictureDie2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureDie2.TabIndex = 12;
            this.pictureDie2.TabStop = false;
            // 
            // timerSound
            // 
            this.timerSound.Tick += new System.EventHandler(this.timerSound_Elapsed);
            // 
            // timerDice
            // 
            this.timerDice.Interval = 50;
            this.timerDice.Tick += new System.EventHandler(this.timerDice_Tick);
            // 
            // timerCheckWin
            // 
            this.timerCheckWin.Interval = 2100;
            this.timerCheckWin.Tick += new System.EventHandler(this.timerCheckWin_Tick);
            // 
            // Craps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 408);
            this.Controls.Add(this.pictureDie2);
            this.Controls.Add(this.pictureDie1);
            this.Controls.Add(this.toolbar);
            this.Controls.Add(this.groupBet);
            this.Controls.Add(this.groupWinTotals);
            this.Controls.Add(this.lblPoint);
            this.Controls.Add(this.lblWinLose);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.groupCurrRoll);
            this.Controls.Add(this.txtPoint);
            this.Controls.Add(this.btnRollDice);
            this.MaximizeBox = false;
            this.Name = "Craps";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game of Craps";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Craps_FormClosing);
            this.groupCurrRoll.ResumeLayout(false);
            this.groupCurrRoll.PerformLayout();
            this.groupWinTotals.ResumeLayout(false);
            this.groupWinTotals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinBet)).EndInit();
            this.groupBet.ResumeLayout(false);
            this.groupBet.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolbar.ResumeLayout(false);
            this.toolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDie1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDie2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRollDice;
        private System.Windows.Forms.TextBox txtPoint;
        private System.Windows.Forms.GroupBox groupCurrRoll;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDie2;
        private System.Windows.Forms.Label lblDie1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtDie1;
        private System.Windows.Forms.TextBox txtDie2;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Label lblWinLose;
        private System.Windows.Forms.Label lblPoint;
        private System.Windows.Forms.TextBox txtPlayerTotal;
        private System.Windows.Forms.TextBox txtHouseTotal;
        private System.Windows.Forms.GroupBox groupWinTotals;
        private System.Windows.Forms.Label lblHouseTotal;
        private System.Windows.Forms.Label lblPlayerTotal;
        private System.Windows.Forms.NumericUpDown spinBet;
        private System.Windows.Forms.Label lblBet;
        private System.Windows.Forms.GroupBox groupBet;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolbar;
        private System.Windows.Forms.ToolStripButton toolBtnHelp;
        private System.Windows.Forms.ToolStripButton toolBtnMusic;
        private System.Windows.Forms.PictureBox pictureDie1;
        private System.Windows.Forms.PictureBox pictureDie2;
        private System.Windows.Forms.Timer timerSound;
        private System.Windows.Forms.Timer timerDice;
        private System.Windows.Forms.Timer timerCheckWin;
    }
}

