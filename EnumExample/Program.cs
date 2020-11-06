namespace EnumExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var mtbCrank = new Crank
            {
                Weight = 922,
                BikeType = BikeTypes.MTB,
                Model = "XY256",
                NumberOfDiscs = 3,
                TypeOfMount = "Octalink"
            };

            var mtbBike = new Bike()
            {
                BikeType = BikeTypes.MTB
            };

            var updatedBike = MountCrankToBike(mtbBike, mtbCrank);
        }

        private static Bike MountCrankToBike(Bike bike, Crank crank)
        {
            if(bike.BikeType == crank.BikeType)
            {
                bike.Crank = crank;
            }

            return bike;
        }
    }
}
