using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Snail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Snail> snails = new List<Snail>();
            Snail toto = new Snail(10);
            Snail titi = new Snail(15);

            Console.CursorVisible = false;

            for(int i = 0; i < 10; i++)
            {
                snails.Add(new Snail(i));
            }



            while (snails[0].vie > 0) 
            {
                Console.Clear();
                foreach (Snail snail in snails)
                {
                    Console.SetCursorPosition(snail.x, snail.y);
                    Console.WriteLine(snail.alive);                 
                    snail.move();                   
                }
                Thread.Sleep(50);             

            }
            foreach (Snail snail in snails)
            {
                Console.SetCursorPosition(snail.x, snail.y);
                Console.WriteLine(snail.dead);
               
                
            }
            Console.ReadLine();


        }
    }
}
