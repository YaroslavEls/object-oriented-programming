using System.Drawing;

namespace Lab2.objects
{
    class Rod : MultyShape
    {
        public override void Show(Graphics g, Pen pen)
        {
            int[,] coords = this.SetCoordinates();

            line.Set(coords[0, 0],
                         coords[0, 1],
                         coords[0, 2],
                         coords[0, 3]);
            line.Show(g, pen);

            for (int i = 1; i < 3; i++)
            {
                ellipse.Set(coords[i, 0],
                         coords[i, 1],
                         coords[i, 2],
                         coords[i, 3]);
                ellipse.Show(g, pen);
            }
        }

        public void Fill(Graphics g, SolidBrush brush)
        {
            int[,] coords = this.SetCoordinates();

            for (int i = 1; i < 3; i++)
            {
                ellipse.Set(coords[i, 0],
                         coords[i, 1],
                         coords[i, 2],
                         coords[i, 3]);
                ellipse.Fill(g, brush);
            }
        }

        public override int[,] SetCoordinates()
        {
            int[,] coords =
            {
                {this.x2 - (3 *(this.x2 - this.x1))/2, this.y2 - (3 * (this.y2 - this.y1))/2, this.x1 + (3 *(this.x2 - this.x1))/2, this.y1 + (3 * (this.y2 - this.y1))/2},
                {this.x1, this.y1, this.x2 - 2 * (this.x2 - this.x1), this.y2 - 2 * (this.y2 - this.y1)},
                {this.x2, this.y2, this.x1 - 2 * (this.x1 - this.x2), this.y1 - 2 * (this.y1 - this.y2)},
            };
            return coords;
        }
    }
}
