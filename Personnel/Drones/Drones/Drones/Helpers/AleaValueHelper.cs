﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones.Helpers
{
    public static class AleaValueHelper
    {
        public static Random alea = new Random();

        public static int AleaValue()
        {
            return alea.Next(-2, 3);
        }

        public static Random alval = new Random();

        public static int AlVal()
        {
            return alval.Next(0, 600);
        }

        public static int AleaTime()
        {
            return (int)alval.Next(0, 2);
        }
    }
}
