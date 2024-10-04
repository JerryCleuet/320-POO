using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public class Dispatch : IDispatchable
    {
        //Modélisation de la centrale de distribution
        List<Box> boxes = new List<Box>();

        public void AddBox(Box box)
        {
            boxes.Add(box);
            Console.WriteLine("Une boîte de smarties a été enregistrée");
        }

        public void RemoveBox(Box box)
        {
            boxes.Remove(box);
        }
    }
}
