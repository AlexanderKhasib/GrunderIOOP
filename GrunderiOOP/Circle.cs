namespace GrunderiOOP
{
    internal class Circle
    {
        // My properties for circle values
        public double Radius { get; set; }

        // Constructer for Circle class
        public Circle(double radius)
        {
            Radius = radius;
        }

        // My method to calculate the area of the circles
        public void GetArea()
        {
            // Save result in getCircleArea1 and getCircleArea2 by calculating area with
            // Math.Pi * Math.Pow (to calculate the radius squared) 
            // and Math.Round to shorten the result to one decimal. 
            double area = Math.Round(Math.PI * Math.Pow(Radius, 2), 1);

            // Print out the areas of the circles
            Console.WriteLine($"Area: {area}");

        }

        // My method to calculate the circumference of the circles.
        public void GetCircumference()
        {
            // Save result in getCircumference1 and 2, Calculate the circumference by multiplying 2 
            // With Math.PI * circle radius. Math.Round to shorten the result to one decimal.
            double circumference = Math.Round(2 * Math.PI * Radius, 1);


            // Print out the circumference of the circles
            Console.WriteLine($"Omkrets: {circumference}");

        }

        // My method to calculate Volume of sphere / circle.
        public void GetVolume()
        {
            // Save result in getVolume1 and 2, Calculate the volume by multiplying Math.Pi with Circle radius squared 3 times
            // With Math.Pow, then multiply it with 4, lastly divide by 3.
            // Math.Round again to shorten the result to one decimal.
            double volume = Math.Round((4.0 / 3.0) * Math.PI * Math.Pow(Radius, 3), 1);

            // Print out the volumes of the circles / spheres
            Console.WriteLine($"Volym: {volume}");

        }

        public void PrintValues()
        {
            GetArea();
            GetCircumference();
            GetVolume();
        }
    }
}
