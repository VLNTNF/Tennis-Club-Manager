using System;
using System.Collections.Generic;
using System.Text;

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

        public Adresse Adresse { get; set; }

        public string NumeroTelephone { get; set; }

        public void ModifierNumeroTelephone(string nouveauNumero)
        {
            throw new System.NotImplementedException();
        }

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

        public Membre(string nom, string prenom, TypeSexe sexe, DateTime dateNaissance, string numeroTelephone, Adresse adresse, TypeMembre type, bool estCompetiteur, Classement classement) : base(nom, prenom, sexe, dateNaissance)
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

        public Membre CreationMembre()
        {
            string nom = SaisieEntree("Nom: ");
            string prenom = SaisieEntree("Prénom: ");
            TypeSexe sexe = SaisieSexe("Sexe (H/M): ");
            DateTime dateNaissance = SaisieDate("Naissance JJ/MM/AAAA: ");
            string numeroTelephone = SaisieEntree("Téléphone: ");
            Adresse adresse = Adresse.SaisieAdresse();
            TypeMembre type = SaisieTypeMembre("Type (1: Adherent, 2: Personnel): ");
            (bool estCompetiteur, Classement classement) = Classement.SaisieCompetiteur();
            return new Membre(nom, prenom, sexe, dateNaissance, numeroTelephone, adresse, type, estCompetiteur, classement);
        }

        public TypeMembre SaisieTypeMembre(string entree)
        {
            string typeMembre;
            do
            {
                typeMembre = SaisieEntree(entree);
            } while ((typeMembre != "1") || (typeMembre != "2") || (typeMembre != "Adherent") || (typeMembre != "Personnel"));
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
