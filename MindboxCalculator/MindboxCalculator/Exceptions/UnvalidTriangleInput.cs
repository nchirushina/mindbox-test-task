namespace MindboxCalculator.Exceptions
{
    public class UnvalidTriangleInput : Exception
    {
        public override string Message { get; }
        public UnvalidTriangleInput(string message)
        {
            this.Message = message;
        }
    }
}
