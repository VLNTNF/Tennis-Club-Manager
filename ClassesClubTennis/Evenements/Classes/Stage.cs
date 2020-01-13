using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesClubTennis.Acteurs;

namespace ClassesClubTennis.Evenements {
    public class Stage : IEvenement {
        public string Nom { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Duree { get; set; }
        public int Age { get; set; }
        public List<IEntraineur> Entraineurs { get; set; }
        public Classement Classement { get; set; }
        public List<Membre> ListeParticipants { get; set; }

        public Stage(string nom, DateTime date, TimeSpan duree, int age, List<IEntraineur> entraineurs, Classement classement, List<Membre> listeParticipants) {
            Nom = nom;
            Date = date;
            Duree = duree;
            Age = age;
            Entraineurs = entraineurs;
            Classement = classement;
            ListeParticipants = listeParticipants;
        }
    }
}
