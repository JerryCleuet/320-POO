using Drones.Helpers;
using System.DirectoryServices.ActiveDirectory;
using System.Security.Policy;

namespace Drones
{
    // Cette partie de la classe Drone définit ce qu'est un drone par un modèle numérique
    public partial class Drone : IExpellable
    {
        Random alea = new Random();

        private int _charge = 1000;                     // La charge actuelle de la batterie
        private string _name;                           // Un nom
        private int _x;                                // Position en X depuis la gauche de l'espace aérien
        private int _y;                                 // Position en Y depuis le haut de l'espace aérien
        private bool _LowBattery;
        private EvacuationState _EvacuationState;
        private Rectangle _NoflyZone;

        public int Charge { get; set; }
        public string Name { get; set; }
        public int X { get { return _x; } set { _x = value; } }
        public int Y { get { return _y; } set { _y = value; } }
        private bool LowBattery { get; set; }

        public Drone(int x, int y)
        {
            X = x;
            Y = y;
        }
        public bool Evacuate(Rectangle zone)
        {
            _NoflyZone = zone;
            Rectangle me = new Rectangle(X - 4, Y - 2, 8, 8);

            if (!zone.IntersectsWith(me))
            {
                _EvacuationState = EvacuationState.Evacuated;
                return true;
            }
            else
            {
                _EvacuationState = EvacuationState.Evacuating;
                return false;
            }
        }

        public void FreeFlight()
        {
            _EvacuationState = EvacuationState.Free;
            _NoflyZone = Rectangle.Empty;

        }

        public EvacuationState GetEvacuationState()
        {
            return _EvacuationState;

        }

        // Cette méthode calcule le nouvel état dans lequel le drone se trouve après
        // que 'interval' millisecondes se sont écoulées
        public void Update(int interval)
        {
            _x += 1;                                    // Il s'est déplacé de 2 pixels vers la droite
            _y = AleaValueHelper.AleaValue();                    // Il s'est déplacé d'une valeur aléatoire vers le haut ou le bas
            _charge--;                                  // Il a dépensé de l'énergie
        }

    }
}
