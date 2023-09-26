namespace Task.Discriminant;

internal class Program
{
    static void Main(string[] args)
    {
        var a = -5;
        var b = 1;
        var c = 4;

        foreach (var x in DiscriminantCalculator.Calculate(a, b, c))
        {
            Console.WriteLine(x);
        }
    }
}
