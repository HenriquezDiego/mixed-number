namespace Algorithms
{
    public class Fraction
    {
        private readonly int _numerator;
        private readonly int _denominator;

        public Fraction(int n, int d)
        {
            _numerator = n;
            _denominator = d;
        }

        public int Numerator()
        {
            return _numerator;
        }

        public int Denominator()
        {
            return _denominator;
        }

        public bool IsProper()
        {
            return _numerator < _denominator;
        }
    }
}
