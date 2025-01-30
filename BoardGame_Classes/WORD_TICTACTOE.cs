using BoardGame_Classes;
using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace BoardGame_Classes
{

    public class WORD_TICTACTOE_Board : Board<char>
    {
        public static List<string> _Words;
        public bool IsValidWord(List<string> Words, string word)
        {
            return Words.Contains(word);
        }

        public WORD_TICTACTOE_Board() : base(3)
        {
            initializeBoard();
            _Words = new List<string>() { "test" };
        }
        public override void initializeBoard()
        {
            Rows = 3;
            Columns = 3;
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
            if ((x >= 0 && y >= 0 && y < Columns && x<Rows)  &&
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
            string[] word = new string[2] { "", ""};

            // Check diagonals
            word[0] += GameBoard[0,0];
            word[0] += GameBoard[1,1];
            word[0] += GameBoard[2,2];

            word[1] +=  GameBoard[0,2];
            word[1] +=  GameBoard[1,1];
            word[1] +=  GameBoard[2,0];

            if (IsValidWord(WORD_TICTACTOE_Board._Words, word[0]) || IsValidWord(WORD_TICTACTOE_Board._Words, word[1]) ||
                IsValidWord(WORD_TICTACTOE_Board._Words, ReserveWord(word[0])) || IsValidWord(WORD_TICTACTOE_Board._Words, ReserveWord(word[1])))
            {
                return true;
            }

            // Check rows and columns
            for (int i = 0; i < Rows; i++)
            {
                word[0] = "";
                word[1] = "";
                
                // Check row
                word[0] +=  GameBoard[i,0];
                word[0] +=  GameBoard[i,1];
                word[0] +=  GameBoard[i,2];

                // Check column
                word[1] +=  GameBoard[0,i];
                word[1] +=  GameBoard[1,i];
                word[1] +=  GameBoard[2,i];

                if (IsValidWord(WORD_TICTACTOE_Board._Words, word[0]) || IsValidWord(WORD_TICTACTOE_Board._Words, word[1]) ||
                    IsValidWord(WORD_TICTACTOE_Board._Words, ReserveWord(word[0])) || IsValidWord(WORD_TICTACTOE_Board._Words, ReserveWord(word[1])))
                {
                    return true;
                }
            }

            return false;
        }
        private string ReserveWord(string word)
        {

            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            string reversed = new string(charArray);
            return reversed;
        }
        public override bool IsDraw() => NumberOfMoves == 9 && !IsWin();

        public override bool GameIsOver() => IsWin() || IsDraw();
    }

    public class WORD_TICTACTOE_Player : Player<char>
    {
        public WORD_TICTACTOE_Player(string name, char symbol) : base(name, symbol) { }

        

    }

    public class WORD_TICTACTOE_RandomPlayer : RandomPlayer<char>
    {
        private readonly Random _random = new Random();

        public WORD_TICTACTOE_RandomPlayer(char symbol) : base(symbol) { }

        
    }

}
