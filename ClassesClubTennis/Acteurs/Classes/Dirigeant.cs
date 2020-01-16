using System;

namespace ClassesClubTennis.Acteurs
{
    public enum TypeDirigeant
    { President, Secretaire, Tresorier }

    public class Dirigeant : Membre, ISalarie
    {
        public TypeDirigeant TypeDirigeant { get; set; }
        public double Salaire { get; set; }
        public DateTime DateEntreeClub { get; set; }
        public InfoBancaire InformationsBancaires { get; set; }

        public Dirigeant(string nom, string prenom, TypeSexe sexe, DateTime dateNaissance, string numeroTelephone, Adresse adresse, TypeDirigeant typeDirigeant, TypeMembre typeMembre, double salaire, DateTime dateEntreeClub, InfoBancaire informationsBancaires, bool estCompetiteur = false, Classement classement = null) 
            : base(nom, prenom, sexe, dateNaissance, numeroTelephone, adresse, typeMembre, estCompetiteur, classement)
        {
            this.TypeDirigeant = typeDirigeant;
            this.Salaire = salaire;
            this.DateEntreeClub = dateEntreeClub;
            this.InformationsBancaires = informationsBancaires;
        }
    }
}
