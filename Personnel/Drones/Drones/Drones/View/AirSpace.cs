using Drones;

namespace Drones
{
    // La classe AirSpace repr�sente le territoire au dessus duquel les drones peuvent voler
    // Il s'agit d'un formulaire (une fen�tre) qui montre une vue 2D depuis en dessus
    // Il n'y a donc pas de notion d'altitude qui intervient

    public partial class AirSpace : Form
    {
        // La flotte est l'ensemble des drones qui �voluent dans notre espace a�rien
        private List<Drone> fleet;
        private List<Factory> factorys;
        private List<Store> stores;
        static Dispatch dispatch;

        BufferedGraphicsContext currentContext;
        BufferedGraphics airspace;

        // Initialisation de l'espace a�rien avec un certain nombre de drones
        public AirSpace(List<Drone> fleet, List<Factory> factorys, List<Store> stores)
        {
            InitializeComponent();
            // Gets a reference to the current BufferedGraphicsContext
            currentContext = BufferedGraphicsManager.Current;
            // Creates a BufferedGraphics instance associated with this form, and with
            // dimensions the same size as the drawing surface of the form.
            airspace = currentContext.Allocate(this.CreateGraphics(), this.DisplayRectangle);
            this.fleet = fleet;
            this.factorys = factorys;
            this.stores = stores;

            if(fleet.Count > 10)
            {
                throw new Exception("Plus de 10 drones");
            }
        }


        // Affichage de la situation actuelle
        private void Render()
        {
            airspace.Graphics.Clear(Color.AliceBlue);

            // draw drones
            foreach (Drone drone in fleet)
            {
                drone.Render(airspace);
            }
            foreach (Factory factory in factorys)
            {
                factory.Render(airspace);
            }
            foreach(Store store in stores)
            {
                store.Render(airspace);
            }
            airspace.Render();
        }

        // Calcul du nouvel �tat apr�s que 'interval' millisecondes se sont �coul�es
        private void Update(int interval)
        {
            foreach (Drone drone in fleet)
            {
                drone.Update(interval);
            }
            foreach (Factory factory in factorys)
            {
                factory.Update(interval);
            }
        }

        // M�thode appel�e � chaque frame
        private void NewFrame(object sender, EventArgs e)
        {
            this.Update(ticker.Interval);
            this.Render();
        }
    }
}