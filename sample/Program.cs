namespace sample
{
    internal class Program
    {
        static void Main()
        {
            double baseLenght = 10;
            double height = 10;
            
            TriangleCalculator triangleCalculator = new TriangleCalculator();
            triangleCalculator.CalculateArea(baseLenght, height);
            
            CircleCalculator circleCalculator = new CircleCalculator();
            circleCalculator.CalculateArea(10);

            Console.WriteLine("Hello, World!");
        }
    }
}
