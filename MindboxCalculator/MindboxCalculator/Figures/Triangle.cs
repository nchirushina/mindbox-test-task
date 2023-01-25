using MindboxCalculator.Configuration;
using MindboxCalculator.Exceptions;
using MindboxCalculator.Interfaces;
using MindboxCalculator.Strings;

namespace MindboxCalculator.Figures
{
    public class Triangle : AbstractFigure, IRectangularCheck
    {
        private List<double> SidesDesc { get; set; }
        public bool IsRectangular { get; init; }

        public Triangle(
            double firstSide,
            double secondSide,
            double thirdSide
            ) : base(FigureType.triangle)
        {
            var sides = new List<double>();
            sides.Add(firstSide);
            sides.Add(secondSide);
            sides.Add(thirdSide);

            TryInput(sides);

            this.SidesDesc = SortByDesc(sides);

            if (!IsTriangleExist())
            {
                throw new UnvalidTriangleInputException(ExceptionString.TriangleIsNotExist);
            }

            this.IsRectangular = RectangularCheck();
        }

        public Triangle(List<double> parameters)
            : this(
                 parameters[0],
                 parameters[1],
                 parameters[2])
        {
        }

        private bool IsTriangleExist()
        {
            if (this.SidesDesc[0] <=
                this.SidesDesc[1] + this.SidesDesc[2])
            {
                return true;
            }

            return false;
        }

        private List<double> SortByDesc(List<double> sides)
        {
            var sortedSides = sides.OrderByDescending(s => s).ToList();

            return sortedSides;
        }

        public override double GetSquare()
        {
            var halfPerimetr = (
                this.SidesDesc[0] +
                this.SidesDesc[1] +
                this.SidesDesc[2])
                / 2;
            var square = Math.Sqrt(
                halfPerimetr
                * (halfPerimetr - this.SidesDesc[0])
                * (halfPerimetr - this.SidesDesc[1])
                * (halfPerimetr - this.SidesDesc[2]));

            square = Math.Round(square, CalculatorConfig.Accuracy);

            return square;
        }

        public bool RectangularCheck()
        {
            var squaredHupotenuse = Math.Pow(this.SidesDesc[0], 2);
            var sumOfSquaredCathets =
                Math.Pow(this.SidesDesc[1], 2)
                + Math.Pow(this.SidesDesc[2], 2);

            squaredHupotenuse = Math.Round(squaredHupotenuse, CalculatorConfig.InnerEstimationAccuracy);
            sumOfSquaredCathets = Math.Round(sumOfSquaredCathets, CalculatorConfig.InnerEstimationAccuracy);

            if (squaredHupotenuse == sumOfSquaredCathets)
            {
                return true;
            }

            return false;
        }
    }
}
