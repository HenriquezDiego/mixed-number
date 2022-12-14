using Algorithms;

namespace ApplicationUnitTests;

public class MainUnitTest
{
    [Fact]
    public void ConvertFromMixedFractionToFraction()
    {
        var mixedNumber = new MixedFraction(3, new Fraction(1, 2));
        var mixedNumber2 = new MixedFraction(2, new Fraction(3, 4));
        var f2 = mixedNumber2.ConvertToFraction();
        var fraction = mixedNumber.ConvertToFraction();
        Assert.Equal("7/2",fraction.ToString());
        Assert.Equal("11/4",f2.ToString());
    }

    [Fact]
    public void SimplifyFractions()
    {
        Assert.Equal("5/4",new Fraction(15,12).Simplify().ToString());
    }

    [Fact]
    public void MixedFractionAddition()
    {
        var n1 = new MixedFraction(3, new Fraction(1, 2));
        var n2 = new MixedFraction(2, new Fraction(3, 4));
        var result = n1.Addition(n2);
        Assert.Equal("6 1/4", result.ToString());
    }

    [Fact]
    public void MixedFractionAdditionNegative()
    {
        var n1 = new MixedFraction(-8, 2, 5);
        var result = n1.ConvertToFraction();
        Assert.Equal("-42/5",result.ToString());
    }

    [Fact]
    public void AddFractionAdditionNegative()
    {
        var f1 = new Fraction(3,4);
        var f2 = new Fraction(1,3);
        var result = f1 + (-f2);
        Assert.Equal("5/12",result.ToString());
    }


}