using System;
using System.Collections.Generic;
using System.Text;
using ClassesClubTennis;

namespace ClassesClubTennis.Acteurs
{
    public enum TypeMembre
    {
        Personnel, Adherent
    }

    public class Membre : Personne, ICompetiteur
    {
        public TypeMembre Type { get; set; }

        public int Cotisation
        {
            get { return MontantCotisation(); }
        }

        public bool ARegleCotisation { get; set; }

        public bool EstCompetiteur { get; set; }

        public Classement Classement { get; set; }

        public int MontantCotisation()
        {
            int res = 0;
            if (Adresse.CodePostal == 92400)
            {
                if (Enfant) { res += 130; }
                else { res += 200; }
            }
            else
            {
                if (Enfant) { res += 180; }
                else { res += 280; }
            }
            if (EstCompetiteur)
            {
                res += 20;
            }
            return res;
        }

        public Membre(string nom, string prenom, TypeSexe sexe, DateTime dateNaissance, string numeroTelephone, Adresse adresse, TypeMembre type, bool estCompetiteur, Classement classement = default) : base(nom, prenom, sexe, dateNaissance, numeroTelephone, adresse)
        {
            EstCompetiteur = estCompetiteur;
            ARegleCotisation = false;
            NumeroTelephone = numeroTelephone;
            Adresse = adresse;
            Type = type;
            Classement = classement;
        }

        public int CompareTo(ICompetiteur competiteur)
        {
            return Classement.CompareTo(competiteur.Classement);
        }

        public void Afficher()
        {
            Console.WriteLine("Type: " + Type);
            Console.WriteLine("Nom: " + Nom);
            Console.WriteLine("Prénom: " + Prenom);
            Console.WriteLine("Sexe: " + Sexe);
            Console.WriteLine("Naissance: " + DateNaissance);
            Console.WriteLine("Téléphone: " + NumeroTelephone);
            Console.WriteLine("Adresse: " + Adresse);
            Console.WriteLine("Compétiteur: " + EstCompetiteur);
            if (EstCompetiteur)
            {
                Console.WriteLine("Classement: " + Classement.Nom);
            }
        }

        public static Membre Creation()
        {
            string nom = SaisieEntree("Nom: ");
            string prenom = SaisieEntree("Prénom: ");
            TypeSexe sexe = SaisieSexe("Sexe (H/M): ");
            DateTime dateNaissance = SaisieDate("Naissance JJ/MM/AAAA: ");
            string numeroTelephone = SaisieEntree("Téléphone: ");
            Adresse adresse = Adresse.SaisieAdresse();
            TypeMembre type = TypeMembre.Adherent;
            (bool estCompetiteur, Classement classement) = Classement.SaisieCompetiteur();
            return new Membre(nom, prenom, sexe, dateNaissance, numeroTelephone, adresse, type, estCompetiteur, classement);
        }

        public static TypeMembre SaisieTypeMembre()
        {
            string typeMembre;
            do
            {
                typeMembre = SaisieEntree("Type (1: Adherent, 2: Entraineur): ");
            } while ((typeMembre != "1") && (typeMembre != "2") && (typeMembre != "Adherent") && (typeMembre != "Entraineur"));
            if ((typeMembre == "1") || (typeMembre == "Adherent"))
            {
                return TypeMembre.Adherent;
            }
            else
            {
                return TypeMembre.Personnel;
            }
        }
    }
}
