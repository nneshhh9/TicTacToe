using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Крестики_Нолики
{

    public static class PlayerExtension
    {
       public static Player ReversMove(this Player pl)
        {
            return new Player(pl.simbol == "X" ? "O" : "X");
        }
    }

    public class Player
    {
        public string simbol;
        public Player(string simbol)
        {
            this.simbol = simbol;
        }

        public Player(string simbol, int complexity)
        {
            this.simbol = simbol;
            this.complexity = complexity;
        }

        public int MoveNext(GameBoard board, Player pl)
        {
            return FindBestMove(board, pl);
        }


        public int complexity = int.MaxValue;

        ///
        ///
        ///новый алгоритм
        ///
        public int FindBestMove(GameBoard board,Player pl)
        {
            int bestMove = -1;
            int bestScore = int.MinValue;

            Console.WriteLine($"{board}\n");

            foreach (int index in board.GetAvailableStates())
            {
                GameBoard newBoard = new GameBoard();     // makes a copy
                newBoard.lsBoard = board.lsBoard.ToList();
                newBoard.lsBoard[index] = pl.simbol;
                //newBoard.DisplayBoard();
                //Console.WriteLine("");
            
                count = 0;
                int score = -(this.MiniMax(newBoard, pl.ReversMove(), depth: 0));
                Console.WriteLine($"field: {index}\tscore: {score}");
           
                if (score > bestScore)
                {
                    bestScore = score;
                    bestMove = index;
                }
            }
            return bestMove;
        }
        int count;
        //   ---------------------------------------------------------------------
        protected virtual int MiniMax(GameBoard board, Player machineMove, int depth)
        {
            count++;
            if (count > complexity) return 0;
            if (board.GetWinnerCheck())
            {
                string me = ""; //текущий ход
                if (machineMove.simbol == "X")
                {
                    me = "X";
                }
                if (machineMove.simbol == "O")
                {
                    me = "O";
                }
                return board.nameWinner == me ? 10 - depth : -10 + depth;
            }

            if (board.ChechDraw())
            {
                return 0;
            }

            int maxScore = int.MinValue;
            foreach (int index in board.GetAvailableStates())
            {
                GameBoard newBoard = new GameBoard();  
                newBoard.lsBoard = board.lsBoard.ToList();
                newBoard.lsBoard[index] = machineMove.simbol;
                int score = -this.MiniMax(newBoard, machineMove.ReversMove(), depth + 1);
                if (score > maxScore)
                    maxScore = score;
            }
            return maxScore;
        }
        ///конец алгоритма
        ///

        //еще один алгоритм

        protected int MiniMax2(GameBoard board, Player machineMove, int depth)
        {
            const int alpha = -10000; 
            const int beta = 10000;
            const int maxScore = alpha;
            return this.AlphaBetaPruning(board, machineMove, depth, -beta, -maxScore);
        }
    
        private int AlphaBetaPruning(GameBoard board, Player machineMove, int depth, int alpha, int beta)
        {
            if (board.GetWinnerCheck())
            {
                string me = ""; //текущий ход
                if (machineMove.simbol == "X")
                {
                    me = "X";
                }
                if (machineMove.simbol == "O")
                {
                    me = "O";
                }
                return board.nameWinner == me ? 10 - depth : -10 + depth;
            }

            if (board.ChechDraw())
            {
                return 0;
            }

            int maxScore = alpha;
            foreach (int index in board.GetAvailableStates())
            {
                GameBoard newBoard = new GameBoard();
                newBoard.lsBoard = board.lsBoard.ToList();
                newBoard.lsBoard[index] = machineMove.simbol;
                //newBoard.DisplayBoard2();
                //Console.WriteLine("");
                int score = -this.AlphaBetaPruning(newBoard, machineMove.ReversMove(), depth + 1, -beta, -maxScore);
                if (score > maxScore) 
                { 
                   maxScore = score;
                    if (maxScore >= beta)
                        break;
                }
            }
            return maxScore;
        }
    }
}