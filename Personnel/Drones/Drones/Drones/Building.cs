using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public class Building
    {
        //modèle
        private int _x;
        private int _y;

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }
        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }


        //voir le building

        private Pen BuildingBrush = new Pen((Color.Blue), 8);
        public void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.DrawRectangle(BuildingBrush, new Rectangle(X -2, Y -2, 8, 8));
        }

    }
}
