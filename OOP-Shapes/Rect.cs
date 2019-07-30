using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Shapes {
    public class Rect : Quad {
        public Rect(int side_x, int side_y)
          : base(side_x,side_y,side_x, side_y) {           
            }

        public int GetArea() {
            return side1 * side2;
        }
    }
}
