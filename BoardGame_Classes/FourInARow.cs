using System;

namespace BoardGame_Classes
{
    public class FourInARowBoard<T> : Board<T>
    {
        public FourInARowBoard()
        {
            Rows = 6;
            Columns = 7;
            GameBoard = new T[Rows, Columns];
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    GameBoard[i, j] = default(T);
                }
            }
            NumberOfMoves = 0;
        }

        public override bool UpdateBoard(int x, int y, T mark)
        {
            if (SelectMoveX(ref x, y, mark))
            {
                if (x >= 0 && x < Rows && y >= 0 && y < Columns &&
                    (Equals(GameBoard[x, y], default(T)) || Equals(mark, default(T))))
                {
                    if (Equals(mark, default(T)))
                    {
                        NumberOfMoves--;
                        GameBoard[x, y] = default(T);
                    }
                    else
                    {
                        NumberOfMoves++;
                        GameBoard[x, y] = mark;
                    }
                    return true;
                }
                return false;
            }
            else return false;
        }

        public bool SelectMoveX(ref int x, int y, T symbol)
        {
            for (short i = 5; i >= 0; i--)
            {
                if (Equals(GameBoard[i, y], default(T)))
                {
                    x = i;
                    return true;
                }
                else if (i == 0 && GameBoard[i, y] != null)
                {
                    return false;
                }
            }
            return true;
        }

        public override bool IsWin()
        {
            for (short i = 0; i < 6; i++)
            {
                if (GameBoard[i, 3].Equals('X') || GameBoard[i, 3].Equals('O'))
                {
                    if ((GameBoard[i, 3].Equals(GameBoard[i, 2]) &&
                         GameBoard[i, 3].Equals(GameBoard[i, 1]) &&
                         GameBoard[i, 3].Equals(GameBoard[i, 0])) ||
                        (GameBoard[i, 3].Equals(GameBoard[i, 4]) &&
                         GameBoard[i, 3].Equals(GameBoard[i, 5]) &&
                         GameBoard[i, 3].Equals(GameBoard[i, 6])) ||
                        (GameBoard[i, 3].Equals(GameBoard[i, 2]) &&
                         GameBoard[i, 3].Equals(GameBoard[i, 1]) &&
                         GameBoard[i, 3].Equals(GameBoard[i, 4])))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public override bool IsDraw()
        {
            return NumberOfMoves == 42 && !IsWin();
        }

        public override bool GameIsOver()
        {
            return IsWin() || IsDraw();
        }
    }

    public class FourInARowPlayer<T> : Player<T>
    {
        public FourInARowPlayer(string name, T symbol) : base(name, symbol) { }

        public override void getMove(out int x, out int y)
        {
            x = 0; // Placeholder
            y = 0; // Placeholder
        }
    }

    public class FourInARowRandomPlayer<T> : RandomPlayer<T>
    {
        private static Random _random = new Random();

        public FourInARowRandomPlayer(T symbol) : base(symbol)
        {
            Name = "Random Computer Player";
        }

        public override void GetMove(out int x, out int y)
        {
            x = _random.Next(6);
            y = _random.Next(7);
        }
    }
}
