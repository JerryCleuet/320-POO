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
            ConsoleKeyInfo keyPressed;
            Console.CursorVisible = false;

            Console.WindowHeight = Config.SCREEN_HEIGHT;
            Console.WindowWidth = Config.SCREEN_WIDTH;

            List<Para> parachutistsInTheAir = new List<Para>();

            List<Plane> planes = new List<Plane>();
            Plane plane = new Plane();

            for (int i = 0; i < 9; i++)
            {
                plane.board(new Para("Bob " + i.ToString()));
            }





            while (true)
            {

                // Modifier ce que l'on *voit*
                Console.Clear();

                if (Console.KeyAvailable) // L'utilisateur a pressé une touche
                {
                    keyPressed = Console.ReadKey(false);
                    switch (keyPressed.Key)
                    {
                        case ConsoleKey.Escape:
                            Environment.Exit(0);
                            break;
                        case ConsoleKey.Spacebar:
                            Para jumper = plane.dropParachutist();
                            parachutistsInTheAir.Add(jumper);
                            break;
                        default:
                            break;
                    }
                }

                    plane.move();
                foreach (Para para in parachutistsInTheAir)
                {
                    para.move();
                }

                plane.draw();
                foreach (Para para in parachutistsInTheAir)
                {
                    para.draw();
                }

                // Temporiser
                Thread.Sleep(100);
            }




        }






    }
}
