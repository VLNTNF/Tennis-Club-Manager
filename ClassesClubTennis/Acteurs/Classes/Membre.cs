using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesClubTennis.Acteurs
{
    enum TypeMembre
    {
        Personnel, Adherent
    }

    class Membre : Personne, ICompetiteur
    {
        public TypeMembre Type
        {
            get => default;
            set
            {
            }
        }

        public int Cotisation
        {
            get { return MontantCotisation(); }
        }

        public bool ARegleCotisation
        {
            get => default;
            set
            {
            }
        }

        public bool EstCompetiteur
        {
            get => default;
            set
            {
            }
        }

        public Classement.ValClassement Classement { get; set; }

        public Adresse Adresse
        {
            get => default;
            set
            {
            }
        }

        public string NumeroTelephone
        {
            get => default;
            set
            {
            }
        }

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

        public Membre(string nom, string prenom, TypeSexe sexe, DateTime dateNaissance, string numeroTelephone, Adresse adresse, TypeMembre type, bool estCompetiteur, Classement.ValClassement classement) : base(nom, prenom, sexe, dateNaissance)
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
            Adresse adresse =
            TypeMembre type = SaisieTypeMembre("Type (1: Adherent, 2: Personnel): ");

        }

        public string SaisieEntree(string entree)
        {
            string res;
            do
            {
                Console.Write(entree);
                res = Console.ReadLine();
            } while ((res == "") || (res == " "));
            return res;
        }

        public TypeSexe SaisieSexe(string entree)
        {
            string typeSexe;
            do
            {
                typeSexe = SaisieEntree(entree);
            } while ((typeSexe != "H") || (typeSexe != "h") || (typeSexe != "F") || (typeSexe != "f");
            if ((typeSexe== "H") || (typeSexe == "h"))
            {
                return TypeSexe.Masculin;
            }
            else
            {
                return TypeSexe.Feminin;
            }
        }

        public DateTime SaisieDate(string entree)
        {
            DateTime res;
            string saisie;
            bool test;
            do
            {
                Console.Write(entree);
                saisie = Console.ReadLine();
                test = DateTime.TryParse(saisie, out res);
            } while (test == false);
            return res;
        }

        public Adresse SaisieAdresse( )
        {

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

        public (bool, Classement.ValClassement) SaisieCompetiteur()
        {
            bool comp = false;
            Classement.ValClassement classement;
            string entree;

            do
            {
                entree = SaisieEntree("Compétiteur (oui/non): ");
            } while ((entree != "oui") || (entree != "non"));
            if (entree != "oui")
            {
                comp = true;
            }


        }

    }
}
