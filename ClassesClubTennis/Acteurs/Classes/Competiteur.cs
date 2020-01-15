using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesClubTennis.Acteurs {
    public class Competiteur: Membre, ICompetiteur {
        public Classement Classement { get; set; }
        public override int Cotisation { 
            get {
                return base.Cotisation + 20;
            } 
        }

        public Competiteur(string nom, string prenom, DateTime dateNaissance, Sexe sexe, Adresse adresse, string numeroTelephone, Classement classement)
            : base(nom, prenom, dateNaissance, sexe, adresse, numeroTelephone) {
            Classement = classement;
        }

        internal Competiteur(Membre membre, Classement classement) {
            Nom = membre.Nom;
            Prenom = membre.Prenom;
            DateNaissance = membre.DateNaissance;
            Sexe = membre.Sexe;
            Adresse = membre.Adresse;
            NumeroTelephone = membre.NumeroTelephone;

            Classement = classement;
        }

        public int CompareTo(ICompetiteur other) {
            throw new NotImplementedException();
        }
    }
}
