using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasCent
{
    public class Canvas
    {
        private Bitmap bitmap;

        public Canvas(Bitmap bitmap)
        {
            this.bitmap = bitmap;
        }

        public void Clear()
        {
            Graphics.FromImage(bitmap).Clear(Color.Black);
        }

        public void DrawLine(PointF start, PointF end, Pen pen)
        {
            Graphics.FromImage(bitmap).DrawLine(pen, start, end);
        }
    }
}

