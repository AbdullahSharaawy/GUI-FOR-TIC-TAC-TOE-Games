using BoardGame_Classes;
using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace BoardGame_Classes
{
  
    public class TicTacToeBoard : Board<char>
    {
        public TicTacToeBoard() :base(5) 
        {
            initializeBoard();
        }
        public override void initializeBoard()
        {
            Rows = 3;
            Columns = 5;
            GameBoard = new char[Rows, Columns];

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    GameBoard[i, j] = '\0';
                }
            }
            this.NumberOfMoves = 0;
        }
        public override bool UpdateBoard(int x, int y, char symbol)
        {
            if (((x == 0 && y >= 0 && y < Columns) || (x == 1 && y >= 1 && y < Columns - 1) || (x == 2 && y == 2)) &&
                GameBoard[x, y] == '\0')
            {
                GameBoard[x, y] = char.ToUpper(symbol);
                NumberOfMoves++;
                return true;
            }
            return false;
        }

       
        public override bool IsWin()
        {
            // Check rows and columns

            // Check rows and columns for a win
            if ((GameBoard[0, 0] == GameBoard[0, 1] && GameBoard[0, 1] == GameBoard[0, 2] && GameBoard[0, 0] != 0) || // Check row 0
                (GameBoard[0, 2] == GameBoard[1, 2] && GameBoard[1, 2] == GameBoard[2, 2] && GameBoard[0, 2] != 0) || // Check column 2
                (GameBoard[0, 1] == GameBoard[0, 2] && GameBoard[0, 2] == GameBoard[0, 3] && GameBoard[0, 1] != 0) || // Check row 0
                (GameBoard[0, 2] == GameBoard[0, 3] && GameBoard[0, 3] == GameBoard[0, 4] && GameBoard[0, 2] != 0) || // Check row 0
                (GameBoard[1, 1] == GameBoard[1, 2] && GameBoard[1, 2] == GameBoard[1, 3] && GameBoard[1, 1] != 0))   // Check row 1
            {
                return true;
            }

            // Check diagonals for a win
            if ((GameBoard[0, 0] == GameBoard[1, 1] && GameBoard[1, 1] == GameBoard[2, 2] && GameBoard[0, 0] != 0) || // Check diagonal
                (GameBoard[2, 2] == GameBoard[1, 3] && GameBoard[1, 3] == GameBoard[0, 4] && GameBoard[2, 2] != 0))   // Check diagonal
            {
                return true;
            }

            return false;
        }

        public override bool IsDraw() => NumberOfMoves == 9 && !IsWin();

        public override bool GameIsOver() => IsWin() || IsDraw();
    }

    public class TicTacToePlayer : Player<char>
    {
        public TicTacToePlayer(string name, char symbol) : base(name, symbol) { }

       

    }

    public class TicTacToeRandomPlayer : RandomPlayer<char>
    {
        private readonly Random _random = new Random();
       
        public TicTacToeRandomPlayer(char symbol) : base(symbol) { }

        
    }

}
