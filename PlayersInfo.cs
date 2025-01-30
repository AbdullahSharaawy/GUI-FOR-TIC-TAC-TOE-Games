using BoardGame_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeriesTicTacToe
{
    public partial class PlayersInfo : UserControl
    {
        private int _gameNumber;
        public   GameManager<char> _gameManager;
        public delegate void displaysBoards();
        public event displaysBoards evDisplayingBoard;
        public PlayersInfo(int gameNumber)
        {
            InitializeComponent();
            _gameNumber = gameNumber;
           
        }

        private void PlayersInfo_Paint(object sender, PaintEventArgs e)
        {
            Color Black = Color.FromArgb(255, 0, 0, 0);

            Pen Pen = new Pen(Black);
            Pen.Width = 10;

            // Pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            Pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            Pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;


            e.Graphics.DrawLine(Pen, 276, 60, 276, 246);
            //e.Graphics.DrawRectangle(Pen, 200, 200, 300, 300);
            //e.Graphics.DrawEllipse(Pen, 200, 50, 100, 120);
        }

        private void PlayersInfo_Load(object sender, EventArgs e)
        {
            //lbPlayer1.BackColor = Color.FromArgb(128, Color.Black);
            //lbPlayer2.BackColor = Color.FromArgb(128, Color.Black);

            rbHuman.Checked = true;
            rbHuman2.Checked = true;
        }
       
        private char[] SelectSymbol(int gameNumber)
        {
            char[] symbols;

            switch (gameNumber)
            {
                case 1:
                    symbols = new char[2];
                    symbols[0] = 'X';
                    symbols[1] = 'O';
                    break;
                case 3:
                    symbols = new char[2];
                    symbols[0] = 'X';
                    symbols[1] = 'O';
                    break;
                // Add more cases for other game numbers as needed
                default:
                    // Handle unexpected game numbers or provide a default set of symbols
                    symbols = new char[2];
                    symbols[0] = 'A';
                    symbols[1] = 'B';
                    break;
            }

            return symbols;
        }
        private void btSubmit_Click(object sender, EventArgs e)
        {
            Player<char>[] players = new Player<char>[2];
            
            if(rbHuman.Checked)
            {
                players[0] = Controller.CreateHumanPlayer(_gameNumber, tbPlayer1.Text, SelectSymbol(_gameNumber)[0]);
                
            }
            else if (rbComputer.Checked)
            {
                players[0] = Controller.CreateComputerPlayer(_gameNumber, SelectSymbol(_gameNumber)[0]);
               
            }
            if (rbHuman2.Checked)
            {
                players[1] = Controller.CreateHumanPlayer(_gameNumber, tbPlayer2.Text, SelectSymbol(_gameNumber)[1]);
                
            }
            
            else if(rbComputer2.Checked)
            {
                players[1] = Controller.CreateComputerPlayer(_gameNumber, SelectSymbol(_gameNumber)[1]);
               
            }
            _gameManager = Controller.createGameManager(_gameNumber,players);

           GetPlayerInfo._gameManager = _gameManager;

            evDisplayingBoard();
        }

        private void lbPlayer1_Click(object sender, EventArgs e)
        {

        }

        private void rbConmputer2_CheckedChanged(object sender, EventArgs e)
        {
            tbPlayer2.ReadOnly = true;
            rbComputer.Enabled=false;
            tbPlayer2.Text=string.Empty;
        }

        private void rbComputer_CheckedChanged(object sender, EventArgs e)
        {
            tbPlayer1.ReadOnly = true;
            rbComputer2.Enabled=false;
            tbPlayer1.Text=string.Empty;
        }

        private void rbHuman_CheckedChanged(object sender, EventArgs e)
        {
            tbPlayer1.ReadOnly =false ;
            rbComputer2.Enabled = true;
        }

        private void rbHuman2_CheckedChanged(object sender, EventArgs e)
        {
            tbPlayer2.ReadOnly = false;
            rbComputer.Enabled = true;
        }
    }
}
