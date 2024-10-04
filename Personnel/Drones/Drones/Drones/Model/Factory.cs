using Drones.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public partial class Factory : Building
    {
        //modèle
        private float _PowerConsumption;
        private int _IdFactory;
        private int _CreationTime;

        public float PowerConsumption
        {
            get { return _PowerConsumption; }
            set { _PowerConsumption = value; }
        }

        public int IdFactory
        {
            get { return _IdFactory; }
            set { _IdFactory = value; }
        }

        public int CreationTime
        { get { return _CreationTime; } set { _CreationTime = value; } }

        public void Update(int interval)
        {
            if (CreationTime == 50)
            {
                Console.WriteLine("Un carton de smarties vient d'être créé");
                CreationTime -= 50;                
            }
            else
            {
                CreationTime += 1;
                CreationTime -= AleaValueHelper.AleaTime();
            }
        }


    }
}
