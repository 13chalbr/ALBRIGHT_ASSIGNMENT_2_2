namespace ALBRIGHT_ASSIGNMENT_2_2
{
    internal class Program
    {
        /* MSSA CCAD 16 - CHRIS ALBRIGHT
         * DAY 06 - 12NOV2024
         * HOMEWORK 2-2
         * 
         * 
         * Write a base class: ‘Shape’ and add properties like id, name and color and method like ‘calculate area’ .
        Create a Class called 'Circle', inherit the base class from shape, and add properties like radius. Add an override to calculate area for circle.
        Create a Class called 'Square', inherit the case class from shape, and add change the calculate area logic. Add property like side of square.
        Take the input from user to select circle or square and display the calculated area . no hard coded values!
         * 
         */

        static void Main(string[] args)
        {

            double pi = Math.PI;
            double area;


            Console.WriteLine("Welcome to AreaSolver! \n\n Type desired shape (i.e. circle, square, etc.):");

            Shape shape1 = new Shape();
            Circle circle1 = new Circle();
            Square square1 = new Square();

            string choiceVar = Console.ReadLine();

            switch(choiceVar)
            {
                case "circle":

                    
                    Console.WriteLine("\nEnter the radius of the desired circle:");
                    circle1.Radius = Convert.ToDouble(Console.ReadLine());

                    area = Circle.CalcuateArea(pi, circle1.Radius);
                    Console.WriteLine("\nThe area of a circle with radius "+circle1.Radius+" == "+area);

                    break;

                case "square":
                    Console.WriteLine("\nEnter the side length of the desired square:");  
                    square1.Side = Convert.ToDouble(Console.ReadLine());

                    area = Square.CalcuateArea(square1.Side);
                    Console.WriteLine("\nThe area of a square with sidelength " + square1.Side + " == " + area);

                    break;

                default:
                    Console.WriteLine("\nIncorrect input, Try again...");
                    break;  
            }
        }
    }

    class Shape // base class (parent)
    {
        public string Id //property
        { get; set; }

        public string Name 
        { get; set; }    

        public string Color
        { get; set; }

        static void CalculateArea() //Method
        {
            // Placeholder for Area code
        }
    }

    class Circle : Shape
    {
        public double Radius
        { get; set; }

        public static double CalcuateArea(double a,double b)
        {
            return (a) * (b * b);
        }
    }

    class Square : Shape
    {
        public double Side
        { get; set; }

        public static double CalcuateArea(double c)
        {
            return c * c;
        }
    }
}
