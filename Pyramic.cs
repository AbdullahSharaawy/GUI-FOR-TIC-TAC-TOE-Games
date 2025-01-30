using BoardGame_Classes;
using SeriesTicTacToe.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeriesTicTacToe
{
    public partial class Pyramic : Form
    {
        private  GameManager<char> _gameManager;
        private int _Turn = 1;// 1 -> player x 
        private int move_x,move_y;
        private bool GameOver = false;
        public Pyramic()
        {
            InitializeComponent();
            _gameManager=GetPlayerInfo._gameManager;
        }

        private void Pyramic_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.FromArgb(255, 255, 255, 255);

            Pen Pen = new Pen(White);
            Pen.Width = 10;


            Pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            Pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            // Draw Line horizontal

            e.Graphics.DrawLine(Pen, 350, 195, 800, 195);
            e.Graphics.DrawLine(Pen, 300, 300, 870, 300);
         

            // Draw line vertical
            e.Graphics.DrawLine(Pen, 391, 161, 391, 411);
            e.Graphics.DrawLine(Pen, 505, 90, 505, 411);
            e.Graphics.DrawLine(Pen, 635, 90, 635, 411);
            e.Graphics.DrawLine(Pen, 754, 161, 754, 411);
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            move_x = 1; move_y = 2;
            if (sender is Button button)
            {
                changeSymbol(button);
            }
        }

        private void Pyramic_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button button)
                {
                    button.MouseHover += Pyramic_MouseHover;
                    button.MouseMove += Pyramic_MouseHover; // Use the same for MouseMove
                    button.MouseLeave += Pyramic_MouseLeave;
                }
            }
            updateBoard_randomPlayer();
        }

       
        private void Pyramic_MouseHover(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                button.BackColor = Color.FromArgb(29, 30, 61);
            }
        }

        private void Pyramic_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                button.BackColor = Color.Transparent;
            }
        }

        private void Pyramic_MouseMove(object sender, MouseEventArgs e)
        {
            if (sender is Button button)
            {
                button.BackColor = Color.Transparent;
            }
        }
        void changeSymbol(Button button)
        {
            switch (_Turn)
            {
                case 1:
                    button.Image = Resources.X;
                   
                    labelTurn.Text ="Player_O";

                    updateBoard();
                    _Turn = 2;
                    button.Enabled = false;
                    updateBoard_randomPlayer();
                    break;
                case 2:
                    button.Image = Resources.O;
                   
                    labelTurn.Text = "Player_X";
                    updateBoard();
                    _Turn = 1;
                    button.Enabled = false;
                    updateBoard_randomPlayer();
                    break;

            }
        }
        public void updateBoard_randomPlayer()
        {
            if (_gameManager._players[_Turn - 1].Name == "Random Computer Player" && !_gameManager._board.IsWin() && !_gameManager._board.IsDraw() && _gameManager._board.NumberOfMoves!=9 && !GameOver)
            {
                // get move random for x and y 
                do
                {
                    Controller.generateRandomMove_Pyramic(ref move_x, ref move_y, _gameManager._board.Dimension, _gameManager._board.Rows, _gameManager._board.Columns);

                } while (_gameManager._board.GameBoard[move_x, move_y] != '\0');

                changeButtonImageX_O(_Turn - 1);// change the button automatic
                _gameManager._board.UpdateBoard(move_x, move_y, _gameManager._players[_Turn - 1].GetSymbol());
                GameStatus(_gameManager._players[_Turn - 1].GetSymbol());// select if player won or the game is draw 

                updateTurn(); // update the turn
            }
        }
        private void updateTurn()
        {
            switch (_Turn)
            {
                case 1:
                    _Turn = 2;
                    labelTurn.Text = "Player_O";
                    break;
                case 2:
                    _Turn = 1;
                    labelTurn.Text = "Player_X";
                    break;
            }


        }
        private void updateBoard()
        {
                _gameManager._board.UpdateBoard(move_x, move_y, _gameManager._players[_Turn - 1].GetSymbol());
                GameStatus(_gameManager._players[_Turn - 1].GetSymbol());   
        }
       private void selectSymbolOfImageButton(int n_turn,Button button)
        {
            switch (n_turn)
            {
                case 0:
                    button.Image = Resources.X;
                    break;
                case 1:
                    button.Image = Resources.O;
                    break;

            }
            button.Enabled = false;
        }
        private void changeButtonImageX_O(int n_turn)
        {
            if(move_x==0 && move_y==0)
            {
                selectSymbolOfImageButton(n_turn, button5);
            }else if (move_x == 0 && move_y == 1)
            {
                selectSymbolOfImageButton(n_turn, button6);
            }
            else if (move_x == 0 && move_y == 2)
            {
                selectSymbolOfImageButton(n_turn, button7);
            }
            else if (move_x == 0 && move_y == 3)
            {
                selectSymbolOfImageButton(n_turn, button8);
            }
            else if (move_x == 0 && move_y == 4)
            {
                selectSymbolOfImageButton(n_turn, button9);
            }
            else if (move_x == 1 && move_y == 1)
            {
                selectSymbolOfImageButton(n_turn, button2);
            }
            else if (move_x == 1 && move_y == 2)
            {
                selectSymbolOfImageButton(n_turn, button3);
            }
            else if (move_x == 1 && move_y == 3)
            {
                selectSymbolOfImageButton(n_turn, button4);
            }
            else if (move_x == 2 && move_y == 2)
            {
                selectSymbolOfImageButton(n_turn, button1);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            move_x=2; move_y=2;
           
            if (sender is Button button)
            {
                changeSymbol(button);   
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            move_x = 1; move_y =1;
            if (sender is Button button)
            {
                changeSymbol(button);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            move_x = 1; move_y = 3;

            if (sender is Button button)
            {
                changeSymbol(button);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            move_x = 0; move_y = 0;
            if (sender is Button button)
            {
                changeSymbol(button);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            move_x = 0; move_y = 1;
            if (sender is Button button)
            {
                changeSymbol(button);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            move_x = 0; move_y = 2;
            if (sender is Button button)
            {
                changeSymbol(button);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            move_x = 0; move_y = 3;
            if (sender is Button button)
            {
                changeSymbol(button);
            }
            

        }
        void GameStatus(char symbol)
        {
            bool draw = _gameManager._board.IsDraw();
            bool win = _gameManager._board.IsWin();
            if (draw || win || _gameManager._board.NumberOfMoves == 9)
            {
                foreach (Control control in this.Controls)
                {
                    if (control is Button button)
                    {
                        button.Enabled = false;
                    }
                }
               
            }
            
             if(win) 
            {
                if (symbol == 'X')
                { 
                    labelInProgress.Text = _gameManager._players[0].Name;
                    labelTurn.Text = "Player_X";
                    GameOver = true;
                }
                else
                {
                    labelInProgress.Text = _gameManager._players[1].Name;
                    labelTurn.Text = "Player_O";
                    GameOver = true;
                }
            }
           else if (draw || _gameManager._board.NumberOfMoves==9)
            {
                labelInProgress.Text = "Draw";
                GameOver = true;
            }
        }

        private void btRestart_Click(object sender, EventArgs e)
        {
            _gameManager._board.initializeBoard();
            
            foreach (Control control in this.Controls)
            {
                if (control is Button button)
                {
                    button.Enabled = true;
                    button.Image=Resources.question_mark_96;
                   
                }
            }
            _Turn = 1;
            _gameManager._board.NumberOfMoves = 0;
            GameOver = false;
            labelInProgress.Text = "In Progress";
            updateBoard_randomPlayer();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            move_x = 0; move_y = 4;
            if (sender is Button button)
            {
                changeSymbol(button);
            }
        }

    }
}
