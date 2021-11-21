using System.Drawing;
using System.Windows.Forms;

namespace Lab2.objects
{
    class CubeEditor : ShapeEditor
    {
        public override void OnMouseUp(MouseEventArgs e, Graphics g)
        {
            this.x2 = e.X;
            this.y2 = e.Y;

            Cube CubeShape = new Cube();
            CubeShape.Set(this.x1, this.y1, this.x2, this.y2);
            CubeShape.Show(g, pen);
        }
    }
}
