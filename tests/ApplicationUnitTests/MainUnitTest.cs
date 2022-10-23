using Algorithms;

namespace ApplicationUnitTests;

public class MainUnitTest
{
    [Fact]
    public void ConvertFromMixedFractionToFraction()
    {
        var mixedNumber = new MixedFraction(3, new Fraction(1, 2));
        var mixedNumber2 = new MixedFraction(2, new Fraction(3, 4));
        var f2 = MixedFraction.ConvertToFraction(mixedNumber2);
        var fraction = MixedFraction.ConvertToFraction(mixedNumber);
        Assert.Equal("7/2",fraction.ToString());
        Assert.Equal("11/4",f2.ToString());
    }

    [Fact]
    public void SimplifyFractions()
    {
        var x = Euclides.GetGcdBySubtraction(25, 4);
        Assert.Equal(2, x);
    }
}