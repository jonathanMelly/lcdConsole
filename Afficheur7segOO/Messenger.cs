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
        //La valeur à afficher
        private byte digit;

        //Les segments disponibles
        Segment A;
        Segment B;
        Segment C;

        public Messenger(byte digit)
        {
            //On stocke le digit à afficher (pour plus tard avec la méthode Display)
            this.digit = digit;

            //Définitions des 3 premiers segments
            //Il faut imaginer le tableau suivant
            /*
             *         Colonnes (X)
             * Lignes (Y)   |x=0|x=1|x=2|
             *           y=0|   | A |   |
             *           y=1| F |   | B |
             *           y=2|   | G |   |
             *           y=3| E |   | C |
             *           y=4|   | D |   |
             */
            A = new Segment(1, 0, '-');//Segment A, colonne 1 (x), ligne 0(y)
            B = new Segment(2, 1, '|');//Segment B, colonne 2, ligne 1
            C = new Segment(2, 3, '|');//Segment C, colonne 2, ligne 3
        }

        /// <summary>
        /// Affichage des segments correspondants au digit demandé
        /// </summary>
        public void Display()
        {
            switch(digit)
            {
                case 0:
                    
                    break;
                case 1:
                    B.TurnOn();
                    C.TurnOn();
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
