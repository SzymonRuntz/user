namespace EnumExample
{
    public class Bike
    {
        public string Name { get; set; }

        public int Size { get; set; }

        public int WheelSize { get; set; }

        public Crank Crank { get; set; }

        public BikeTypes BikeType { get; set; }
    }
}
