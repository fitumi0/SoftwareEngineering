namespace Task.Discriminant;

/// <summary>
/// Калькулятор дискриминанта.
/// </summary>
public class DiscriminantCalculator
{
    /// <summary>
    /// Возвращает дискриминант.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="c"></param>
    /// <returns></returns>
    public static double Discriminant(double a, double b, double c)
    {
        return Math.Pow(b, 2) - 4 * a * c;
    }

    /// <summary>
    /// Возвращает все результаты когда дискриминант больше нуля.
    /// </summary>
    /// <param name="desctiminant"></param>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    private static (double x1, double x2) GetTwoResults(double desctiminant, double a, double b)
    {
        return (
            (-b + Math.Sqrt(desctiminant)) / (2 * a),
            (-b - Math.Sqrt(desctiminant)) / (2 * a));
    }

    /// <summary>
    /// Возвращает результат когда дискриминант равен 0.
    /// </summary>
    /// <param name="desctiminant"></param>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    private static double GetOneResult(double a, double b)
    {
        return (-b) / 2 * a;
    }

    /// <summary>
    /// Возвращает корни дискриминанта.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="c"></param>
    /// <returns>Double[]</returns>
    public static double[] GetRoots(double a, double b, double c)
    {
        var d = Discriminant(a, b, c);

        if (d < 0)
        {
            return Array.Empty<double>();
        }

        if (d == 0)
        {
            return new double[1]
            {
                GetOneResult(a, b)
            };
        }

        var (x1, x2) = GetTwoResults(d, a, b);

        return new double[2]
        {
            x1, x2
        };
    }
}
