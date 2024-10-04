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

      
    }
}
