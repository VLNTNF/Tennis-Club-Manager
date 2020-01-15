using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesClubTennis.Evenements {
    class CompetitionSimple : Competition {
        public List<MatchSimple> ListeMatch { get; set; }

        public CompetitionSimple(string nom, DateTime date, TimeSpan duree, TypeCompetition typeCompetition, NiveauCompetition niveau, int nbJoueursMin, Classement classementMax,
            List<Equipe> listeEquipes = null, List<MatchSimple> listeMatch = null) : base(nom, date, duree, typeCompetition, niveau, nbJoueursMin, classementMax, listeEquipes) {
            if (listeMatch == null) {
                ListeMatch = new List<MatchSimple>();
            }
            else {
                ListeMatch = listeMatch;
            }
        }
    }
}
