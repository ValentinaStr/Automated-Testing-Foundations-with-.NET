using OOP.Specification;

namespace OOP.TypesOfTransport
{
	internal class Bus : Transport
	{
		internal int NumberOfFloors { get; set; }
		internal int NumberOfSeats { get; set; }

		public Bus(string model, int numberOfFloors, int numberOfSeats, Engine engine, Transmission transmission, Chassis chassis) : base(model, engine, transmission, chassis)
		{
			NumberOfFloors = numberOfFloors;
			NumberOfSeats = numberOfSeats;
		}

		internal override string GetStringWithAllInformation()
		{
			return base.Model + 
				"\n Bus with the following characteristics:" + 
				"\n Number Of Floors:" + NumberOfFloors +
				"\n Number Of Seats:" + NumberOfSeats +
				base.GetStringWithAllInformation();
		}
	}
}
