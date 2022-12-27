using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Player
    {
        // Eigenschaften
        public string Name { get; set; }

        private char symbole;

        public char Symbole
        {
            get
            {
                return symbole;
            }
            set
            {
                symbole = value;
            }
        }
    }
}
