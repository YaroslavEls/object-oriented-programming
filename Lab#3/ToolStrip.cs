using System.Windows.Forms;

namespace Lab2
{
    class ToolStrip
    {
        public Form currentForm;

        public void Dot(ShapeObjectsEditor shapeObjectsEditor)
        {
            currentForm = Form.ActiveForm;
            this.currentForm.Text = "Drawing Dots";
            shapeObjectsEditor.DotEditor();
        }

        public void Line(ShapeObjectsEditor shapeObjectsEditor)
        {
            currentForm = Form.ActiveForm; 
            currentForm.Text = "Drawing Lines";
            shapeObjectsEditor.LineEditor();
        }

        public void Rectangle(ShapeObjectsEditor shapeObjectsEditor)
        {
            currentForm = Form.ActiveForm; 
            currentForm.Text = "Drawing Rectangles";
            shapeObjectsEditor.RectangleEditor();
        }

        public void Ellipse(ShapeObjectsEditor shapeObjectsEditor)
        {
            currentForm = Form.ActiveForm; 
            currentForm.Text = "Drawing Ellipses";
            shapeObjectsEditor.EllipseEditor();
        }
    }
}
