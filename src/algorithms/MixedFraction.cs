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

        public int Number()
        {
            return _number;
        }

        public Fraction Fraction()
        {
            return _fraction;
        }
    }
}
