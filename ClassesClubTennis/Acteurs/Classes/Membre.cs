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

        public Classement Classement { get; set; }

        public Adresse Adresse {
            get => default;
            set {
            }
        }

        public string NumeroTelephone {
            get => default;
            set {
            }
        }

        public void ModifierNumeroTelephone(string nouveauNumero) {
            throw new System.NotImplementedException();
        }
    }
}
