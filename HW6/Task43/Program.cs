// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] Function(double k1, double b1, double k2, double b2)
{
    double x = Math.Round((b2 - b1) / (k1 - k2), 1, MidpointRounding.AwayFromZero);
    double y = Math.Round((b1 / k1 - b2 / k2) / (1 / k1 - 1 / k2), 1, MidpointRounding.AwayFromZero);
    double[] result = new double[] { x, y };
    return result;
}

double[] EnterCoefficients(string number, string coefficient)
{
    Console.WriteLine($"Введите коэффициенты для {number} прямой, заданной уравнением y = k * x + b: ");
    Console.Write($"k{coefficient} = ");
    double k = Convert.ToDouble(Console.ReadLine());
    Console.Write($"b{coefficient} = ");
    double b = Convert.ToDouble(Console.ReadLine());
    double[] coefficients = new double[] { k, b };
    return coefficients;
}

Console.Clear();

double[] firstLine = EnterCoefficients("первой", "1");
double[] secondLine = EnterCoefficients("второй", "2");

double[] coordinates = Function(firstLine[0], firstLine[1], secondLine[0], secondLine[1]);
Console.Write($"Точка пересечения двух прямых -> ({coordinates[0]}; {coordinates[1]})");
