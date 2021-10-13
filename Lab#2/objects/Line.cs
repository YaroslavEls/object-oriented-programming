using System.Drawing;

namespace Lab2.objects
{
    class Line : Shape
    {
        public override void Show(Graphics g, Pen pen)
        {
            g.DrawLine(pen, this.x1, this.y1, this.x2, this.y2);
        }
    }
}
