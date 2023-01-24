namespace MindboxCalculator.Exceptions
{
    public class UnvalidTriangleInputException : Exception
    {
        public override string Message { get; }
        public UnvalidTriangleInputException(string message)
        {
            this.Message = message;
        }
    }
}
