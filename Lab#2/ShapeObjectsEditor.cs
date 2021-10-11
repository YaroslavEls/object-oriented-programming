using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Lab2.objects;

namespace Lab2
{
    class ShapeObjectsEditor
    {
        ShapeEditor shapeEditor;

        public void DotEditor()
        {
            this.shapeEditor = new DotEditor();
        }

        public void LineEditor()
        {
            this.shapeEditor = new LineEditor();
        }

        public void RectangleEditor()
        {
            this.shapeEditor = new RectangleEditor();       
        }

        public void EllipseEditor()
        {
            this.shapeEditor = new EllipseEditor();
        }

        public void OnMouseDown(MouseEventArgs e)
        {
            if (this.shapeEditor != null)
            {
                this.shapeEditor.OnMouseDown(e);
            }
        }

        public void OnMouseUp(MouseEventArgs e, Graphics g)
        {        
            if (this.shapeEditor != null)
            {
                this.shapeEditor.OnMouseUp(e, g);
            }
        }

        public void OnMouseMove(MouseEventArgs e, Graphics g)
        {
            if (this.shapeEditor != null)
            {
                this.shapeEditor.OnMouseMove(e, g);
            }
        }

        public void InitPen(Color penColor, Color brushColor, DashStyle style)
        {
            this.shapeEditor.InitPen(penColor, brushColor, style);
        }

        public void DisposePen()
        {
            this.shapeEditor.DisposePen();
        }
    }
}
