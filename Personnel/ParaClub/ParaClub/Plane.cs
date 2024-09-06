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
        private const int WIDTH = 28;
        private const int HEIGHT = 6;

        private string[] view =
    {
            @" _                         ",
            @"| \                        ",
            @"|  \       ______          ",
            @"--- \_____/  |_|_\____  |  ",
            @"  \_______ --------- __>-} ",
            @"        \_____|_____/   |  "
        };
        private int x = 0;
        private int altitude = 0;
        private List<Para> parachutists;

        //constructeur
        public Plane()
        {
            x = 0;
            altitude = Config.SCREEN_HEIGHT;
            parachutists = new List<Para>();
        }


        //méthode
        public void move()
        {
            if (x >= Config.SCREEN_WIDTH)
            {
                x = 0;
            }
            else
            {
                x++;
            }
        }

        public void draw()
        {
           
            for (int i = 0; i < view.Length; i++)
            {
                Console.SetCursorPosition(x, i);
                Console.WriteLine(view[i]);
            }
        }

        public void board(Para para)
        {
            this.parachutists.Add(para);
        }
        internal Para dropParachutist()
        {
            Para parachutist = parachutists.First();
            parachutists.Remove(parachutist);
            parachutist.x = x;
            parachutist.altitude = this.altitude;
            return parachutist;
        }
    }
}
