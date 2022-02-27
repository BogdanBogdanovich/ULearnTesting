using NUnit.Framework;

namespace ULearnTesting.Tests;

public class Tests
{
    Calculation calculation = new Calculation();
    [Test]
    public void СompletedTestSum()
    {
        int a = 10;
        int b = 10;
        Assert.AreEqual(20, calculation.CalcSum(a,b));
    }
    [Test]
    public void FailedTestSum()
    {
        Assert.AreEqual(5, calculation.CalcSum(2,2));
    }
    
    [Test]
    public void СompletedTestSubtract()
    {
        Assert.AreEqual(0, calculation.CalcSubtract(2,2));
    }
    [Test]
    public void FailedTestSubtract()
    {
        Assert.AreEqual(-1, calculation.CalcSubtract(2,2));
    }
}