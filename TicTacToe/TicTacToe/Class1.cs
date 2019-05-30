using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class Board
    {
        public Board() {
            this.One = '1';
            this.Two = '2';
            this.Three = '3';
            this.Four = '4';
            this.Five = '5';
            this.Six = '6';
            this.Seven = '7';
            this.Eight = '8';
            this.Nine = '9';
        }

        public char One { get; set; }
        public char Two { get; set; }
        public char Three { get; set; }
        public char Four { get; set; }
        public char Five { get; set; }
        public char Six { get; set; }
        public char Seven { get; set; }
        public char Eight { get; set; }
        public char Nine { get; set; }
    }
}
