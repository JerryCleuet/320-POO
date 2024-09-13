using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones.Model
{
    public partial class Factory : Building
    {
        //modèle
        private float _PowerConsumption;

        public float PowerConsumption
        {
            get { return _PowerConsumption; }
            set { _PowerConsumption = value; }
        }


      
    }
}
