using OOP.Specification;

namespace OOP.TypesOfTransport

{
	internal class Scooter : Transport
	{
		internal string TypeOfScooter { get; set; }

		public Scooter(string model, string typeOfScooter, Engine engine, Transmission transmission, Chassis chassis) : base(model, engine, transmission, chassis)
		{
			TypeOfScooter = typeOfScooter;
		}

		internal override string GetStringWithAllInformation()
		{
			return base.Model + "\n Scooter with the following characteristics:" +
				"\n Type Of Scooter:" + TypeOfScooter +
				base.GetStringWithAllInformation();
		}
	}
}