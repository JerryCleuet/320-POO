using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones.Model
{
    public partial class Store : Building
    {
        //modèle
        private string _OpeningHours;

        public string OpeningHours
        {
            get { return _OpeningHours; }
            set { _OpeningHours = value; }
        }


        //voir le magasin
        private Pen StoreBrush = new Pen(Color.Blue, 8);
        public new void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.DrawEllipse(StoreBrush, new Rectangle(X - 2, Y - 2, 8, 8));
        }
    }
}
