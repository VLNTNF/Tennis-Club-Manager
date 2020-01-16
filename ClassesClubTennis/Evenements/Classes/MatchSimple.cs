using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesClubTennis.Acteurs;

namespace ClassesClubTennis.Evenements {
    public class MatchSimple : Match {
        public Membre MembreClub {
            get => default;
            set {
            }
        }

        public Adversaire Adversaire {
            get => default;
            set {
            }
        }
    }
}
