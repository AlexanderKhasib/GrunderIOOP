namespace GrunderiOOP
{
    internal class Triangle
    {
        // My properties for the triangle values
        public double TriangleBase { get; set; }
        public double TriangleHeight { get; set; }

        // Constructor for triangle class
        public Triangle(double triangleBase, double triangleHeight)
        {
            TriangleBase = triangleBase;
            TriangleHeight = triangleHeight;
        }

        // My method to calculate the area of the triangle 
        public void GetArea()
        {
            // Save result in areaOfTriangle by multiplaying the triangles base and it's height then
            // dividing it by 2.
            double areaOfTriangle = Math.Round((TriangleBase * TriangleHeight) / 2, 1);
            Console.WriteLine($"Arean av triangel: {areaOfTriangle} \n");
        }
    }
}
