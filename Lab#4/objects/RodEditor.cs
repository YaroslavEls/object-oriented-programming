using System.Drawing;
using System.Windows.Forms;

namespace Lab2.objects
{
    class RodEditor : ShapeEditor
    {
        public override void OnMouseUp(MouseEventArgs e, Graphics g)
        {
            this.x2 = e.X;
            this.y2 = e.Y;

            Rod RodShape = new Rod();
            RodShape.Set(this.x1, this.y1, this.x2, this.y2);
            RodShape.Show(g, pen);
            RodShape.Fill(g, brush);
        }
    }
}
