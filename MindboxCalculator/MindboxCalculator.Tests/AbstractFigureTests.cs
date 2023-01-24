namespace MindboxCalculator.Tests
{
    [TestClass]
    public class AbstractFigureTests
    {
        [TestMethod]
        public void WhenNegativeInput_ThenArgumentException()
        {
            //Arrange
            var negativeInput = -6;
            var testFigure = new SUT(negativeInput);

            //Assert
            Assert.ThrowsException<ArgumentException>(
                () => testFigure.TryInput(negativeInput));
        }

        [TestMethod]
        public void WhenManyNegativeInputs_ThenArgumentException()
        {
            //Arrange
            var negativeInput = new List<double> { 6, -5 };
            var testFigure = new SUTWithManyParameters(negativeInput);

            //Assert
            Assert.ThrowsException<ArgumentException>(
                () => testFigure.TryInput(negativeInput));
        }
    }

    internal class SUTWithManyParameters : AbstractFigure
    {
        private List<double> negativeInput;

        public SUTWithManyParameters(List<double> negativeInput) : base(FigureType.unknown)
        {
            this.negativeInput = negativeInput;
        }

        public override double GetSquare()
        {
            throw new NotImplementedException();
        }
    }

    internal class SUT : AbstractFigure
    {
        private double negativeInput;

        public SUT(double negativeInput) : base(FigureType.unknown)
        {
            this.negativeInput = negativeInput;
        }

        public override double GetSquare()
        {
            throw new NotImplementedException();
        }
    }
}
