namespace GrunderiOOP
{
    internal class Circle
    {
        // My properties for circle values
        public double _CircleRadius1 { get; set; }
        public double _CircleRadius2 { get; set; }

        // Constructer for Circle class
        public Circle(double Radius1, double Radius2)
        {
            _CircleRadius1 = Radius1;
            _CircleRadius2 = Radius2;
        }

        // My method to calculate the area of the circles
        public void GetArea()
        {
            // Save result in getCircleArea1 and getCircleArea2 by calculating area with
            // Math.Pi * Math.Pow (to calculate the radius squared) 
            // and Math.Round to shorten the result to one decimal. 
            double getCircleArea1 = Math.Round(Math.Pow(_CircleRadius1, 2) * MathF.PI, 1);
            double getCircleArea2 = Math.Round(Math.Pow(_CircleRadius2, 2) * MathF.PI, 1);

            // Print out the areas of the circles
            Console.WriteLine($"Area av cirkel 1: {getCircleArea1}");
            Console.WriteLine($"Area av cirkel 2: {getCircleArea2} \n");
        }

        // My method to calculate the circumference of the circles.
        public void GetCircumference()
        {
            // Save result in getCircumference1 and 2, Calculate the circumference by multiplying 2 
            // With Math.PI * circle radius. Math.Round to shorten the result to one decimal.
            double getCircumference1 = Math.Round(2 * Math.PI * _CircleRadius1, 1);
            double getCircumference2 = Math.Round(2 * Math.PI * _CircleRadius2, 1);

            // Print out the circumference of the circles
            Console.WriteLine($"Omkrets av cirkel 1: {getCircumference1}");
            Console.WriteLine($"Omkrets av cirkel 2: {getCircumference2} \n");
        }

        // My method to calculate Volume of sphere / circle.
        public void GetVolume()
        {
            // Save result in getVolume1 and 2, Calculate the volume by multiplying Math.Pi with Circle radius squared 3 times
            // With Math.Pow, then multiply it with 4, lastly divide by 3.
            // Math.Round again to shorten the result to one decimal.
            double getVolume1 = Math.Round(Math.PI * Math.Pow(_CircleRadius1, 3) * 4 / 3, 1);
            double getVolume2 = Math.Round(Math.PI * Math.Pow(_CircleRadius2, 3) * 4 / 3, 1);

            // Print out the volumes of the circles / spheres
            Console.WriteLine($"Volym av cirkel 1: {getVolume1}");
            Console.WriteLine($"Volym av cirkel 2: {getVolume2} \n");
        }
    }
}
