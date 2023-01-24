using MindboxCalculator.Strings;
using System.Runtime.CompilerServices;

//[assembly: InternalsVisibleTo("MindboxCalculator.Tests")]

namespace MindboxCalculator
{
    abstract public class AbstractFigure
    {
        internal FigureType FigureType { get; set; }

        internal AbstractFigure(FigureType figureType)
        {
            this.FigureType = figureType;
        }

        internal void TryInput(double inputParameter)
        {
            if (inputParameter == double.NaN
                || inputParameter < 0)
            {
                throw new ArgumentException(ExceptionString.UncorrectInput);
            }
        }

        internal void TryInput(List<double> inputParameters)
        {

            foreach (double inputParameter in inputParameters)
            {
                TryInput(inputParameter);
            }
        }

        abstract public double GetSquare();
        
    }
}
