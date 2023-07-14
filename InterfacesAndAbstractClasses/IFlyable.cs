namespace InterfacesAndAbstractClasses
{
	interface IFlyable
	{
		Coordinate CurrentPosition { get; set; }
		double Speed { get; set; }
		
		void FlyTo(Coordinate newPosition);
		TimeSpan GetFlyTime(Coordinate newPosition);

		double GetDistance(Coordinate newPosition);

		string GetDescription();
	}
}