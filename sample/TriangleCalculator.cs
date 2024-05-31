namespace sample
{
    public class TriangleCalculator
    {
        /// <summary>
        /// Calculates the area of a triangle.
        /// </summary>
        /// <param name="baseLength">The length of the base of the triangle.</param>
        /// <param name="height">The height of the triangle.</param>
        /// <returns>The area of the triangle.</returns>
        public double CalculateArea(double baseLength, double height)
        {
            double area = (baseLength * height) / 2;
            return area;
        }
    }
}
