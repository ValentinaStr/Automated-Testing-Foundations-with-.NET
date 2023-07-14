namespace InterfacesAndAbstractClasses
{
	internal class Drone : IFlyable
	{
		/*For all objects, the following units of measurement are used: speed km/h, distance km.
		Drone hovering in the air every 10 minutes of flight for 1 minute.
		The MaxDistance is 1000 km 
		The MaxSpeed is 250 km/h */

		internal static readonly double MaxDistance = 1000; //km
		internal static readonly double MaxSpeed = 250; //km/h
		public Coordinate CurrentPosition { get; set; }
		public double Speed { get; set; }

		public Drone(Coordinate currentPosition, double speed)
		{
			CurrentPosition = currentPosition;
			Speed = speed;
		}

		public static double GetSpeed()
		{
			//Get drone speed in the range of 0-250 km/h

			Console.Write("Please select speed for your drone. \n" +
						"Speed = ");
			try
			{
				var speed = Convert.ToDouble(Console.ReadLine());
				if (speed <=  MaxSpeed && speed > 0)
				{
					return speed;
				}
				Console.WriteLine($"You have entered an invalid speed. Max speed is {MaxSpeed} km/h.\n Please try again.");
				return GetSpeed();
			}

			catch 
			{
				Console.Write("You have entered an invalid speed. Please try again");				
				return GetSpeed();
			}
		}

		public string GetDescription()
		{
			return $"Drone is on position {CurrentPosition.GetCoordinateToString()} with speed {Speed}";
		}

		public void FlyTo(Coordinate newPosition)
		{
			//Check distance 
			//Write coordinate of new position (X:Y:X);
			//Write distanse to new position (km)
			//Write time to new position (h)

			if (GetDistance(newPosition) > MaxDistance)
			{
				newPosition = GetCoordinateMaxDistance(newPosition);
			}

			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine($"Distance to the new position is {GetDistance(newPosition)} km");
			Console.WriteLine($"Flight to the new position takes time {GetFlyTime(newPosition)}.");
			CurrentPosition = newPosition;
			Console.WriteLine(GetDescription());
			Console.ForegroundColor = ConsoleColor.White;
		}

		public TimeSpan GetFlyTime(Coordinate newPosition)
		{
			//Return time to new position with hovering in the air every 10 minutes of flight for 1 minute 

			if (Speed == 0)
			{
				Console.WriteLine("The Drone ran out of fuel, you need to refuel it.");
				return TimeSpan.Zero;
			}

			var pauseTime = GetDistance(newPosition) / Speed * 0.1;
			var flightTime = GetDistance(newPosition) / Speed;
			var allFlightTime = TimeSpan.FromHours(Math.Round(pauseTime + flightTime, 2));
			return allFlightTime;
		}

		public double GetDistance(Coordinate newPosition)
		{
			//Return distanse to new position (km)

			return Math.Round(Math.Sqrt(Math.Pow(newPosition.X - CurrentPosition.X, 2) +
						Math.Pow(newPosition.Y - CurrentPosition.Y, 2) +
						Math.Pow(newPosition.Z - CurrentPosition.Z, 2)), 2);
		}

		private Coordinate GetCoordinateMaxDistance(Coordinate newPosition)
		{
			//Check distance to new position
			//Returns coordinate of the maximum flight distance

			var possiblePartOfTheFlight = MaxDistance / GetDistance(newPosition);

			Coordinate position = new(Math.Round(CurrentPosition.X + (newPosition.X - CurrentPosition.X) * possiblePartOfTheFlight,0),
				Math.Round(CurrentPosition.Y + (newPosition.Y - CurrentPosition.Y) * possiblePartOfTheFlight,0),
				Math.Round(CurrentPosition.Z + (newPosition.Z - CurrentPosition.Z) * possiblePartOfTheFlight,0));


			Console.WriteLine($"The maximum drone flight distance only {MaxDistance}." +
							$"So it fell in the following coordinates {position.GetCoordinateToString()}");

			return position;
		}
	}
}