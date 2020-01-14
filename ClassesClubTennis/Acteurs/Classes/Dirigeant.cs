using System;

namespace ClassesClubTennis.Acteurs
{
    enum TypeDirigeant
    { President, Adjoint, Secretaire, Tresorier }

    abstract class Dirigeant : Personne, ISalarie
    {
        public TypeDirigeant Type { get; set; }
        public double Salaire { get; set; }
        public DateTime DateEntreeClub { get; set; }
        public InfoBancaire InformationsBancaires { get; set; }

        public Dirigeant(string nom, string prenom, TypeSexe sexe, DateTime dateNaissance, TypeDirigeant type, double salaire, DateTime dateEntreeClub, InfoBancaire informationsBancaires) : base(nom, prenom, sexe, dateNaissance)
        {
            this.Type = type;
            this.Salaire = salaire;
            this.DateEntreeClub = dateEntreeClub;
            this.InformationsBancaires = informationsBancaires;
        }
    }
}
