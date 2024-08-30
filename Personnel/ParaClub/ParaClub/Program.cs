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

            while (true)
            {
                // Modifier le modèle (ce qui *est*)
                Plane.update();
                ...

                // Modifier ce que l'on *voit*
                Console.Clear();
                Plane.draw();

                // Temporiser
                Thread.Sleep(100);
            }
            if (Console.KeyAvailable) // L'utilisateur a pressé une touche
            {
                keyPressed = Console.ReadKey(false);
                switch (keyPressed.Key)
                {
                    case ConsoleKey.Escape:
                        ...
                break;
                        ...
        }
            }





        }
    }
}
