using System.Drawing;

namespace Lab2.objects
{
    class Cube : MultyShape
    {
        public override void Show(Graphics g, Pen pen)
        {
            int[,] coords = this.SetCoordinates();
            
            for (int i = 0; i < 2; i++)
            {
                rectangle.Set(coords[i, 0],
                         coords[i, 1],
                         coords[i, 2],
                         coords[i, 3]);
                rectangle.Show(g, pen);
            }

            for (int i = 2; i < 6; i++)
            {
                line.Set(coords[i, 0],
                         coords[i, 1],
                         coords[i, 2],
                         coords[i, 3]);
                line.Show(g, pen);
            }
        }

        public override int[,] SetCoordinates()
        {
            int[,] coords =
            {
                { this.x1, this.y1, this.x2, this.y2},
                { this.x1 - 50, this.y1 - 50, this.x2 - 50, this.y2 - 50 },
                { this.x2, this.y2, this.x2 - 50, this.y2 - 50 },
                { this.x2 - 2 * (this.x2 - this.x1), this.y2, (this.x2 - 2 * (this.x2 - this.x1)) - 50, this.y2 - 50 },
                { this.x2, this.y2 - 2 * (this.y2 - this.y1), this.x2 - 50, (this.y2 - 2 * (this.y2 - this.y1)) - 50 },
                { this.x2 - 2 * (this.x2 - this.x1), this.y2 - 2 * (this.y2 - this.y1), (this.x2 - 2 * (this.x2 - this.x1)) - 50, (this.y2 - 2 * (this.y2 - this.y1)) - 50 }
            };
            return coords;
        }
    }
}
