using System.Drawing;
using System.Windows.Forms;

namespace Lab2.objects
{
    class DotEditor : ShapeEditor
    {
        public override void OnMouseUp(MouseEventArgs e, Graphics g)
        {
            this.x2 = e.X;
            this.y2 = e.Y;

            pen = new Pen(Color.Black);

            Dot DotShape = new Dot();
            DotShape.Set(this.x1, this.y1, this.x2, this.y2);
            DotShape.Show(g, pen);

            pen.Dispose();
        }
    }
}
