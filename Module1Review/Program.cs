namespace Module1Review
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select a shape to take the area of: Circle, Triangle, Rectangle, Square");
            string shapeChoice = Console.ReadLine();

            if (shapeChoice == "Circle")
            {
                CircleArea();

            }
            else if (shapeChoice == "Triangle")
            {
                TriangleArea();
            }
            else if (shapeChoice == "Square")
            {
                SquareArea();
            }

            else if (shapeChoice == "Rectangle")
            {
                RectangleArea();
            }

            else
            {
                Console.WriteLine("That is not a valid choice, please try again.");
            }

        }


        //Step 2 Create 4 Methods
        // Circle Area Method

        public static void CircleArea()
        {
            Console.WriteLine("What is the circle's radius?");
            double radius = double.Parse(Console.ReadLine());

            double pie = 3.14;
            double area = (pie * (radius * radius));

            Console.WriteLine($"The area of the circle is: {area}");

        }

        //  Triangle Area Method

        public static void TriangleArea()
        {

            Console.WriteLine("What is the triangle's height?");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine("What is the triangle's base length?");
            double baseLength = double.Parse(Console.ReadLine());

            double area = height * baseLength * .5;
            Console.WriteLine($"The area of the triangle is: {area}");



        }


        // Rectangle Area Method

        public static void RectangleArea()
        {

            Console.WriteLine("What is the rectangle's width?");
            double width = double.Parse(Console.ReadLine());

            Console.WriteLine("What is the rectangle's length?");
            double length = double.Parse(Console.ReadLine());

            double area = width * length;
            Console.WriteLine($"The area of the rectangle is: {area}");

        }


        //Square Area Method

        public static void SquareArea()
        {


            Console.WriteLine("What is the square's side length?");
            double side = double.Parse(Console.ReadLine());

            double area = side * side;
            Console.WriteLine($"The area of the square is: {area}");
        }
    }
}
