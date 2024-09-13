using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public static class AleaValueHelper
    {
        public static Random alea = new Random();

        public static int AleaValue()
        {
            return alea.Next(-2, 3);
        }

    }
}
