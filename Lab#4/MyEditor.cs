using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Lab2
{
    class MyEditor
    {
        ShapeEditor shapeEditor;

        public void Start(ShapeEditor shapeEditorInstance)
        {
            this.shapeEditor = shapeEditorInstance;
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
            if (this.shapeEditor != null)
            {
                this.shapeEditor.InitPen(penColor, brushColor, style);
            }
        }

        public void DisposePen()
        {
            if (this.shapeEditor != null)
            {
                this.shapeEditor.DisposePen();
            }
        }
    }
}
