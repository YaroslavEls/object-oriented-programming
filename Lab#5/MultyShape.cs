using Lab2.objects;

namespace Lab2
{
    abstract class MultyShape : Shape
    {
        public Line line = new Line();
        public Rectangle rectangle = new Rectangle();
        public Ellipse ellipse = new Ellipse();

        public abstract int[,] SetCoordinates();
    }
}
