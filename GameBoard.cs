using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Крестики_Нолики
{
    public class GameBoard
    {
        public GameBoard()
        {
            for (int i = 0; i < 9; i++)
            {
                lsBoard.Add("-");
            }
        }
        /// <summary>
        /// свойства нашего игрового поля
        /// </summary>
        /// 
        public List<string> lsBoard = new List<string>();


        public Tuple<int, int, int> IndexWin;

        public bool ChechDraw()
        {
            for (int i = 0; i < lsBoard.Count; i++)
            {
                if (lsBoard[i] == "-")
                {
                    return false;
                }
            }
            return true;
        }

        public string nameWinner;

        public bool GetWinnerCheck()
        {
            nameWinner = "";
            /// 012
            /// 345
            /// 678
            /// 
            if ((lsBoard[2].Equals(lsBoard[5]) && lsBoard[5].Equals(lsBoard[8])) && !lsBoard[2].Equals("-"))
            {
                IndexWin = Tuple.Create(2, 5, 8);
                nameWinner = lsBoard[2];
                return true;
            }
            else
           if ((lsBoard[1].Equals(lsBoard[4]) && lsBoard[4].Equals(lsBoard[7])) && !lsBoard[1].Equals("-"))
            {
                IndexWin = Tuple.Create(1, 4, 7);
                nameWinner = lsBoard[1];
                return true;
            }
            else
            if ((lsBoard[0].Equals(lsBoard[3]) && lsBoard[3].Equals(lsBoard[6])) && !lsBoard[0].Equals("-"))
            {
                IndexWin = Tuple.Create(0, 3, 6);
                nameWinner = lsBoard[0];
                return true;
            }
            else
           if ((lsBoard[0].Equals(lsBoard[1]) && lsBoard[1].Equals(lsBoard[2])) && !lsBoard[0].Equals("-"))
            {
                IndexWin = Tuple.Create(0, 1, 2);
                nameWinner = lsBoard[0];
                return true;
            }
            else
            if ((lsBoard[3].Equals(lsBoard[4]) && lsBoard[4].Equals(lsBoard[5])) && !lsBoard[3].Equals("-"))
            {
                IndexWin = Tuple.Create(3, 4, 5);
                nameWinner = lsBoard[3];
                return true;
            }
            else
            if ((lsBoard[6].Equals(lsBoard[7]) && lsBoard[7].Equals(lsBoard[8])) && !lsBoard[6].Equals("-"))
            {
                IndexWin = Tuple.Create(6, 7, 8);
                nameWinner = lsBoard[6];
                return true;
            }
            else

            if ((lsBoard[0].Equals(lsBoard[4]) && lsBoard[4].Equals(lsBoard[8])) && !lsBoard[0].Equals("-"))
            {
                IndexWin = Tuple.Create(0, 4, 8);
                nameWinner = lsBoard[0];
                return true;
            }
            else
            if ((lsBoard[2].Equals(lsBoard[4]) && lsBoard[4].Equals(lsBoard[6])) && !lsBoard[2].Equals("-"))

            {
                IndexWin = Tuple.Create(2, 4, 6);
                nameWinner = lsBoard[2];
                return true;
            }
            return false;
        }

        public List<int> GetAvailableStates()
        {
            List<int> ls = new List<int>();
            for (int i = 0; i < lsBoard.Count; i++)
            {
                if (lsBoard[i] == "-")
                    ls.Add(i);
            }
            return ls;

        }

        public void DisplayBoard()
        {
            for (int w = 0; w < lsBoard.Count(); w++)
            {
                Console.Write($"{lsBoard[w]}|");
                if (w == 2 || w == 5 || w == 8)
                {
                    Console.WriteLine("");
                }
            }
        }
    }
}
