using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesClubTennis.Acteurs
{
    public enum TypeSexe
    {
        Masculin = 0,
        Feminin = 1
    }

    internal abstract class Personne
    {
        public string Nom
        {
            get => default;
            set
            {
            }
        }

        public string Prenom
        {
            get => default;
            set
            {
            }
        }

        public System.DateTime DateNaissance
        {
            get => default;
            set
            {
            }
        }

        public TypeSexe Sexe
        {
            get => default;
            set
            {
            }
        }

        public int Age
        {
            get => default;
            set
            {
            }
        }

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
    }
}