using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesClubTennis.Evenements {
    public class Competition : IEvenement {
        public string Nom { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Duree { get; set; }
        public TypeCompetition TypeCompetition { get; set; }
        public NiveauCompetition Niveau { get; set; }
        public int NbJoueursMin { get; set; }
        public Classement ClassementMax { get; set; }
        public List<Equipe> ListeEquipes { get; set; }

        public Competition(string nom, DateTime date, TimeSpan duree, TypeCompetition typeCompetition, NiveauCompetition niveau, int nbJoueursMin, 
            Classement classementMax, List<Equipe> listeEquipes = null) {
            Nom = nom;
            Date = date;
            Duree = duree;
            TypeCompetition = typeCompetition;
            Niveau = niveau;
            NbJoueursMin = nbJoueursMin;
            ClassementMax = classementMax;
            if (listeEquipes == null) {
                ListeEquipes = new List<Equipe>();
            }
            else {
                ListeEquipes = listeEquipes;
            }
        }

        public void AjouterEquipe(Equipe nouvelleEquipe) {
            ListeEquipes.Add(nouvelleEquipe);
        }
    }

    public enum NiveauCompetition {
        Departemental,
        Regional,
        National
    }

    public enum TypeCompetition {
        Homme,
        Femme,
        Junior
    }
}
