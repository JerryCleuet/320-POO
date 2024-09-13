using Drones.Model;

namespace Drones
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Création de la flotte de drones
            List<Drone> fleet= new List<Drone>();
            Drone drone = new Drone();
            drone.X = 100;
            drone.Y = 100;
            drone.Name = "Joe";
            fleet.Add(drone);

            List<Building> buildings = new List<Building>();
            Building building = new Building();
            building.X = 300;
            building.Y = 500;
            buildings.Add(building);
            

            List<Factory> factorys = new List<Factory>();
            Factory factory = new Factory();
            building.X =1000;
            building.Y = 500;
            factorys.Add(factory);

            List<Store> stores = new List<Store>();
            Store store = new Store();


            // Démarrage
            Application.Run(new AirSpace(fleet, buildings, factorys));           
        }
    }
}