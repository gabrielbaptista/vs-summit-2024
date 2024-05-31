namespace sample
{
    public class CircleCalculator
    {
        /// <summary>
        /// Calculates the area of a circle.
        /// </summary>
        /// <param name="radius">The radius of the circle.</param>
        /// <returns>The area of the circle.</returns>
        public double CalculateArea(double radius)
        {
            if (radius <= 0)
            {
                return 0;
            }
            double area = Math.PI * radius * radius;
            return area;
        }
    }
}
