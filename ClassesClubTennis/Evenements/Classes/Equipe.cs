using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesClubTennis.Acteurs;

namespace ClassesClubTennis.Evenements {
    public class Equipe {
        public Competition Competition { get; set; }
        public Membre Capitaine { get; set; }
        public List<Membre> MembresEquipe { get; set; }
        public List<Match> ListeMatch { get; set; }

        public Equipe(Competition competition, Membre capitaine, List<Membre> membresEquipe, List<Match> listeMatch) {
            Competition = competition;
            Capitaine = capitaine;
            MembresEquipe = membresEquipe;
            ListeMatch = listeMatch;
        }
    }
}
