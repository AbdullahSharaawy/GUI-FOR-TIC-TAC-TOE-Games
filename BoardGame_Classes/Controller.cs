using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame_Classes
{

    using System;

    public class Controller
    {
        private static Board<char> CreateBoard(int selectedBoard)
        {
            switch (selectedBoard)
            {
                case 1:
                    return new TicTacToeBoard();
                case 2:
                    return new WORD_TICTACTOE_Board();
                case 3:
                    return new FourXFourTicTacToeBoard();
                default:
                    break;
            }
            return null;
        }

        public static Player<char> CreateHumanPlayer(int gameNumber, string playerName, char playerSymbol)
        {
            switch (gameNumber)
            {
                case 1:
                    return new TicTacToePlayer(playerName, playerSymbol);
                case 2:
                    return new WORD_TICTACTOE_Player(playerName, playerSymbol);
                case 3:
                    return new FourXFourTicTacToePlayer(playerName,playerSymbol);
                default:
                    break;
            }
            return null;
        }

        public static Player<char> CreateComputerPlayer(int gameNumber, char playerSymbol)
        {
            switch (gameNumber)
            {
                case 1:
                    return new TicTacToeRandomPlayer(playerSymbol);

                case 2:
                    return new WORD_TICTACTOE_RandomPlayer(playerSymbol);
                case 3:
                    return new FourXFourTicTacToeRandomPlayer(playerSymbol);
                default:

                    break;
            }
            return null;
        }
        private static bool IsValidMove_Payramic(int move_x, int move_y)
        {
            if ((move_x == 0 && move_y == 0) || (move_x == 0 && move_y == 1) || (move_x == 0 && move_y == 2) || (move_x == 0 && move_y == 3) 
                || (move_x == 0 && move_y == 4) || (move_x == 1 && move_y == 1) || (move_x == 1 && move_y == 2) || (move_x == 1 && move_y == 3) 
                || (move_x == 2 && move_y == 2))
            {  return true; }
            return false;
  }
        private static bool IsValidMove_Word(int move_x, int move_y)
        {
            if ((move_x == 0 && move_y == 0) || (move_x == 0 && move_y == 1) || (move_x == 0 && move_y == 2) || (move_x == 1 && move_y == 0)
                ||  (move_x == 1 && move_y == 1) || (move_x == 1 && move_y == 2) || (move_x ==2  && move_y == 0) || (move_x==2 && move_y == 1)
                || (move_x == 2 && move_y == 2))
            { return true; }
            return false;
        }

        public static void generateRandomMove_Word(ref int  move_x ,ref int  move_y,int dimension,int row , int column)
        {
            Random _random = new Random();
            do
            {
                move_x = _random.Next(0, dimension);// generate number between 0 and 4
                move_y = _random.Next(0, dimension);
            } while (!IsValidMove_Word(move_x,move_y));
            
        }
        public static void generateRandomMove_Pyramic(ref int move_x, ref int move_y, int dimension, int row, int column)
        {
            Random _random = new Random();
            do
            {
                move_x = _random.Next(0, dimension);// generate number between 0 and 4
                move_y = _random.Next(0, dimension);
            } while (!IsValidMove_Payramic(move_x, move_y));

        }

        public static GameManager<char> createGameManager(int gameNumber, Player<char>[] players)
        {
            var board = CreateBoard(gameNumber);

            Player<char>[] _players = players;

            var gameManager = new GameManager<char>(board, players);
            
            return gameManager;
        }
        
    }

}