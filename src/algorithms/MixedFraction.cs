namespace Algorithms
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

        public MixedFraction ConvertToMixedFraction(Fraction fraction)
        {
            var quotient = fraction.Numerator() / fraction.Denominator();
            var remainder = fraction.Denominator() % fraction.Numerator();
            return new MixedFraction(quotient, new Fraction(remainder, fraction.Denominator()));
        }

        public MixedFraction Addition(MixedFraction value)
        {
            var f1 = ConvertToFraction();
            var f2 = value.ConvertToFraction();
            var f3 = f1 + f2;
            f3 = f3.Simplify();
            return f3.ConvertToMixedFraction();
        }

        public override string ToString()
        {
            return $"{Number()} {Fraction().Numerator()}/{Fraction().Denominator()}";
        }
    }
}
