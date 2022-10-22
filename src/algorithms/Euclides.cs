namespace Algorithms
{
	public class Euclides
	{
		public static int GetGcdBySubtraction(int n, int d)
		{
			while (n != 0 && d != 0)
			{
				if (n > d)
					n -= d;
				else
					d -= n;
			}
			return Math.Max(n, d);
		}
	}
}
