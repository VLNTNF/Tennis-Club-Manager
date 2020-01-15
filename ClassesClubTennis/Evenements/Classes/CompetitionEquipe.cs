using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesClubTennis.Evenements {
    class CompetitionEquipe : Competition {
        public List<Match> ListeMatch { get; set; }

        public CompetitionEquipe(string nom, DateTime date, TimeSpan duree, TypeCompetition typeCompetition, NiveauCompetition niveau, int nbJoueursMin, Classement classementMax,
            List<Equipe> listeEquipes = null, List<Match> listeMatch = null) : base(nom, date, duree, typeCompetition, niveau, nbJoueursMin, classementMax, listeEquipes) {
            if (listeMatch == null) {
                ListeMatch = new List<Match>();
            }
            else {
                ListeMatch = listeMatch;
            }
        }
    }
}
