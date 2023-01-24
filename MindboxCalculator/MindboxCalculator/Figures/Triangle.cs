using MindboxCalculator.Configuration;
using MindboxCalculator.Exceptions;
using MindboxCalculator.Strings;

namespace MindboxCalculator.Figures
{
    public class Triangle : AbstractFigure
    {
        private List<double> SidesDesc { get; set; }
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
                throw new UnvalidTriangleInput(ExceptionString.TriangleIsNotExist);
            }
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
    }
}
