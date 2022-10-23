﻿namespace Algorithms
{
    public class MixedFraction
    {
        private readonly int _number;
        private readonly Fraction _fraction;

        public MixedFraction(int number, Fraction fraction)
        {
            _number = number;
            _fraction = fraction;
        }

        private int Number()
        {
            return _number;
        }

        private Fraction Fraction()
        {
            return _fraction;
        }

        public Fraction ConvertToFraction()
        {
            var d = Fraction().Denominator();
            var n = Fraction().Numerator();
            return new Fraction(Number() * d + n, d);
        }

        public static MixedFraction ConvertToMixedFraction(Fraction fraction)
        {
            var quotient = fraction.Numerator() / fraction.Denominator();
            var remainder = fraction.Denominator() % fraction.Numerator();
            return new MixedFraction(quotient, new Fraction(remainder, fraction.Denominator()));
        }
    }
}
