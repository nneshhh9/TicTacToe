using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Крестики_Нолики
{
    public class Computer : Player
    {
        public Computer(string simbol, int v) : base(simbol,v)
        {
         
        }

        public Computer(string simbol) : base(simbol)
        {

        }

        protected override int MiniMax(GameBoard board, Player machineMove, int depth)
        {
            return base.MiniMax(board, machineMove, depth);
        }
    }
}
