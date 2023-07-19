using OOP.TypesOfTransport;

namespace OOP
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var hondaForza = new Scooter("HondaForza", "Sports",
											new("Four stroke", 5, 300, "1P39FMB"),
											new("single speed", 3, "Honda"), 
											new(2, "45AS345A", 150));

			var mercedesBenzActros = new Truck("Mercedes Benz Actros", "Jumbo",
											new("Six-cylinder", 394, 11946, "OM 501 LA"),
											new("Powershift", 12, "Mercedes-Benz"),
											new(8,"8577GTH12W",25000));

			var peugeot307 = new Car("Peugeot307", "Hatchback", 5,
											new("Petrol", 175, 1997, "EW10 16-valve I4,"),
											new("Automatic", 6, "Aisin Seiki"),
											new(4, "9870GRT56R", 608));

			var mercedesBenzTourismo = new Bus("Mercedes Benz Tourismo",1, 28,
											new("6-cylinder",428, 7698, "OM 936.971"),
											new("Automatic", 6, "Mercedes-Benz"),
											new(6, "8569GRT56Q", 19000));

			var transports = new List<Transport>() { hondaForza, mercedesBenzActros, mercedesBenzTourismo, peugeot307 };

			foreach (Transport transport in transports)
			{
				Console.WriteLine(transport.GetStringWithAllInformation());
			}
		}
	}
}