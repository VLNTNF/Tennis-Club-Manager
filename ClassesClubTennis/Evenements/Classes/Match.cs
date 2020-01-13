using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesClubTennis.Evenements {
    class Match {
        public EtatMatch Etat {
            get => default;
            set {
            }
        }
    }

    enum EtatMatch {
        NonJoue,
        EnCours,
        Gagne,
        Perdu,
        Annule
    }
}
