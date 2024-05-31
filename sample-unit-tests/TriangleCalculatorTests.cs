using NUnit.Framework;
using sample;


namespace sample_unit_tests
{
    public class TriangleCalculatorTests
    {
        [Test]
        public void CalculateArea_WithPositiveBaseLengthAndHeight_ReturnsCorrectArea()
        {
            // Arrange
            double baseLength = 5;
            double height = 4;
            double expectedArea = 10;

            TriangleCalculator calculator = new TriangleCalculator();

            // Act
            double actualArea = calculator.CalculateArea(baseLength, height);

            // Assert
            Assert.AreEqual(expectedArea, actualArea);
        }

        [Test]
        public void CalculateArea_WithZeroBaseLength_ReturnsZeroArea()
        {
            // Arrange
            double baseLength = 0;
            double height = 10;
            double expectedArea = 0;

            TriangleCalculator calculator = new TriangleCalculator();

            // Act
            double actualArea = calculator.CalculateArea(baseLength, height);

            // Assert
            Assert.AreEqual(expectedArea, actualArea);
        }

        [Test]
        public void CalculateArea_WithZeroHeight_ReturnsZeroArea()
        {
            // Arrange
            double baseLength = 8;
            double height = 0;
            double expectedArea = 0;

            TriangleCalculator calculator = new TriangleCalculator();

            // Act
            double actualArea = calculator.CalculateArea(baseLength, height);

            // Assert
            Assert.AreEqual(expectedArea, actualArea);
        }

        [Test]
        public void CalculateArea_WithNegativeBaseLengthAndHeight_ReturnsCorrectArea()
        {
            // Arrange
            double baseLength = -6;
            double height = -3;
            double expectedArea = 9;

            TriangleCalculator calculator = new TriangleCalculator();

            // Act
            double actualArea = calculator.CalculateArea(baseLength, height);

            // Assert
            Assert.AreEqual(expectedArea, actualArea);
        }
    }
}
