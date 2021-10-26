using System.Drawing;
using System.Windows.Forms;

namespace Lab2.objects
{
    class RectangleEditor : ShapeEditor
    {
        public override void OnMouseUp(MouseEventArgs e, Graphics g)
        {
            this.x2 = e.X;
            this.y2 = e.Y;

            Rectangle rectangleShape = new Rectangle();
            rectangleShape.Set(this.x1, this.y1, this.x2, this.y2);
            rectangleShape.Show(g, pen);
        }
    }
}
