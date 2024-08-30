using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snail
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string snail = "_@_ö";
            int life = 50;
            int position=0;

            

            do
            {
               
                Console.SetCursorPosition(position,10);
                Console.WriteLine(snail);
                life--;
                position++;
                

            } while (life > 0);

            Console.SetCursorPosition(position, 10);
            Console.WriteLine("____");
            Console.ReadLine();




        }
    }
}
