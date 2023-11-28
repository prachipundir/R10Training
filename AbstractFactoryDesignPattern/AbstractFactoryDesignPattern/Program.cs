namespace AbstractFactoryDesignPattern
{
    internal class Program
    {
        //CLIENT
        static void Main(string[] args)
        {
            //Fetching reglar bike and Car details creating 
            //creating RegularVehicleFatory Instance
            IVehicleFactory regularVehicleFactory = new RegularVehicleFactory();
            IBike regularBike = regularVehicleFactory.CreateBike();
            regularBike.GetDetails();

            ICar regularCar = regularVehicleFactory.CreateCar();
            regularCar.GetDetails();

            //Fetching sports bike and car details 
            //by cretaing SportsVehicleFactory Instance
            IVehicleFactory sportsVehicleFactory = new SportsVehicleFactory();
            IBike sportsBike = sportsVehicleFactory.CreateBike();
            sportsBike.GetDetails();

            ICar sportsCar = sportsVehicleFactory.CreateCar();
            sportsCar.GetDetails();
        }
    }
}