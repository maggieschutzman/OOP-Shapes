using System;

namespace OOP_Shapes {
    class Program {
        static void Main(string[] args) {

            var quad1 = new Quad(5, 7, 13, 6);

            var perimeter = quad1.GetPerimeter();

            Console.WriteLine($"The perimeter is {perimeter}");

            var rect1 = new Rect(5, 13);

            perimeter = rect1.GetPerimeter();

            Console.WriteLine($"The rect periemter is {perimeter}");
        }
    }
}
