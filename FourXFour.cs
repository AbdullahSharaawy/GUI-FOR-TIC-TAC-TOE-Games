using BoardGame_Classes;
using SeriesTicTacToe.Properties;
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
    public partial class FourXFour : Form
    {
        private GameManager<char> _gameManager;
        private int _Turn = 1;// 1 -> player x 
        private int move_x, move_y;
        private bool GameOver = false;
        public FourXFour()
        {
            InitializeComponent();
            _gameManager = GetPlayerInfo._gameManager;
            button20.Click += button_Click;
            button19.Click += button_Click;
            button18.Click += button_Click;
            button17.Click += button_Click;
            button1.Click += button_Click;
            button2.Click += button_Click;
            button3.Click += button_Click;
            button4.Click += button_Click;
            button5.Click += button_Click;
            button6.Click += button_Click;
            button7.Click += button_Click;
            button8.Click += button_Click;
            button10.Click += button_Click;
            button12.Click += button_Click;
            button13.Click += button_Click;
            button14.Click += button_Click;
            // Add for all buttons in your grid

        }

        private void FourXFour_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.FromArgb(255, 255, 255, 255);

            Pen Pen = new Pen(White);
            Pen.Width = 10;


            Pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            Pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            // Draw Line horizontal

            e.Graphics.DrawLine(Pen, 300, 195, 750, 195);
            e.Graphics.DrawLine(Pen, 300, 298, 750, 298);
            e.Graphics.DrawLine(Pen, 300, 403, 750, 403);

            // Draw line vertical
            e.Graphics.DrawLine(Pen, 402, 90, 402, 505);
            e.Graphics.DrawLine(Pen, 515, 90, 515, 505);
            e.Graphics.DrawLine(Pen, 645, 90, 645, 505);

        }

        private void button20_Click(object sender, EventArgs e)
        {
            move_x = 0; move_y = 0;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            move_x = 0; move_y = 1;
        }

        private void button18_Click(object sender, EventArgs e)
        {

            move_x = 0; move_y = 2;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            move_x = 0; move_y = 3;
        }


        private void button5_Click(object sender, EventArgs e)
        {
            move_x = 1; move_y = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            move_x = 1; move_y = 1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            move_x = 1; move_y = 2;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            move_x = 1; move_y = 3;
        }



        private void button10_Click(object sender, EventArgs e)
        {
            move_x = 2; move_y = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            move_x = 2; move_y = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            move_x = 2; move_y = 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            move_x = 2; move_y = 3;
        }



        private void button13_Click(object sender, EventArgs e)
        {
            move_x = 3; move_y = 0;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            move_x = 3; move_y = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            move_x = 3; move_y = 2;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            move_x = 3; move_y = 3;
        }


        private int selectedX = -1; // Track selected piece X
        private int selectedY = -1; // Track selected piece Y

        private void button_Click(object sender, EventArgs e)
         {

            Button clickedButton = sender as Button;
            Color color = clickedButton.BackColor;
            // Determine the button's position (e.g., based on its tag or name)
            int x = move_x;
            int y = move_y;

            if (selectedX == -1 && selectedY == -1)
            {

                // Selecting a piece
                if (clickedButton.Image != null) // Check if there's an image
                {
                    if (_Turn == 2 ? clickedButton.Tag.ToString() == "O" : clickedButton.Tag.ToString() == "X")
                    {
                        selectedX = x;
                        selectedY = y;

                        // Indicate selection visually (optional)
                        clickedButton.BackColor = Color.Yellow;

                    }
                }

            }
            else if(selectedX==x && selectedY==y)
            {
                // Reset selection
                selectedX = -1;
                selectedY = -1;
                clickedButton.BackColor=Color.Transparent;
            }
            else
            {
                // Moving the piece
                if (IsValidMove(selectedX, selectedY, x, y) && clickedButton.Image == null) // Validate move
                {
                    Button previousButton = GetButtonAt(selectedX, selectedY);
                    // Place the image on the new button
                    clickedButton.Image = previousButton.Image;
                    //clickedButton.BackColor = SystemColors.Control; // Reset background color
                    if (previousButton != null)
                    {
                        previousButton.Image = null; // Clear image from the old location
                        previousButton.BackColor = color; // Reset background
                        previousButton.Tag = string.Empty;
                    }


                   
                    if (_Turn == 1)
                    {
                        labelTurn.Text = "Player_O";
                        updateBoard(selectedX,selectedY);
                        _Turn = 2;
                        clickedButton.Tag = "X";
                        updateBoard_randomPlayer();
                    }
                    else
                    {
                        labelTurn.Text = "Player_X";
                        updateBoard(selectedX,selectedY);
                        _Turn = 1;
                        clickedButton.Tag = "O";
                        updateBoard_randomPlayer();
                    }
                    // Reset selection
                    selectedX = -1;
                    selectedY = -1;

                }
                else
                {
                    MessageBox.Show("Invalid move. You can only move to an adjacent, empty button.");
                }
            }
        }

        // Utility function to get a button by coordinates


        // Utility function to validate the move
        private bool IsValidMove(int startX, int startY, int destX, int destY)
        {
            // Ensure the move is to an adjacent button
            return Math.Abs(startX - destX) <= 1 && Math.Abs(startY - destY) <= 1 && !(Math.Abs(startY - destY)==1 && Math.Abs(startX - destX)==1);
        }

        private Button GetButtonAt(int x, int y)
        {
            if (x == 0 && y == 0) return button20;
            if (x == 0 && y == 1) return button19;
            if (x == 0 && y == 2) return button18;
            if (x == 0 && y == 3) return button17;
            if (x == 1 && y == 0) return button5;
            if (x == 1 && y == 1) return button6;
            if (x == 1 && y == 2) return button7;
            if (x == 1 && y == 3) return button8;
            if (x == 2 && y == 0) return button10;
            if (x == 2 && y == 1) return button2;
            if (x == 2 && y == 2) return button3;
            if (x == 2 && y == 3) return button4;
            if (x == 3 && y == 0) return button13;
            if (x == 3 && y == 1) return button12;
            if (x == 3 && y == 2) return button1;
            if (x == 3 && y == 3) return button14;

            return null; // Return null if the position is invalid
        }
        private void updateBoard(int selectedX,int selectedY)
        {
            _gameManager._board.UpdateBoard(move_x, move_y, _gameManager._players[_Turn - 1].GetSymbol());
            _gameManager._board.GameBoard[selectedX, selectedY] = '\0';
            GameStatus(_gameManager._players[_Turn - 1].GetSymbol());
        }
        
        private bool isValidSymbol(int x, int y, char symbol)
        {
            return _gameManager._board.GameBoard[x, y] == symbol;
        }
        private bool isCellEmpty(int x, int y)
        {
            return _gameManager._board.GameBoard[x, y] == 0;
        }
        private bool generatePositionsList(int x, int y,ref List<(int ,int)> list,char symbol)// where the computer can change his selected token
        {


            if (x >= 0 && y >= 0 && y < 4 && x < 4 && isValidSymbol(x, y,symbol))
            {

                if (x - 1 >= 0 && x-1 < 4)
                {
                    if (isCellEmpty(x - 1, y))
                        list.Add((x - 1, y));
                }
                if (x + 1 >= 0 && x+1 < 4)
                {
                    if (isCellEmpty(x + 1, y))
                        list.Add((x + 1, y));

                }
                if (y + 1 >= 0 && y+1 < 4)
                {
                    if (isCellEmpty(x, y + 1))
                        list.Add((x , y+1));

                }
                if (y - 1 >= 0 && y-1 < 4)
                {
                    if (isCellEmpty(x, y - 1))
                        list.Add((x, y-1));

                }
            }
            else return false;

            if (list.Count != 0)
                return true;

            return false;
        }

        
        public void updateBoard_randomPlayer()
        {
            
            if (_gameManager._players[_Turn - 1].Name == "Random Computer Player" && !_gameManager._board.IsWin() && !_gameManager._board.IsDraw()  && !GameOver)
            {
                int current_x, current_y;
                Random random = new Random();
                List<(int, int)>list = new List<(int, int)>();
                // this loop to select a token where the computer want to change it
                do
                {
                     current_x = random.Next(0, _gameManager._board.Dimension); // Random number between 0 (inclusive) and 4 (exclusive)
                     current_y = random.Next(0, _gameManager._board.Dimension); // Random number between 0 (inclusive) and 4 (exclusive)

                } while (!generatePositionsList(current_x, current_y,ref list, _gameManager._players[_Turn-1].GetSymbol()));
                
                Color color = new Color();// to keep the backcolor after delete
                
                int des_x=0, des_y=0;
                int randomIndex = random.Next(list.Count);
                
                // Access the randomly selected pair
                (des_x, des_y) = list[randomIndex];

                Button clickedButton = GetButtonAt(des_x, des_y);
                Button previousButton = GetButtonAt(current_x, current_y);
                
                color=clickedButton.BackColor;

                if (previousButton != null)
                {
                    // Place the image on the new button
                    clickedButton.Image = previousButton.Image;
                    clickedButton.Tag= previousButton.Tag;
                    previousButton.Image = null; // Clear image from the old location
                    previousButton.BackColor = color; // Reset background
                    previousButton.Tag = string.Empty;
                }
                _gameManager._board.UpdateBoard(des_x, des_y, _gameManager._players[_Turn - 1].GetSymbol());
                _gameManager._board.GameBoard[current_x, current_y] = '\0';// delete the previous button symbol from Game Board 
                GameStatus(_gameManager._players[_Turn - 1].GetSymbol());// select if player won or the game is draw 
                                             
                // update the turn
                updateTurn();                
                
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
        void GameStatus(char symbol)
        {
            bool draw = _gameManager._board.IsDraw();
            bool win = _gameManager._board.IsWin();
            if (draw || win )
            {
                foreach (Control control in this.Controls)
                {
                    if (control is Button button)
                    {
                        button.Enabled = false;
                    }
                }

            }

            if (win)
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
            else if (draw )
            {
                labelInProgress.Text = "Draw";
                GameOver = true;
            }
        }

        void resetButtons()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button button)
                {
                    button.Enabled = true;
                    button.Image = null;

                }
            }
            // first row
            button13.Image = Resources.O;
            button12.Image = Resources.X;
            button1.Image = Resources.O;
            button14.Image = Resources.X;
            button13.Tag ="O" ;
            button12.Tag ="X" ;
             button1.Tag ="O" ;
            button14.Tag ="X" ;
            // last row
            button20.Image = Resources.X;
            button19.Image = Resources.O;
            button18.Image = Resources.X;
            button17.Image = Resources.O;
            button20.Tag ="X";
            button19.Tag ="O";
            button18.Tag ="X";
            button17.Tag ="O";

        }
        private void btRestart_Click(object sender, EventArgs e)
        {
            _gameManager._board.initializeBoard();

            resetButtons();            

            _Turn = 1;
           // _gameManager._board.NumberOfMoves = 0;
            GameOver = false;
            labelInProgress.Text = "In Progress";
            labelTurn.Text = "Player_X";
            GameOver=false;
            updateBoard_randomPlayer();
        }

        private void FourXFour_Load(object sender, EventArgs e)
        {
            updateBoard_randomPlayer();
        }
    }
}
