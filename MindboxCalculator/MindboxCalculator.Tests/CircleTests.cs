using MindboxCalculator.Configuration;
using MindboxCalculator.Figures;

namespace MindboxCalculator.Tests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void WhenValidInpit_ThenValidOutput()
        {
            //Arrange
            var validRadius = 6;
            var expectedSquare = Math.Round(113.0973355292325, CalculatorConfig.Accuracy);

            //Act
            var testCircle = new Circle(validRadius);
            var output = testCircle.GetSquare();

            //Assert
            Assert.AreEqual(expectedSquare, output);
        }
    }
}