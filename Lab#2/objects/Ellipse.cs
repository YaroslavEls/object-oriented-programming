using System;
using System.Drawing;

namespace Lab2.objects
{
    class Ellipse : Shape
    {
        public void Show(Graphics g, Pen pen, SolidBrush brush)
        {
            g.DrawEllipse(pen,
                          (this.x1 > this.x2 ? this.x2 : this.x1),
                          (this.y1 > this.y2 ? this.y2 : this.y1),
                          Math.Abs(this.x1 - this.x2),
                          Math.Abs(this.y1 - this.y2));

            g.FillEllipse(brush,
                          (this.x1 > this.x2 ? this.x2 : this.x1),
                          (this.y1 > this.y2 ? this.y2 : this.y1),
                          Math.Abs(this.x1 - this.x2),
                          Math.Abs(this.y1 - this.y2));
        }
    }
}
