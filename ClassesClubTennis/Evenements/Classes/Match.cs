using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesClubTennis.Evenements {
    public class Match {
        public EtatMatch Etat { get; set; }

        public Match() {
            Etat = EtatMatch.NonJoue;
        }
    }

    public enum EtatMatch {
        Annule = -2,
        Perdu = -1,
        NonJoue = 0,
        Gagne = 1,
        EnCours = 2
    }
}
