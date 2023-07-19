using OOP.Specification;

namespace OOP.TypesOfTransport
{
	internal abstract class Transport
	{
		internal string Model { get; set; }
		internal Engine EngineInformation;
		internal Transmission TransmissionInformation;
		internal Chassis ChassisInformation;

		protected Transport(string model, Engine engineInformation, Transmission transmissionInformation, Chassis chassisInformation)
		{
			Model = model;
			EngineInformation = engineInformation;
			TransmissionInformation = transmissionInformation;
			ChassisInformation = chassisInformation;
		}

		internal virtual string GetStringWithAllInformation()
		{
			return "\n " + EngineInformation.GetInformation() + TransmissionInformation.GetInformation() + ChassisInformation.GetInformation() + "\n\n";
		}
	}
}