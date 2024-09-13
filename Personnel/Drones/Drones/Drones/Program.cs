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

            // Cr�ation de la flotte de drones
            List<Drone> fleet= new List<Drone>();
            Drone drone = new Drone();
            drone.X = 100;
            drone.Y = 100;
            drone.Name = "Joe";
            fleet.Add(drone);

            List<Building> buildings = new List<Building>();
            Building building = new Building();
            building.X = 300;
            building.Y = 400;
            buildings.Add(building);

            // D�marrage
            Application.Run(new AirSpace(fleet, buildings));           
        }
    }
}