using System;
using System.Drawing;

namespace Lab2.objects
{
    class Ellipse : Shape
    {
        public override void Show(Graphics g, Pen pen)
        {
            g.DrawEllipse(pen,
                          (this.x1 > this.x2 ? this.x2 : this.x1),
                          (this.y1 > this.y2 ? this.y2 : this.y1),
                          Math.Abs(this.x1 - this.x2),
                          Math.Abs(this.y1 - this.y2));
        }

        public void Fill(Graphics g, SolidBrush brush)
        {
            g.FillEllipse(brush,
                          (this.x1 > this.x2 ? this.x2 : this.x1),
                          (this.y1 > this.y2 ? this.y2 : this.y1),
                          Math.Abs(this.x1 - this.x2),
                          Math.Abs(this.y1 - this.y2));
        }
    }
}
