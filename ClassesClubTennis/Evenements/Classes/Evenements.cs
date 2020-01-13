using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesClubTennis.Acteurs;

namespace ClassesClubTennis.Evenements {
    class Evenements : IEvenement {
        public string Nom { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Duree { get; set; }
        public List<IEntraineur> Organisateurs { get; set; }

        public Evenements(string nom, DateTime date, TimeSpan duree, List<IEntraineur> organisateurs) {
            Nom = nom;
            Date = date;
            Duree = duree;
            Organisateurs = organisateurs;
        }
    }
}
