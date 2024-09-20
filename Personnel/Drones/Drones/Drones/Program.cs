using Drones;

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

            List<Factory> factorys = new List<Factory>();
            Factory factory = new Factory();
            factory.X =800;
            factory.Y = 500;
            factorys.Add(factory);
            Console.WriteLine("Consommation de l'usine :\n15KW/h");
            

            List<Store> stores = new List<Store>();
            Store store = new Store();
            store.X = 400;
            store.Y = 500;
            stores.Add(store);
            Console.WriteLine("Horaires du magasin :\nLundi 8h-17h\nMardi 8h-17h\nAutres jours : fermé");

            // Démarrage
            Application.Run(new AirSpace(fleet, factorys, stores));           
        }
    }
}