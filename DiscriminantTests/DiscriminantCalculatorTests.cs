using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task.Discriminant.Tests;

[TestClass()]
public class DiscriminantCalculatorTests
{
    [TestMethod()]
    [DataRow(2, 2, 2, -12)]
    [DataRow(-1, 0, 0, 0)]
    [DataRow(0, 2, 0, 4)]
    [DataRow(-5, 1, 4, 81)]
    public void DiscriminantValidTest(double a, double b, double c, double expected)
    {
        Assert.AreEqual(
            expected,
            DiscriminantCalculator.Discriminant(a, b, c));
    }

    [TestMethod()]
    [DataRow(-5, 1, 4, -20)]
    public void CalculateValidTest(double a, double b, double c, double expected)
    {
        Assert.AreEqual(expected, DiscriminantCalculator.Calculate(a, b, c)[0]);
    }
}