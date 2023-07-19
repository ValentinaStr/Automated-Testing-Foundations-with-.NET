namespace OOP.Specification
{
    internal class Transmission
    {
        internal string Type;
        internal int NumberOfGears;
        internal string Manufacturer;
        public Transmission(string type, int numberOfGears, string manufacturer)
        {
            Type = type;
            NumberOfGears = numberOfGears;
            Manufacturer = manufacturer;
        }

        public string GetInformation()
        {
            return "Transmission : \n" +
                "  Type:" + Type +
                "\n  Number Of Gears:" + NumberOfGears +
                "\n  Manufacturer:" + Manufacturer +"\n";
		}
    }
}