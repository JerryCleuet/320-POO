using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public partial class Building
    {
        //voir le building

        private Pen BuildingBrush = new Pen(Color.Blue, 30);
        public void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.DrawRectangle(BuildingBrush, new Rectangle(X - 1, Y - 1, 30, 30));
        }
    }
}
