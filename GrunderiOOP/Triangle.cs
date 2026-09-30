namespace GrunderiOOP
{
    internal class Triangle
    {
        // My properties for the triangle values
        public double _triangleBase { get; set; }
        public double _triangleHeight { get; set; }

        // Constructor for triangle class
        public Triangle(double triangleBase, double triangleHeight)
        {
            _triangleBase = triangleBase;
            _triangleHeight = triangleHeight;
        }

        // My method to calculate the area of the triangle 
        public void GetArea()
        {
            // Save result in areaOfTriangle by multiplaying the triangles base and it's height then
            // dividing it by 2.
            double areaOfTriangle = Math.Round((_triangleBase * _triangleHeight) / 2, 1);
            Console.WriteLine($"Arean av triangel: {areaOfTriangle} \n");
        }
    }
}
