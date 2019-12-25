using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesClubTennis.Acteurs {
    sealed class Adversaire : Personne, ICompetiteur {
        public int Classement { get; set; }
    }
}
