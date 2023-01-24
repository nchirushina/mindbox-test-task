namespace MindboxCalculator.Exceptions
{
    public class UnknownFigureException : Exception
    {
        public override string Message { get; }

        public UnknownFigureException(string message)
        {
            this.Message = message;
        }
    }
}
