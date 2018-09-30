//ETML
//Auteur : TODO
//Date : TODO
//Description : TODO
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afficheur7segOO
{
    class Segment
    {
        private int x;
        private int y;
        private char symbol;

        public Segment(int x, int y, char symbol)
        {
            this.x = x;
            this.y = y;
            this.symbol = symbol;
        }

        public void turnOn()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }
    }
}
