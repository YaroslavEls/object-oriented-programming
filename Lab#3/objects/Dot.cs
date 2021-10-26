using System.Drawing;

namespace Lab2.objects
{
    class Dot : Shape
    {
        public override void Show(Graphics g, Pen pen)
        {
            g.DrawRectangle(pen, this.x2, this.y2, 1, 1);
        }
    }
}
