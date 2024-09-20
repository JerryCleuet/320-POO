using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public partial class Store : Building
    {
        //voir le magasin
        private Pen StoreBrush = new Pen(Color.Green, 8);
        public void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.DrawEllipse(StoreBrush, new Rectangle(X - 1, Y - 1, 8, 8));
        }
    }
}
