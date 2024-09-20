using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public partial class Store : Building
    {
        //modèle
        private string _OpeningHours;

        private string OpeningHours
        {
            get { return _OpeningHours; }
            set { _OpeningHours = value; }
        }



    }
}
