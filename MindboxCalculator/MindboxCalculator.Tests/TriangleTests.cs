using MindboxCalculator.Configuration;
using MindboxCalculator.Exceptions;
using MindboxCalculator.Figures;

namespace MindboxCalculator.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void WhenValidInput_ThenValidOutput()
        {
            //Arrange
            var firstSide = 1;
            var seconSide = 1;
            var thirdSide = 1;

            var expectedOutput = Math.Round(0.433013, CalculatorConfig.Accuracy);

            //Act
            var testTriangle = new Triangle(firstSide, seconSide, thirdSide);
            var output = testTriangle.GetSquare();

            //Assert
            Assert.AreEqual(expectedOutput, output);
        }

        [TestMethod]
        public void WhenUnValidInput_ThenTriangleException()
        {
            //Arrange
            var firstSide = 1;
            var seconSide = 1;
            var thirdSide = 20;


            //Assert
            Assert.ThrowsException<UnvalidTriangleInputException>(
                () => new Triangle(firstSide, seconSide, thirdSide));
        }

        [TestMethod]
        public void WhenRectangularTriangleInput_ThenTrueRectangularProperty()
        {
            //Arrange
            var firstSide = 3;
            var seconSide = 4;
            var thirdSide = 5;

            var expectedProperty = true;

            //Act
            var testTriangle = new Triangle(firstSide, seconSide, thirdSide);
            var property = testTriangle.IsRectangular;

            //Assert
            Assert.AreEqual(expectedProperty, property);
        }
    }
}
