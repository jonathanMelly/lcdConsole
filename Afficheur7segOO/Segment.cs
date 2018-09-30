//ETML
//Auteur : TODO
//Date : TODO
//Description : TODO
using System;

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

        /// <summary>
        /// Simule l'allumage du segment
        /// </summary>
        public void TurnOn()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }
    }
}
