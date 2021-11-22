using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Lab2
{
    public sealed class MyEditor
    {
        private static readonly MyEditor instance = new MyEditor();

        static MyEditor()
        {
        }

        private MyEditor()
        {
        }

        public static MyEditor Instance
        {
            get
            {
                return instance;
            }
        }

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

        public int[] GetCoords()
        {
            int[] coords = new int[4];
            if (this.shapeEditor != null)
            {
                coords = new int[4] { shapeEditor.x1, shapeEditor.y1, shapeEditor.x2, shapeEditor.y2 };
            }
            return coords;
        }
    }
}
