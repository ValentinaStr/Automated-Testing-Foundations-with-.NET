namespace InterfacesAndAbstractClasses
{
	internal class Сreator
	{
		//This class creates flying odject
		//For all objects, the following units of measurement are used: speed km/h, distance km.

		public Dictionary<string, string> flyable = new (){
				{"1", "Bird"},
				{"2", "Plane"},
				{"3", "Drone"},
				{"0", "Exit" }};

		public IFlyable CreateFlyingObject()
		{
			//Creates a list of flying objects and creates a selected one

			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.WriteLine("You have the ability to create a flying object and send it flying. \n" +
							"For all objects, the following units of measurement are used: speed km/h, distance km.\n " +
							"Please select which flying object you want to create: ");

			foreach (var item in flyable)
			{
				Console.WriteLine($"Enter {item.Key} for {item.Value}");
			}

			var flyingObject = GetFlyingObject(Console.ReadLine());

			return flyingObject;
		}

		public Coordinate GetCoordinatePosition()
		{
			//Get coordinates from console
			//Sets default coordinates

			Coordinate coordinate = new ();
			Console.WriteLine("Please select position for your flying object. Or it will be (0,0,0) by default.");

			try
			{
				Console.ForegroundColor = ConsoleColor.DarkYellow;
				Console.Write("X = ");
				Console.ForegroundColor = ConsoleColor.White;
				coordinate.X = Convert.ToInt16(Console.ReadLine());
				Console.ForegroundColor = ConsoleColor.DarkYellow;
				Console.Write("Y = ");
				Console.ForegroundColor = ConsoleColor.White;
				coordinate.Y = Convert.ToInt16(Console.ReadLine());
				Console.ForegroundColor = ConsoleColor.DarkYellow;
				Console.Write("Z = ");
				Console.ForegroundColor = ConsoleColor.White;
				coordinate.Z = Convert.ToInt16(Console.ReadLine());
			}

			catch 
			{
				coordinate = new(0, 0, 0);
			}

			Console.ForegroundColor = ConsoleColor.White;
			return coordinate;
		}

		public IFlyable? GetFlyingObject(string element)
		{
			switch (element)
			{
				case "1":
					Console.ForegroundColor = ConsoleColor.DarkYellow;
					Console.WriteLine($"A Bird flies the entire distance less when {Bird.MaxDistance} km" +
										$" at a constant speed in the range of 0-20 km/h (given randomly). \n");
					return new Bird(GetCoordinatePosition());

				case "2":
					Console.ForegroundColor = ConsoleColor.DarkGreen;
					Console.WriteLine($"A Plane increases its speed by 10 km/h every 10 km of flight from the initial speed of 200 km/h. \n" +
										$"The MaxSpeed is {Plane.MaxSpeed} km/h \n ");
					return new Plane(GetCoordinatePosition());

				case "3":
					Console.ForegroundColor = ConsoleColor.DarkYellow;
					Console.WriteLine($"A Drone hovering in the air every 10 minutes of flight for 1 minute.\n" +
										$"The MaxDistance is {Drone.MaxDistance} km \n" +
										$"The MaxSpeed is {Drone.MaxSpeed} km/h \n");
					return new Drone(GetCoordinatePosition(), Drone.GetSpeed());

				case "0":
					Environment.Exit(0);
					return null;

				default:
					Console.WriteLine("You have entered an invalid number. Please try again");
					return CreateFlyingObject();
			}
		}
	}
}