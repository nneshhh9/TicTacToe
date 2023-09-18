using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Крестики_Нолики
{
    class LogicGame
    {
        public event Action TimerStart;
        public event Action TimerStop;
        public LogicGame(string mode, List<Button> lsBtn, string complexity)
        {
            
            board = new GameBoard();
            this.lsBtn = lsBtn;
            switch (mode)
            {
                case "Игрок-Игрок":
                    player1 = new Player("X");
                    player2 = new Player("O");
                    currentPlayer = player1;
                    break;
                case "Игрок-ПК":
                    player1 = new Player("X");
                    player2 = new Computer("O", complexity == "Нормально" ? 2000 : int.MaxValue); //устанавливаем сложность  5000 это уже не выиграть           
                    currentPlayer = player1;
                    flagGameCPU = true;
                    break;
                case "ПК-Игрок":
                    player1 = new Computer("X", complexity == "Нормально" ? 500 : int.MaxValue);//устанавливаем сложность 600 помоему уже не выиграть
                    player2 = new Player("O");
                    currentPlayer = player1;
                    flagGameCPU = true;
                    CPUMove();
                    break;
                case "ПК-ПК":
                    player1 = new Computer("X");
                    player2 = new Computer("O");
                    currentPlayer = player1;
                    flagGameCPU = true;
                    break;
            }
        }
        Player player1;
        Player player2;
        bool flagGameCPU = false;
        GameBoard board;
        Player currentPlayer; //ход текущего игрока
        List<Button> lsBtn;

        public void StartAI()
        {
            TimerStart?.Invoke();
        }

        public void CPUMove()
        {
            //тут будет ходить компьютер
            if (flagGameCPU)
            {
                int index = currentPlayer.MoveNext(board, currentPlayer);
                board.lsBoard[index]= currentPlayer.simbol;
                lsBtn[index].Text=currentPlayer.simbol;

                if (board.ChechDraw() || board.GetWinnerCheck())
                {
                    TimerStop?.Invoke();
                    flagGameCPU = false;
                    StopGame(lsBtn);
                  
                    return;
                }
                currentPlayer = currentPlayer.simbol == "X" ? player2 : player1;
            }
        }

        internal void Move(int indexLsBtn, List<Button> lsBtn)
        {
            if (lsBtn[indexLsBtn].Text == " ")
            {
                lsBtn[indexLsBtn].Text = currentPlayer.simbol;
                board.lsBoard[indexLsBtn] = currentPlayer.simbol;

                if (board.ChechDraw()|| board.GetWinnerCheck())
                {
                    StopGame(lsBtn);
                    return;
                }
                currentPlayer = currentPlayer.simbol == "X" ? player2 : player1;
                CPUMove();
            }
        }

        private void StopGame(List<Button> lsBtn)
        {
            if (board.IndexWin != null)
            {
                lsBtn[board.IndexWin.Item1].BackColor = Color.Red;
                lsBtn[board.IndexWin.Item2].BackColor = Color.Red;
                lsBtn[board.IndexWin.Item3].BackColor = Color.Red;
                MessageBox.Show($"Победил {currentPlayer.simbol}");
            }
            else
            {
                MessageBox.Show($"Ничья");
            }

            foreach (var item in lsBtn)
            {
                item.Enabled = false;
            }
        }
    }
}
