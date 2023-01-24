using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("MindboxCalculator.Tests")]

namespace MindboxCalculator.Configuration
{
    internal static class CalculatorConfig
    {
        internal static int Accuracy { get; set; } = 5;
    }
}
