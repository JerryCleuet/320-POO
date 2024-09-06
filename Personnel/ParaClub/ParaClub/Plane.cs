using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ParaClub
{
    internal class Plane
    {
        public string[] view =
    {
            @" _                         ",
            @"| \                        ",
            @"|  \       ______          ",
            @"--- \_____/  |_|_\____  |  ",
            @"  \_______ --------- __>-} ",
            @"        \_____|_____/   |  "
        };
        public int x = 0;
        public int y = 0;

        //constructeur

        //méthode
        public void move()
        {
            for (int i = 0; i < view.Length; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.WriteLine(view[i]);
            }

        }

        public void draw()
        {
            x++;
            /*for (int i = 0; i < view.Length; i++)
            {
                Console.WriteLine(view[i]);
            }*/
        }
    }
}
