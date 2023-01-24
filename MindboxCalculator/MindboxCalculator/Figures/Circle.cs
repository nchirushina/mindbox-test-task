using MindboxCalculator.Configuration;
using MindboxCalculator.Strings;

namespace MindboxCalculator.Figures
{
    public class Circle : AbstractFigure
    {
        private double Pi = Math.PI;
        private double Radius { get; set; }
        public Circle(double radius) : base(FigureType.circle)
        {
            TryInput(radius);

            this.Radius = radius;
        }

        public override double GetSquare()
        {
            var square = Pi * Radius * Radius;
            var accurateSquare = Math.Round(square, CalculatorConfig.Accuracy);

            return accurateSquare;
        }
    }
}
