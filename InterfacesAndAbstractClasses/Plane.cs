namespace InterfacesAndAbstractClasses
{
	internal class Plane : IFlyable
	{
		/*For all objects, the following units of measurement are used: speed km/h, distance km.
		A Plane increases its speed by 10 km/h every 10 km of flight from the initial speed of 200 km/h.
		The MaxSpeed is 925 km/h */

		internal static readonly double MaxSpeed = 925; // km/h
		public Coordinate CurrentPosition { get; set ; }
		public double Speed { get; set; } = 200; // km/h
		
		public Plane(Coordinate currentPosition)
		{
			CurrentPosition = currentPosition;
		}

		public string GetDescription()
		{
			return $"Plane is on position {CurrentPosition.GetCoordinateToString()} with speed {Speed}";
		}

		public void FlyTo(Coordinate newPosition)
		{
			//Write coordinate of new position (X:Y:X);
			//Write distanse to new position (km)
			//Write time to new position (h)

			if (GetDistance(newPosition) == 0)
			{
				Console.ForegroundColor = ConsoleColor.DarkRed;
				Console.WriteLine("The plane ran out of fuel, you need to refuel it.");
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.Magenta;
				Console.WriteLine($"Flight to the new position takes time {GetFlyTime(newPosition)}.");
				Console.WriteLine($"Distatnce to the new position {GetDistance(newPosition)} km");
				CurrentPosition = newPosition;
				Console.WriteLine(GetDescription());
				Console.ForegroundColor = ConsoleColor.White;
			}
		}

		public TimeSpan GetFlyTime(Coordinate newPosition)
		{
			//Check max speed
			//Return time to new position 

			TimeSpan timeToFly = TimeSpan.Zero;
			var distance = GetDistance(newPosition);

			while (distance > 10 && Speed < MaxSpeed)
			{
				timeToFly += TimeSpan.FromHours(Math.Round(10 / Speed, 2));
				Speed = (Speed + 10 > MaxSpeed) ?  MaxSpeed :  Speed + 10;
				distance -= 10;
			}

			timeToFly += TimeSpan.FromHours(Math.Round(distance / Speed,2));
			return timeToFly;
		}

		public double GetDistance(Coordinate newPosition)
		{
			//Return distanse to new position (km)

			return Math.Round(Math.Sqrt(Math.Pow(newPosition.X - CurrentPosition.X, 2) +
					Math.Pow(newPosition.Y - CurrentPosition.Y, 2) +
					Math.Pow(newPosition.Z - CurrentPosition.Z, 2)), 2);
		}
	}
}