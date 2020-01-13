using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesClubTennis.Acteurs;

namespace ClassesClubTennis.Evenements {
    class MatchDouble : Match {
        public List<Membre> MembresClub { get; set; }
        public List<Adversaire> Adversaires { get; set; }

        public MatchDouble(List<Membre> membresClub, List<Adversaire> adversaires) : base() {
            MembresClub = membresClub;
            Adversaires = adversaires;
        }
    }
}
