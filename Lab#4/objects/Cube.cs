using Lab2.interfaces;
using System;
using System.Drawing;

namespace Lab2.objects
{
    class Cube : Shape, RectangleInterface, LineInterface
    {
        public override void Show(Graphics g, Pen pen)
        {
            this.ShowRectangle(g, pen);
            int X1 = this.x1;
            int Y1 = this.y1;
            int X2 = this.x2;
            int Y2 = this.y2;
            this.x1 = this.x1 - 50;
            this.y1 = this.y1 - 50;
            this.x2 = this.x2 - 50;
            this.y2 = this.y2 - 50;
            this.ShowRectangle(g, pen);
            this.ShowLine(g, pen, this.x2, this.y2, X2, Y2);
            this.ShowLine(g, pen, this.x2 - 2 * (this.x2 - this.x1), this.y2 - 2 * (this.y2 - this.y1), (this.x2 - 2 * (this.x2 - this.x1)) + 50, (this.y2 - 2 * (this.y2 - this.y1)) + 50);
            //this.ShowLine(g, pen, this.x2, this.y2, this.x2 + 50, this.y2 + 50);
            /*            this.ShowLine(g, pen, this.x2 - 2*(this.x2 - this.x1), this.y2 - 2 * (this.y2 - this.y1), (this.x2 - 2*(this.x2 - this.x1)) + 50, (this.y2 - 2 * (this.y2 - this.y1)) + 50);
                        this.ShowLine(g, pen, this.x2, this.y2 - 2 * (this.y2 - this.y1), this.x2 + 50, (this.y2 - 2 * (this.y2 - this.y1)) + 50);
                        this.ShowLine(g, pen, this.x2 - 2 * (this.x2 - this.x1), this.y2, (this.x2 - 2 * (this.x2 - this.x1)) + 50, this.y2 + 50);
            */
        }

        public void ShowRectangle(Graphics g, Pen pen)
        {
            g.DrawRectangle(pen,
                            (this.x1 < this.x2 ? (this.x1 - this.x2 + this.x1) : this.x2),
                            (this.y1 < this.y2 ? (this.y1 - this.y2 + this.y1) : this.y2),
                            2 * Math.Abs(this.x1 - this.x2),
                            2 * Math.Abs(this.y1 - this.y2));
        }

        public void ShowLine(Graphics g, Pen pen, int x1, int y1, int x2, int y2)
        {
            g.DrawLine(pen, x1, y1, x2, y2);
        }
    }
}
