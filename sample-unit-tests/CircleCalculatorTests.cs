using NUnit.Framework;
using sample;

namespace sample_unit_tests
{
    public class CircleCalculatorTests
    {
        [Test]
        public void CalculateArea_WithPositiveRadius_ReturnsCorrectArea()
        {
            // Arrange
            double radius = 5;
            double expectedArea = Math.PI * radius * radius;
            CircleCalculator calculator = new CircleCalculator();

            // Act
            double actualArea = calculator.CalculateArea(radius);

            // Assert
            Assert.AreEqual(expectedArea, actualArea);
        }

        [Test]
        public void CalculateArea_WithZeroRadius_ReturnsZeroArea()
        {
            // Arrange
            double radius = 0;
            double expectedArea = 0;
            CircleCalculator calculator = new CircleCalculator();

            // Act
            double actualArea = calculator.CalculateArea(radius);

            // Assert
            Assert.AreEqual(expectedArea, actualArea);
        }

        [Test]
        public void CalculateArea_WithNegativeRadius_ReturnsZeroArea()
        {
            // Arrange
            double radius = -5;
            double expectedArea = 0;
            CircleCalculator calculator = new CircleCalculator();

            // Act
            double actualArea = calculator.CalculateArea(radius);

            // Assert
            Assert.AreEqual(expectedArea, actualArea);
        }
    }
}
