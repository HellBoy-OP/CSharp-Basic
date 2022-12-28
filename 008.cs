// object oriented programming in c#
using System;

namespace OOPs {
    class Program {
        public static void oops() {
            // public function Program class
            Console.WriteLine("This programs finds the area of Rectangle!");
            Rectangle newObj = new Rectangle(); // constructing object from class Rectangle.
            
            // using newObj object for further processing
            Console.Write("Enter length: ");
            float length = Convert.ToInt32(Console.ReadLine());
            newObj.setLength(length);
            
            Console.Write("Enter breadth: ");
            float breadth = Convert.ToInt32(Console.ReadLine());
            newObj.setBreadth(breadth);

            Console.WriteLine("Area without using args ...");
            float area = newObj.getArea();
            Console.WriteLine($"Area of Reactangle: {area}");

            Console.WriteLine("Area using args ...");
            float area2 = newObj.getArea(length, breadth);
            Console.WriteLine($"Area of Rectangle: {area2}");

            Console.WriteLine("Perimeter without using args ...");
            float perimeter = newObj.getPerimeter();
            Console.WriteLine($"Perimeter of Reactangle: {perimeter}");

            Console.WriteLine("Perimeter using args ...");
            float perimeter2 = newObj.getPerimeter(length, breadth);
            Console.WriteLine($"Perimeter of Rectangle: {perimeter2}");
        }
    }

    // class to find area and perimeter of a rectangle
    class Rectangle {
        private static float length;
        private static float breadth;

        public void setLength(float len) {
            // set length of the rectangle
            length = len;
        }
        public void setBreadth(float wid) {
            // set width of the rectangle
            breadth = wid;
        }
        public float getArea() {
            // method 1 to find the area
            float area;
            area = length * breadth;
            return area;
        }
        public float getArea(float len, float wid) {
            // method 2 to find the area. 'Call By Value function'
            float area;
            area = len * wid;
            return area;
        }
        public float getPerimeter() {
            // method 1 to find the perimeter
            float perimeter;
            perimeter = 2 * (length + breadth);
            return perimeter;
        }
        public float getPerimeter(float len, float wid) {
            // method 2 to find the perimeter. 'Call By Value function'
            float perimeter;
            perimeter = 2 * (len + wid);
            return perimeter;
        }
    }
}