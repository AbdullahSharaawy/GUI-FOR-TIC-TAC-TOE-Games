using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame_Classes
{




    public abstract class Board<T>
    {
        public int Rows, Columns;
        public T[,] GameBoard;
        public int NumberOfMoves = 0;
        public int Dimension;
        public Board(int dimension)
            {
               Dimension = dimension;
            }
        public abstract bool UpdateBoard(int x, int y, T symbol);
       // public abstract void DisplayBoard();
        public abstract bool IsWin();
        public abstract bool IsDraw();
        public abstract bool GameIsOver();

        public abstract void initializeBoard();
    }

    public abstract class Player<T>
    {
        public string Name;
        
        protected T Symbol;
        protected Board<T> BoardInstance;

        public Player(string name, T symbol)
        {
            Name = name;
            Symbol = symbol;
        }

        public Player(T symbol) : this("Computer", symbol) { }

      //  public abstract void GetMove(out int x, out int y);

        public T GetSymbol() => Symbol;
        public string GetName() => Name;
        public void SetBoard(Board<T> board) => BoardInstance = board;
    }

    public abstract class RandomPlayer<T> : Player<T>
    {
        

        public RandomPlayer(T symbol) : base(symbol)
        {
            
            Name = "Random Computer Player";
        }

        //public abstract override void GetMove(out int x, out int y);
    }

    public class GameManager<T>
    {
        public Board<T> _board;
        public Player<T>[] _players;

        public GameManager(Board<T> board, Player<T>[] players)
        {
            _board = board;
            _players = players;
        }

        //public void Run()
        //{
        //    int x, y;
        //    // _board.DisplayBoard();

        //    while (!_board.GameIsOver())
        //    {
        //        foreach (var player in _players)
        //        {
        //            player.GetMove(out x, out y);
        //            while (!_board.UpdateBoard(x, y, player.GetSymbol()))
        //            {
        //                //Console.WriteLine("Invalid move, try again.");
        //                player.GetMove(out x, out y);
        //            }
        //            // _board.DisplayBoard();
        //            if (_board.IsWin())
        //            {
        //               // Console.WriteLine($"{player.GetName()} wins!");
        //                return;
        //            }
        //            if (_board.IsDraw())
        //            {
        //                //Console.WriteLine("It's a draw!");
        //                return;
        //            }
        //        }
        //    }
        //}
    }

}
