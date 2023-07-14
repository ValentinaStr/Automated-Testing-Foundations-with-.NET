namespace InterfacesAndAbstractClasses
{
	internal struct Coordinate
	{
		private double x;
		private double y;
		private double z;
		public double X
		{
			get => x; 
			set 
			{
				if (value >= 0)	{x = value;}
			}
		}

		public double Y
		{
			get => y; 
			set
			{
				if (value >= 0) {y = value; }
			}
		}

		public double Z
		{
			get => z;
			set 
			{ 
				if (value >= 0) {z = value;}
			}
		}

		public Coordinate(double x = 0, double y = 0, double z = 0)
		{
			X = x;
			Y = y;
			Z = z;
		}

		public string GetCoordinateToString()
		{
			return $"({x}:{y}:{z})";
		}
	}
}