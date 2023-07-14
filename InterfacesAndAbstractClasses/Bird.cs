namespace InterfacesAndAbstractClasses
{
	internal class Bird : IFlyable
	{
		/*For all objects, the following units of measurement are used: speed km/h, distance km.
		The bird flies the entire distance at a constant speed in the range of 0-20 km/h (given randomly).
		Max distance is 500 km.*/

		private const double MinSpeed = 0;
		private const double MaxSpeed = 20;
		public static readonly double MaxDistance = 500;
		public Coordinate CurrentPosition { get; set ; }
		public double Speed { get; set; }
		
		public Bird(Coordinate currentPosition)
		{
			CurrentPosition = currentPosition;
			Speed = GetBirdSpeed();
		}

		public string GetDescription()
		{
			return $"Bird is on position {CurrentPosition.GetCoordinateToString()} with speed {Speed}";
		}

		public void FlyTo(Coordinate newPosition)
		{
			//Check distance and speed
			//Write coordinate of new position (X:Y:X);
			//Write distanse to new position (km)
			//Write time to new position (h)

			if (Speed == 0)
			{
				Console.ForegroundColor = ConsoleColor.DarkRed;
				Console.WriteLine("Your bird is tired and does't want to fly.");
			}

			else if (GetDistance(newPosition) > MaxDistance)
			{
				Console.ForegroundColor = ConsoleColor.Black;
				Console.BackgroundColor = ConsoleColor.DarkRed;
				Console.WriteLine("A bird can't fly that long distance.");
				Console.ForegroundColor = ConsoleColor.White;
				Console.BackgroundColor = ConsoleColor.Black;
			}

			else
			{
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine($"Flight to new position takes time {GetFlyTime(newPosition)}.");
				Console.WriteLine($"Distatnce to new position {GetDistance(newPosition)} km");
				CurrentPosition = newPosition;
				Console.WriteLine(GetDescription());
				Console.ForegroundColor = ConsoleColor.White;
			}
		}

		public TimeSpan GetFlyTime(Coordinate newPosition)
		{
			//Return time to new position (h)

			if (Speed == 0)
			{
				Console.WriteLine("Your bird is tired and does't want to fly.");
				return TimeSpan.Zero;
			}
			else
			{
				return TimeSpan.FromHours(Math.Round(GetDistance(newPosition) / Speed, 2));
			}
		}

		public double GetDistance(Coordinate newPosition)
		{
			//Return distanse to new position (km)

			return Math.Round(Math.Sqrt(Math.Pow(newPosition.X - CurrentPosition.X, 2) +
					Math.Pow(newPosition.Y - CurrentPosition.Y, 2) +
					Math.Pow(newPosition.Z - CurrentPosition.Z, 2)),2);
		}

		private static double GetBirdSpeed()
		{
			//Return bird speed in the range of 0-20 km/h (given randomly)

			return Math.Round(RandomValueGenerator.GetRandomDouble(MinSpeed, MaxSpeed),2);
		}
	}
}