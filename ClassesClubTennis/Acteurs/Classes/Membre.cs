using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesClubTennis.Acteurs {
    public class Membre : Personne, ICompetiteur {
        public int Cotisation {
            get => default;
            set {
            }
        }

        public bool ARegleCotisation {
            get => default;
            set {
            }
        }

        public bool EstCompetiteur {
            get => default;
            set {
            }
        }
    }
}
