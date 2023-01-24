using MindboxCalculator.Exceptions;
using MindboxCalculator.Figures;
using MindboxCalculator.Strings;

namespace MindboxCalculator
{
    internal class FigureFactory
    {
        public AbstractFigure CreateFigure(List<double> parameters)
        {
            var figureType = DefineFigure(parameters);

            switch (figureType)
            {
                case FigureType.circle:
                    return new Circle(parameters);

                case FigureType.triangle:
                    return new Triangle(parameters);

                default:
                    throw new UnknownFigureException(ExceptionString.UnknownFigure);
            }
        }

        #region PrivateMethods
        private FigureType DefineFigure(List<double> parameters)
        {
            var numberOfParametres = parameters.Count();

            switch (numberOfParametres)
            {
                case 1:
                    return FigureType.circle;
                case 3:
                    return FigureType.triangle;
                default:
                    return FigureType.unknown;
            }
        }
        #endregion PrivateMethods
    }
}
