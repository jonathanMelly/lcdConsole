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
    class Messenger
    {
        private byte digit;
        private Segment[] segments = new Segment[7];

        public Messenger(byte digit)
        {
            this.digit = digit;

            segments[0] = new Segment(1, 0, '-');
            segments[1] = new Segment(2, 1, '|');
            segments[2] = new Segment(2, 3, '|');
        }

        public void display()
        {
            switch(digit)
            {
                case 0:
                    
                    break;
                case 1:
                    segments[1].turnOn();
                    segments[2].turnOn();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
            }
        }
    }
}
