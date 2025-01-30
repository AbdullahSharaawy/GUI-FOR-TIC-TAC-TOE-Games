using BoardGame_Classes;
using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace BoardGame_Classes
{
    public class FourXFourTicTacToeBoard : Board<char>
    {
        private bool deleteSymbol = false;// to remove symbol from the board
        
        public FourXFourTicTacToeBoard() : base(4)
        {
            initializeBoard();
        }
        public override void initializeBoard()
        {
            Rows = 4;
            Columns = 4;
            GameBoard = new char[Rows, Columns];

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    GameBoard[i, j] = '\0';
                }
            }
            // this loop to prepare GameStart
            for (int i = 0; i < Rows; i += 3)
            {
                for (int j = 0; j < Columns; j++)
                {
                    if (i == 0)
                    {
                        GameBoard[i,j] = (j % 2 == 0) ? 'X' : 'O';
                    }
                    else
                    {
                        GameBoard[i,j] = (j % 2 == 0) ? 'O' : 'X';
                    }
                }
            }
           // this.NumberOfMoves = 0;
        }
        public override bool UpdateBoard(int x, int y, char symbol)
        {
            
            // Update if move is valid or delete element
             if (((x >= 0 && y >= 0 && y < this.Columns && x < this.Columns) && (this.GameBoard[x,y] == 0 || symbol == 0)) || deleteSymbol)
            {
                if (symbol == 0 || deleteSymbol)
                {
                    // this.n_moves--; (Uncomment and manage `n_moves` logic if needed)
                    GameBoard[x,y] = '\0'; // Assuming empty cells are represented as a null/zero character
                }
                else
                {
                    // this.n_moves++; (Uncomment and manage `n_moves` logic if needed)
                    GameBoard[x,y] = char.ToUpper(symbol);
                }

                return true;
            }

            return false;

        }


        public override bool IsWin()
        {
            for (int i = 0; i < this.Rows; i++)
            {
                if ((this.GameBoard[i,0] == this.GameBoard[i,1] && this.GameBoard[i,1] == this.GameBoard[i,2] && this.GameBoard[i,0] != (char)0) ||
                    (this.GameBoard[0,i] == this.GameBoard[1,i] && this.GameBoard[1,i] == this.GameBoard[2,i] && this.GameBoard[0,i] != (char)0) ||
                    (this.GameBoard[1,i] == this.GameBoard[2,i] && this.GameBoard[2,i] == this.GameBoard[3,i] && this.GameBoard[1,i] != (char)0) ||
                    (this.GameBoard[i,1] == this.GameBoard[i,2] && this.GameBoard[i,2] == this.GameBoard[i,3] && this.GameBoard[i,3] != (char)0))
                {
                    return true;
                }
            }

            // Check diagonals
            if ((this.GameBoard[0,0] == this.GameBoard[1,1] && this.GameBoard[1,1] == this.GameBoard[2,2] && this.GameBoard[0,0] != (char)0) ||
                (this.GameBoard[0,2] == this.GameBoard[1,1] && this.GameBoard[1,1] == this.GameBoard[2,0] && this.GameBoard[0,2] != (char)0))
            {
                return true;
            }

            if ((this.GameBoard[0,1] == this.GameBoard[1,2] && this.GameBoard[1,2] == this.GameBoard[2,3] && this.GameBoard[0,1] != (char)0) ||
                (this.GameBoard[0,3] == this.GameBoard[1,2] && this.GameBoard[1,2] == this.GameBoard[2,1] && this.GameBoard[0,3] != (char)0))
            {
                return true;
            }

            if ((this.GameBoard[3,0] == this.GameBoard[2,1] && this.GameBoard[2,1] == this.GameBoard[1,2] && this.GameBoard[3,0] != (char)0) ||
                (this.GameBoard[3,2] == this.GameBoard[2,1] && this.GameBoard[2,1] == this.GameBoard[1,0] && this.GameBoard[2,1] != (char)0))
            {
                return true;
            }

            if ((this.GameBoard[1,1] == this.GameBoard[2,2] && this.GameBoard[2,2] == this.GameBoard[3,3] && this.GameBoard[1,1] != (char)0) ||
                (this.GameBoard[1,3] == this.GameBoard[2,2] && this.GameBoard[2,2] == this.GameBoard[3,1] && this.GameBoard[2,2] != (char)0))
            {
                return true;
            }

            return false;
        }

        public override bool IsDraw() => false;

        public override bool GameIsOver() => IsWin();
    }

    public class FourXFourTicTacToePlayer : Player<char>
    {
        public FourXFourTicTacToePlayer(string name, char symbol) : base(name, symbol) { }



    }

    public class FourXFourTicTacToeRandomPlayer : RandomPlayer<char>
    {
        private readonly Random _random = new Random();

        public FourXFourTicTacToeRandomPlayer(char symbol) : base(symbol) { }


    }

}
