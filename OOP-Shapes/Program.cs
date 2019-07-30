using System;

namespace OOP_Shapes {
    class Program {
        static void Main(string[] args) {

            var sqrcomp = new SquareComp(5);
            var p = sqrcomp.GetPerimeter();
            var a = sqrcomp.GetArea();
            Console.WriteLine($"The SqrComp perimiter is {p} and area is {a}");

            var quad1 = new Quad(5, 7, 13, 6);
            var perimeter = quad1.GetPerimeter();
            Console.WriteLine($"The perimeter is {perimeter}");

            var rect1 = new Rect(5, 13);
            perimeter = rect1.GetPerimeter();
            var area = rect1.GetArea();
            Console.WriteLine($"The rect periemter is {perimeter}");
            Console.WriteLine($"The rect area is {area}");

            var square1 = new Square(7);
            perimeter = square1.GetPerimeter();
            Console.WriteLine($"The square perimiter is {perimeter}");
            area = square1.GetArea();
            Console.WriteLine($"The square area is {area}");
            
        }        
    }
}
