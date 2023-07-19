using OOP.Specification;
namespace OOP.TypesOfTransport
{
	internal class Car : Transport
	{
		internal string BodyStyle { get; set; }
		internal int NumberOfSeats { get; set; }

		public Car(string model, string bodyStyle, int numberOfSeats, Engine engine, Transmission transmission, Chassis chassis) : base(model,engine, transmission, chassis)
		{
			BodyStyle = bodyStyle;
			NumberOfSeats = numberOfSeats;
		}

		internal override string GetStringWithAllInformation()
		{
			return base.Model + 
				"\n Passenger car with the following characteristics:" + 
				"\n Body Style:" + BodyStyle + 
				"\n Number Of Seats:" + NumberOfSeats +
				base.GetStringWithAllInformation();
		}
	}
}