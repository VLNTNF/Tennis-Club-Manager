using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesClubTennis.Acteurs {
    class Membre : Personne, ICompetiteur {
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

        public int Classement { get; set; }
    }
}
