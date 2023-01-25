using MindboxCalculator.Configuration;
using MindboxCalculator.Exceptions;

namespace MindboxCalculator.Tests
{
    [TestClass]
    public class FigureFactoryTests
    {
        [TestMethod]
        public void WhenOneParametrInput_ThenValidOutput()
        {
            //Arrange
            var oneParametr = new List<double>() { 2 };

            var expectedValue = Math.Round(12.566370614359172, CalculatorConfig.Accuracy);

            //Act
            var testFactory = new FigureFactory();
            var testFigure = testFactory.CreateFigure(oneParametr);
            var output = testFigure.GetSquare();

            //Assert
            Assert.AreEqual(expectedValue, output);
        }

        [TestMethod]
        public void WhenThreeParametrInput_ThenValidOutput()
        {
            //Arrange
            var threeParameters = new List<double>() { 2, 3, 4 };

            var expectedValue = Math.Round(2.9047375096555625, CalculatorConfig.Accuracy);

            //Act
            var testFactory = new FigureFactory();
            var testFigure = testFactory.CreateFigure(threeParameters);
            var output = testFigure.GetSquare();

            //Assert
            Assert.AreEqual(expectedValue, output);
        }

        [TestMethod]
        public void WhenTwoParametrInput_ThenUnknownFigureException()
        {
            //Arrange
            var twoParameters = new List<double>() { 2, 200 };

            //Act
            var testFactory = new FigureFactory();

            //Assert
            Assert.ThrowsException<UnknownFigureException>(
                () => testFactory.CreateFigure(twoParameters));
        }
    }
}
