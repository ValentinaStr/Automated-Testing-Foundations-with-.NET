using OOP.Specification;
namespace OOP.TypesOfTransport
{
	internal class Truck : Transport
	{
		internal string TrailerType { get; set; }

		public Truck(string model, string trailerType,  Engine engine, Transmission transmission, Chassis chassis) : base(model, engine, transmission, chassis)
		{
			TrailerType = trailerType;
		}
		internal override string GetStringWithAllInformation()
		{
			return base.Model + "\n Truck with the following characteristics:" +
				"\n Trailer Type:" + TrailerType +
				base.GetStringWithAllInformation();
		}
	}
}