using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afficheur7segOO
{
    class Program
    {
        static void Main(string[] args)
        {
            new Messenger(1).display();

            Console.ReadLine();
        }
    }
}
