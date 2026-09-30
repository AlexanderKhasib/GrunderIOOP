namespace GrunderiOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create new circle object with radius 5 for the first circle, and radius 6 for the second circle
            Circle circle = new Circle(5, 6);

            // Create new triangle object with the base of the triangle being 5, and the height being 6
            Triangle triangle = new Triangle(5, 6);

            // Calculate the values for the circles and print out values.
            circle.GetArea();
            circle.GetCircumference();
            circle.GetVolume();

            // Calculate the area for the triangle and print out the value
            triangle.GetArea();
        }
    }
}
