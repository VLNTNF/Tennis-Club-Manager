using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesClubTennis;
using ClassesClubTennis.Acteurs;

namespace ApplicationConsole {
    class Program {
        static void Main(string[] args) {
            List<ICompetiteur> liste = new List<ICompetiteur>();
            liste.Add(new EntraineurSalarie("Dupres", "Jean", new DateTime(1992, 12, 03), Sexe.Masculin, new Adresse("32 avenue Albert 1er", 92500, "Rueil-Malmaison"), "0154825896",
                new Classement(Classement.ValClassement.Quarante), 2, 2000, new DateTime(2019, 06, 12), new InfoBancaire("IBAN", "BIC")));
            liste[0].
        }
    }
}
