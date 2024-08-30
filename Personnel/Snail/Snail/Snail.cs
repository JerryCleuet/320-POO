using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snail
{
    internal class Snail
    {
        //attributs
        public int vie = 50;          //points de vie
        public int x = 0;
        public int y;        //position
        public string name;
        
        public string alive = "_@_ö";   //escargot vivant
        public string dead = "____";    //escargot mort


        //constructeur
        public Snail(int y)
        {
          this.y = y;
            this.name = "Escargot" + y;
        }
        public Snail()
        {
            y = 12;
            this.name = "Escargot";

        }




        //méthode
        public void move()
        {
            x++;
            vie--;
        }




    }
}
