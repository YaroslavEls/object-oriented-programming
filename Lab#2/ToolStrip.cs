using System.Drawing;
using System.Windows.Forms;

namespace Lab2
{
    class ToolStrip
    {
        protected string directory = @"D:\aaa.bmp";

        public void Save(Bitmap bit)
        {
            bit.Save(directory);
        }

        public void Open(PictureBox picBox)
        {
            picBox.Image = Image.FromFile(directory);
        }

        public void Create(PictureBox picBox)
        {
            picBox.Image = null;
            picBox.BackgroundImage = null;
        }
    }
}
