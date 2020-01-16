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
            DateTime dateEntreeClub, InfoBancaire informationsBancaires, Classement classement, int nombreDeCoursAEffectuer = 0, TypeMembre type = TypeMembre.Personnel)
            : base(nom, prenom, sexe, dateNaissance, numeroTelephone, adresse, type, estCompetiteur, classement)
        {
            Salaire = salaire;
            DateEntreeClub = dateEntreeClub;
            InformationsBancaires = informationsBancaires;
            NombreDeCoursAEffectuer = nombreDeCoursAEffectuer;
        }
    }
}
