namespace Module1Review
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double circleAreaResult = CircleArea(4);
        }


        //Step 2 Create 4 Methods

        // Circle Area Method

        public static double CircleArea(double radius)
        {


            double pie = 3.14;
            double area = (pie * (radius * radius));

            return area;

        }

        //  Triangle Area Method

        public static double TriangleArea(double height, double baseLength)
        {
            double area = height * baseLength * .5;
            return area;
        }


        // Rectangle Area Method

        public static double RectangleArea(double width, double height)
        {
            double area = width * height;

            return area;
        }


        //Square Area Method

        public static double SquareArea(double side)
        {
            double area= side * side;

            return area;
        }
    }
}
