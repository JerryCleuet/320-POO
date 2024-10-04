﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public interface IDispatchable
    {
        public void RemoveBox(Box box);

        public void AddBox(Box box);
    }
}