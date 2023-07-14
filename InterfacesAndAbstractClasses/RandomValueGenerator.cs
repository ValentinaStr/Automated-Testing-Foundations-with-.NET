namespace InterfacesAndAbstractClasses
{
	internal static class RandomValueGenerator
	{
		private static Random random = new();

		public static double GetRandomDouble(double minimum, double maximum)
		{
			//Generate random double 

			return random.NextDouble() * (maximum - minimum) + minimum;
		}
	}
}
