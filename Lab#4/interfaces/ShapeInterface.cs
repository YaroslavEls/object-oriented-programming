using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.interfaces
{
    interface ShapeInterface
    {
        void Set(int _x1, int _y1, int _x2, int _y2);

        void Show(Graphics g, Pen pen);
    }
}
