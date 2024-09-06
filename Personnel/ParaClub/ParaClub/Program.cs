using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParaClub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Plane> planes = new List<Plane>();
            Plane toto = new Plane();

            List<Para> para = new List<Para>();
            Para Bob = new Para();

            Console.CursorVisible = false;




            while (true)
            {

                // Modifier ce que l'on *voit*
                toto.draw();
                Console.Clear();               
                toto.move();
                

                // Temporiser
                Thread.Sleep(40);
            }




        }
            




        
    }
}
