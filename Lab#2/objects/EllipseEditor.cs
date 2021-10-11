using System.Drawing;
using System.Windows.Forms;

namespace Lab2.objects
{
    class EllipseEditor : ShapeEditor
    {
        public override void OnMouseUp(MouseEventArgs e, Graphics g)
        {
            this.x2 = e.X;
            this.y2 = e.Y;

            Ellipse ellipseShape = new Ellipse();
            ellipseShape.Set(this.x1, this.y1, this.x2, this.y2);
            ellipseShape.Show(g, pen);
            ellipseShape.Fill(g, brush);
        }

        public override void OnMouseMove(MouseEventArgs e, Graphics g)
        {
            this.x2 = e.X;
            this.y2 = e.Y;

            Ellipse ellipseShape = new Ellipse();
            ellipseShape.Set(this.x1, this.y1, this.x2, this.y2);
            ellipseShape.Show(g, pen);
        }
    }
}
