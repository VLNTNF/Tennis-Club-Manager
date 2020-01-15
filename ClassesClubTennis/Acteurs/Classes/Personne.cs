using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesClubTennis.Acteurs
{
    enum TypeSexe
    {
        Masculin = 0,
        Feminin = 1
    }

    internal abstract class Personne : Utility
    {
        public string Nom { get; set; }

        public string Prenom { get; set; }

        public System.DateTime DateNaissance { get; set; }

        public TypeSexe Sexe { get; set; }

        public int Age { get; set; }

        public bool Enfant
        {
            get { return TestEnfant(DateNaissance); }
        }

        public bool TestEnfant(DateTime DateNaissance)
        {
            var today = DateTime.Today;
            var age = today.Year - DateNaissance.Year;
            if (DateNaissance.Date > today.AddYears(-age)) age--;
            return age < 18;
        }

        public Personne(string nom, string prenom, TypeSexe sexe, DateTime dateNaissance)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Sexe = sexe;
            this.DateNaissance = dateNaissance;
        }

        public override string ToString()
        {
            return Prenom + " " + Nom;
        }

        public TypeSexe SaisieSexe(string entree)
        {
            string typeSexe;
            do
            {
                typeSexe = SaisieEntree(entree);
            } while ((typeSexe != "H") || (typeSexe != "h") || (typeSexe != "F") || (typeSexe != "f"));
            if ((typeSexe == "H") || (typeSexe == "h"))
            {
                return TypeSexe.Masculin;
            }
            else
            {
                return TypeSexe.Feminin;
            }
        }
    }
}