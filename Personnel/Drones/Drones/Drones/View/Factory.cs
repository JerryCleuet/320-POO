using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public partial class Factory : Building
    {
        //voir l'usine
        private Pen FactoryBrush = new Pen(Color.Red, 8);
        public void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.DrawRectangle(FactoryBrush, new Rectangle(X - 2, Y - 2, 8, 8));
        }

    }
}
