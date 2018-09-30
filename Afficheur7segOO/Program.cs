//Auseur : JMY
//Lieu   : ETML
//Description : squelette pour afficheur LCD dans la console
using System;

namespace Afficheur7segOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Affiche un 1 en mode LCD
            new Messenger(1).Display();

            Console.ReadLine();
        }
    }
}
