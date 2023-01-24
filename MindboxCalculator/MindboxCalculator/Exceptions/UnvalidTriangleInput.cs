namespace MindboxCalculator.Exceptions
{
    internal class UnvalidTriangleInput : Exception
    {
        private string Message { get; set; }
        internal UnvalidTriangleInput(string message)
        {
            this.Message = message;
        }
    }
}
