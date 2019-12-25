using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesClubTennis.Acteurs {
    internal abstract class Personne {
        public string Nom {
            get => default;
            set {
            }
        }

        public string Prenom {
            get => default;
            set {
            }
        }

        public System.DateTime DateNaissance {
            get => default;
            set {
            }
        }

        public Sexe Sexe {
            get => default;
            set {
            }
        }

        public int Age {
            get => default;
            set {
            }
        }
    }

    enum Sexe {
        Masculin = 0,
        Feminin = 1
    }
}