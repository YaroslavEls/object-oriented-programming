using System;
using System.Drawing;

namespace Lab2.objects
{
    class Rectangle : Shape
    {
        public void Show(Graphics g, Pen pen)
        {
            g.DrawRectangle(pen, 
                            (this.x1 < this.x2 ? (this.x1 - this.x2 + this.x1) : this.x2),
                            (this.y1 < this.y2 ? (this.y1 - this.y2 + this.y1) : this.y2), 
                            2*Math.Abs(this.x1 - this.x2), 
                            2*Math.Abs(this.y1 - this.y2));
        }
    }
}
