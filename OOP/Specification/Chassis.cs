namespace OOP.Specification
{
    internal class Chassis
    {
        internal int CountOfWheels;
        internal string NumberOfChassis;
        internal int BearingCapacity;
        public Chassis(int countOfWheels, string numberOfChassis, int bearingCapacity)
        {
            CountOfWheels = countOfWheels;
            NumberOfChassis = numberOfChassis;
            BearingCapacity = bearingCapacity;
        }

		public string GetInformation()
		{
			return "Chassis:  \n" +
				"  Count Of Wheels: " + CountOfWheels +
				"\n  Number Of Chassis: " + NumberOfChassis +
				"\n  Bearing Capacity:" + BearingCapacity;
		}
	}
}