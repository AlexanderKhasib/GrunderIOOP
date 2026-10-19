namespace GrunderiOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create new circle object with radius 5 for the first circle, and radius 6 for the second circle
            Circle circle1 = new Circle(5);
            Circle circle2 = new Circle(6);

            // Create new triangle object with the base of the triangle being 5, and the height being 6
            Triangle triangle = new Triangle(5, 6);

            // Calculate the values for the circles and print out values.
            Console.WriteLine("Cirkel 1\n");
            circle1.PrintValues();
            Console.WriteLine("\nCirkel 2\n");
            circle2.PrintValues();

            // Calculate the area for the triangle and print out the value
            Console.WriteLine("\nVärden för Triangel\n");
            triangle.GetArea();
        }
    }
}
