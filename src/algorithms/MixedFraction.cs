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

        public MixedFraction(int number, int numerator, int denominator)
        {
            _number = number;
            _fraction = new Fraction(numerator, denominator);
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
            var n = Math.Abs(Number()) * d + Fraction().Numerator();
            n = Number() < 0 ? -n : n;
            return new Fraction(n, d);
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
