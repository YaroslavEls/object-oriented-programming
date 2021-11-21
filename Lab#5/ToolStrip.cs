using System.Windows.Forms;

namespace Lab2
{
    class ToolStrip
    {
        public Form currentForm;

        public void Button(string text)
        {
            currentForm = Form.ActiveForm;
            this.currentForm.Text = text;
        }
    }
}
