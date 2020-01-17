using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesClubTennis.Acteurs
{
    public sealed class EntraineurSalarie : Membre, IEntraineur, ISalarie, ICompetiteur
    {
        public double Salaire { get; set; }
        public DateTime DateEntreeClub { get; set; }
        public InfoBancaire InformationsBancaires { get; set; }
        public int NombreDeCoursAEffectuer { get; set; }

        public EntraineurSalarie(string nom, string prenom, TypeSexe sexe, DateTime dateNaissance, string numeroTelephone, Adresse adresse, bool estCompetiteur, double salaire,
            DateTime dateEntreeClub, InfoBancaire informationsBancaires, Classement classement = default, int nombreDeCoursAEffectuer = 0, TypeMembre type = TypeMembre.Personnel)
            : base(nom, prenom, sexe, dateNaissance, numeroTelephone, adresse, type, estCompetiteur, classement)
        {
            Salaire = salaire;
            DateEntreeClub = dateEntreeClub;
            InformationsBancaires = informationsBancaires;
            NombreDeCoursAEffectuer = nombreDeCoursAEffectuer;
        }

        public new void Afficher()
        {
            Console.WriteLine("Type: entraineur salarie");
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
            Console.WriteLine("Salaire: " + Salaire);
            Console.WriteLine("Date entrée club: " + DateEntreeClub);
            Console.WriteLine("Nombre de cours: " + NombreDeCoursAEffectuer);
        }

        public new static EntraineurSalarie Creation()
        {
            string nom = SaisieEntree("Nom: ");
            string prenom = SaisieEntree("Prénom: ");
            TypeSexe sexe = SaisieSexe("Sexe (H/M): ");
            DateTime dateNaissance = SaisieDate("Naissance JJ/MM/AAAA: ");
            string numeroTelephone = SaisieEntree("Téléphone: ");
            Adresse adresse = Adresse.SaisieAdresse();
            TypeMembre type = TypeMembre.Personnel;
            (bool estCompetiteur, Classement classement) = Classement.SaisieCompetiteur();
            int salaire = SaisiePositive("Salaire: ");
            DateTime dateEntree = DateTime.Now.Date;
            InfoBancaire infoBancaires = SaisieInfoBancaires();
            int nbCours = SaisiePositive("Nombre de cours: ");
            return new EntraineurSalarie(nom, prenom, sexe, dateNaissance, numeroTelephone, adresse, estCompetiteur, salaire, dateEntree, infoBancaires,classement, nbCours);
        }

        public static InfoBancaire SaisieInfoBancaires()
        {
            string iban = SaisieEntree("IBAN: ");
            string bic = SaisieEntree("BIC: ");
            return new InfoBancaire(iban, bic);
        }
    }
}
