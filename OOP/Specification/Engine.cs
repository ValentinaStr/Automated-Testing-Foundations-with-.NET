namespace OOP.Specification
{
    internal class Engine
    {
        internal string Type;
        internal int Power;
        internal int Volume;
        internal string SerialNumber;
        public Engine(string type, int power, int volume, string serialNumber)
        {
            Type = type;
            Power = power;
            Volume = volume;
            SerialNumber = serialNumber;
        }

		public string GetInformation()
		{
            return "Engine:  \n" +
                "  Type: " + Type +
				"\n  Power: " + Power +
				"\n  Voume: " + Volume +
                "\n  Serial Number:" + SerialNumber + "\n";
		}
	}
}