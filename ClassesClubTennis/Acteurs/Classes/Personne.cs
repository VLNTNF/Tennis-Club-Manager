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

    public class Personne : Utility
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

        public Adresse Adresse { get; set; }

        public string NumeroTelephone { get; set; }

        public void ModifierNumeroTelephone(string nouveauNumero)
        {
            NumeroTelephone = SaisieEntree("Téléphone: ");
        }

        public Personne() { }

        public Personne(string nom, string prenom, TypeSexe sexe, DateTime dateNaissance, string numeroTelephone, Adresse adresse)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Sexe = sexe;
            this.DateNaissance = dateNaissance;
            this.NumeroTelephone = numeroTelephone;
            this.Adresse = adresse;
        }

        public override string ToString()
        {
            return Prenom + " " + Nom;
        }

        public static TypeSexe SaisieSexe(string entree)
        {
            string typeSexe;
            do
            {
                typeSexe = SaisieEntree(entree);
            } while ((typeSexe != "H") && (typeSexe != "h") && (typeSexe != "F") && (typeSexe != "f"));
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