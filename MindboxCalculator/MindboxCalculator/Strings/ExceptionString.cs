using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxCalculator.Strings
{
    internal static class ExceptionString
    {
        internal static string TriangleIsNotExist { get; } =
            @"Если большая сторона треугольника меньше суммы двух других сторон, значит треугольник существует, иначе он не существует";

        internal static string UncorrectInput { get; } = "Не корректный ввод. Введите число, большее нуля";
    }
}
