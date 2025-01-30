using BoardGame_Classes;
using SeriesTicTacToe.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeriesTicTacToe
{
    public partial class Word : Form
    {
        private GameManager<char> _gameManager;
        private int _Turn = 1;// 1 -> player x 
        private int move_x, move_y;
        private bool GameOver=false;
        private char _char;// for random player
        public Word()
        {
            InitializeComponent();
            _gameManager = GetPlayerInfo._gameManager;
        }

        private void Word_Load(object sender, EventArgs e)
        {
            
            foreach (Control control in this.Controls)
            {
                if (control is Button button)
                {
                    button.Enabled = false;
                }
            }
            btBrowse.Enabled = true;
            btRestart.Enabled = false;
            btBrowse.BackColor=Color.FromArgb(128,Color.Wheat);
            foreach (Control control in this.Controls)
            {
                if (control is Button button)
                {
                    button.MouseHover += Word_MouseHover;
                    button.MouseMove += Word_MouseHover; // Use the same for MouseMove
                    button.MouseLeave += Word_MouseLeave;
                }
            }
            updateBoard_randomPlayer();
        }

        private void Word_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.FromArgb(255, 255, 255, 255);

            Pen Pen = new Pen(White);
            Pen.Width = 10;


            Pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            Pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            // Draw Line horizontal

            e.Graphics.DrawLine(Pen, 300, 250, 870, 250);
            e.Graphics.DrawLine(Pen, 300, 400, 870, 400);

            // Draw line vertical
            e.Graphics.DrawLine(Pen, 460, 130, 460, 530);
            e.Graphics.DrawLine(Pen, 700, 130, 700, 530);
        }

        private void Word_MouseHover(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                button.BackColor = Color.FromArgb(29, 30, 61);
            }
        }

        private void Word_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                button.BackColor = Color.Transparent;
            }
        }

        private void Word_MouseMove(object sender, MouseEventArgs e)
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
                    labelTurn.Text = "Player_2";

                    updateBoard();
                    _Turn = 2;
                    button.Enabled = false;
                    updateBoard_randomPlayer();
                    break;
                case 2:
                   
                    labelTurn.Text = "Player_1";
                    updateBoard();
                    _Turn = 1;
                    button.Enabled = false;
                    updateBoard_randomPlayer();
                    break;

            }
            button.Image = null;
            button.BackgroundImage = null;
            button.Text = tbCharacter.Text.ToUpper();
            

        }
        public void updateBoard_randomPlayer()
        {
            if (_gameManager._players[_Turn - 1].Name == "Random Computer Player" && !_gameManager._board.IsWin() && !_gameManager._board.IsDraw() && _gameManager._board.NumberOfMoves != 9 && !GameOver)
            {
                // get move random for x and y 
                do
                {
                    Controller.generateRandomMove_Word(ref move_x, ref move_y, _gameManager._board.Dimension, _gameManager._board.Rows, _gameManager._board.Columns);

                } while (_gameManager._board.GameBoard[move_x, move_y] != '\0');

                changeButtonCharacter();// change the button automatic
                _gameManager._board.UpdateBoard(move_x, move_y, _char);
                GameStatus(_char);// select if player won or the game is draw 

                if (_Turn == 1)
                {
                    _Turn = 2;
                    labelTurn.Text = "Player_2";
                }
                else
                {
                    _Turn = 1;
                    labelTurn.Text = "Player_1";
                }
                
                
            }
        }
        private void updateBoard()
        {
            _gameManager._board.UpdateBoard(move_x, move_y, tbCharacter.Text[0]);
            GameStatus(tbCharacter.Text[0]);
        }
        private void selectCharacterOfButton( Button button)
        {
            
            string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int rand_index;
            Random _random = new Random();
            rand_index = _random.Next(0, 25);// generate number between 0 and 25
            _char = letters[rand_index];
           
            button.Text = _char + "";
          
            button.Image = null;
            button.BackgroundImage = null;
            button.Enabled = false;
        }
        private void changeButtonCharacter()
        {
            if (move_x == 1 && move_y == 1)
            {
                selectCharacterOfButton( button5);
            }
            else if (move_x == 1 && move_y == 0)
            {
                selectCharacterOfButton( button6);
            }
            else if (move_x == 2 && move_y == 2)
            {
                selectCharacterOfButton( button3);
            }
            else if (move_x == 2 && move_y == 1)
            {
                selectCharacterOfButton( button2);
            }
            else if (move_x == 2 && move_y == 0)
            {
                selectCharacterOfButton( button1);
            }
            else if (move_x == 0 && move_y == 1)
            {
                selectCharacterOfButton( button8);
            }
            else if (move_x == 0 && move_y == 2)
            {
                selectCharacterOfButton( button7);
            }
            else if (move_x == 1 && move_y == 2)
            {
                selectCharacterOfButton( button4);
            }
            else if (move_x == 0 && move_y == 0)
            {
                selectCharacterOfButton( button9);
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

            if (win)
            {
                if (_Turn==2)
                {
                    
                    labelInProgress.Text = _gameManager._players[1].Name;
                    labelTurn.Text = "Player_2";
                    GameOver = true;
                }
                else
                {
                    labelInProgress.Text = _gameManager._players[0].Name;
                    labelTurn.Text = "Player_1";
                    GameOver = true;
                }
            }
            else if (draw || _gameManager._board.NumberOfMoves == 9)
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
                    if(button.Text!="RESTART" && button.Text!= "Select a Text File")
                    {
                        button.Image = Resources.question_mark_96;
                        button.Text = "";
                    }
                    
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
            move_x = 0; move_y = 0;
            if (sender is Button button && tbCharacter.Text.Length == 1)
            {
                changeSymbol(button);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            move_x = 0; move_y = 1;
            if (sender is Button button && tbCharacter.Text.Length == 1)
            {
                changeSymbol(button);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            move_x = 0; move_y = 2;
            if (sender is Button button && tbCharacter.Text.Length == 1)
            {
                changeSymbol(button);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            move_x = 1; move_y = 0;
            if (sender is Button button && tbCharacter.Text.Length == 1)
            {
                changeSymbol(button);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            move_x = 1; move_y = 1;
            if (sender is Button button && tbCharacter.Text.Length==1)
            {
                changeSymbol(button);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            move_x = 1; move_y = 2;
            if (sender is Button button && tbCharacter.Text.Length == 1)
            {
                changeSymbol(button);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            move_x = 2; move_y = 0;
            if (sender is Button button && tbCharacter.Text.Length == 1)
            {
                changeSymbol(button);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            move_x = 2; move_y = 1;
            if (sender is Button button && tbCharacter.Text.Length == 1)
            {
                changeSymbol(button);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            move_x = 2; move_y = 2;
            if (sender is Button button && tbCharacter.Text.Length == 1)
            {
                changeSymbol(button);
            }
        }

        private void btBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt",
                Title = "Select a Text File"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Read all lines from the file and load into a List<string>
                    List<string> sequences = new List<string>(File.ReadAllLines(openFileDialog.FileName));
                    WORD_TICTACTOE_Board._Words = sequences;
                    // Display the number of sequences loaded (optional)
                    MessageBox.Show($"Loaded {sequences.Count} sequences.", "File Loaded", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Example: Output each line in the console (optional)
                    foreach (Control control in this.Controls)
                    {
                        if (control is Button button && button.Image!=null)
                        {
                            button.Enabled = true;
                            
                        }
                        btRestart.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions such as file access errors
                    MessageBox.Show($"Error reading file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
