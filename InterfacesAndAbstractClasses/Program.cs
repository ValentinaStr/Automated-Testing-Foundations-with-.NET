namespace InterfacesAndAbstractClasses
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var flyable = new Сreator();

			var flyingObject =  flyable.CreateFlyingObject();

			Console.ForegroundColor = ConsoleColor.Yellow;

			Console.WriteLine($"The {flyingObject.GetDescription()} you created wants to fly.");

			var newPosition = flyable.GetCoordinatePosition();
			
			flyingObject.FlyTo(newPosition);
		}
	}
}