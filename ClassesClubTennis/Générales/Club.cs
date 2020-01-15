using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesClubTennis.Acteurs;

namespace ClassesClubTennis
{
    class Club
    {
        private string nom;
        private string diminutif;
        private Adresse adresse;
        private List<Membre> adherents;
        private List<Membre> personnel;
        private List<EntraineurIndependant> independants;
        private Dirigeant president;
        private Dirigeant secretaire;
        private Dirigeant tresorier;

        public Dirigeant President
        {
            get { return president; }
            set { president = value; }
        }

        public Dirigeant Secretaire
        {
            get { return secretaire; }
            set { secretaire = value; }
        }

        public Dirigeant Tresorier
        {
            get { return tresorier; }
            set { tresorier = value; }
        }

        public List<Membre> Adherents
        {
            get { return adherents; }
            set { adherents = value; }
        }

        public List<Membre> Personnel
        {
            get { return personnel; }
            set { personnel = value; }
        }

        public List<EntraineurIndependant> Independants
        {
            get { return independants; }
            set { independants = value; }
        }

        public string Nom
        {
            get { return nom; }
        }

        public string Diminutif
        {
            get { return diminutif; }
        }

        public Adresse Adresse
        {
            get { return adresse; }
        }

        public Club(string nom, string diminutif, Adresse adresse, Dirigeant president = null, Dirigeant secretaire = null, Dirigeant tresorier = null, List<Membre> adherents = null, 
            List<Membre> personnel = null, List<EntraineurIndependant> independants = null)
        {
            this.nom = nom;
            this.diminutif = diminutif;
            this.adresse = adresse;
            this.president = president;
            this.secretaire = secretaire;
            this.tresorier = tresorier;
            this.adherents = adherents;
            this.personnel = personnel;
            this.independants = independants;
        }

        public Club() // Club par défaut en exemple
        {
            this.nom = "Tennis Club de Courbevoie";
            this.diminutif = "TCC";
            this.adresse = new Adresse("8 rue Gervais", 92400, "Courbevoie");

            Membre Durand = new Membre("Durand", "Philippe", TypeSexe.Masculin, DateTime.Parse("25/04/1956"), "0636457841", new Adresse("8 Rue des Marchés", 92400, "Courbevoie"), TypeMembre.Adherent, false, Classement.ValClassement.NC);
            Membre Dupond = new Membre("Dupond", "Romain", TypeSexe.Masculin, DateTime.Parse("12/03/2000"), "0725745896", new Adresse("26 Chemin de Noisetier", 78000, "Versailles"), TypeMembre.Adherent, true, Classement.ValClassement.Trente_Deux);
            Membre Laforge = new Membre("Laforge", "Claudine", TypeSexe.Feminin, DateTime.Parse("12/05/1980"), "0641101025", new Adresse("12 Chemin de Tonnerre", 92400, "Courbevoie"), TypeMembre.Adherent, true, Classement.ValClassement.Quinze_Cinq);
            Membre Laforge2 = new Membre("Laforge", "Pierre", TypeSexe.Masculin, DateTime.Parse("15/10/1979"), "0625267889", new Adresse("12 Chemin de Tonnerre", 92400, "Courbevoie"), TypeMembre.Adherent, true, Classement.ValClassement.Quinze);
            Membre Laforge3 = new Membre("Laforge", "Marie", TypeSexe.Feminin, DateTime.Parse("17/02/2007"), "0745966352", new Adresse("12 Chemin de Tonnerre", 92400, "Courbevoie"), TypeMembre.Adherent, true, Classement.ValClassement.Trente_Cinq);
            Membre Laforge4 = new Membre("Laforge", "Paul", TypeSexe.Masculin, DateTime.Parse("20/03/2009"), "0721450014", new Adresse("12 Chemin de Tonnerre", 92400, "Courbevoie"), TypeMembre.Adherent, true, Classement.ValClassement.Trente_Cinq);
            Membre Fournier = new Membre("Fournier", "Sylvie", TypeSexe.Feminin, DateTime.Parse("17/02/1980"), "0725267889", new Adresse("1 Rue de Vermillon", 95100, "Argenteuil"), TypeMembre.Adherent, true, Classement.ValClassement.Quinze_Quatre);
            Membre Fournier2 = new Membre("Fournier", "Luc", TypeSexe.Masculin, DateTime.Parse("10/10/1978"), "0645751025", new Adresse("1 Rue de Vermillon", 95100, "Argenteuil"), TypeMembre.Adherent, true, Classement.ValClassement.Quinze);
            Membre Garcia = new Membre("Garcia", "Sophie", TypeSexe.Feminin, DateTime.Parse("18/06/1980"), "0645751025", new Adresse("49 Voie du Cyprès", 92400, "Courbevoie"), TypeMembre.Adherent, true, Classement.ValClassement.Trente_Deux);
            Membre Garcia2 = new Membre("Garcia", "Dominique", TypeSexe.Masculin, DateTime.Parse("11/11/1979"), "0628758452", new Adresse("49 Voie du Cyprès", 92400, "Courbevoie"), TypeMembre.Adherent, true, Classement.ValClassement.Quatre_Six);
            Membre Garcia3 = new Membre("Garcia", "Marie", TypeSexe.Feminin, DateTime.Parse("17/03/2008"), "0782641245", new Adresse("49 Voie du Cyprès", 92400, "Courbevoie"), TypeMembre.Adherent, true, Classement.ValClassement.NC);
            Membre Leroy = new Membre("Leroy", "Jean", TypeSexe.Masculin, DateTime.Parse("18/04/1978"), "0674851236", new Adresse("2 Rue des Fruitiers", 92000, "Nanterre"), TypeMembre.Adherent, true, Classement.ValClassement.Quatre_Six);
            Membre Leroy2 = new Membre("Leroy", "Julie", TypeSexe.Feminin, DateTime.Parse("16/08/1980"), "0649614325", new Adresse("2 Rue des Fruitiers", 92000, "Nanterre"), TypeMembre.Adherent, true, Classement.ValClassement.Quinze_Cinq);

            EntraineurIndependant Lemur = new EntraineurIndependant("Lemur", "Philippe", TypeSexe.Masculin, DateTime.Parse("25/04/1990"), 2);
            EntraineurIndependant Set = new EntraineurIndependant("Set", "Claudine", TypeSexe.Feminin, DateTime.Parse("12/05/1980"), 2);
            EntraineurIndependant Service = new EntraineurIndependant("Service", "Marie", TypeSexe.Feminin, DateTime.Parse("17/02/1995"), 2);

            Membre Ace = new EntraineurSalarie("Ace", "Romain", TypeSexe.Masculin, DateTime.Parse("25/04/1990"), "0782510896", new Adresse("3 Rue de l'Est", 92400, "Courbevoie"), true, 1500, DateTime.Parse("24/07/2019"), new InfoBancaire("FR7630001007941234567890185", "BDFEFRPPCCT"), Classement.ValClassement.Un_Six, 10);
            Membre Match = new EntraineurSalarie("Match", "Pierre", TypeSexe.Masculin, DateTime.Parse("15/10/1979"), "0685198348", new Adresse("16 Rue des Gemmes", 92400, "Courbevoie"), true, 1400, DateTime.Parse("10/11/2019"), new InfoBancaire("FR7630004000031234567890143", "BNPAFRPPXXX"), Classement.ValClassement.Quatre_Six, 10);
            Membre Double = new EntraineurSalarie("Double", "Paul", TypeSexe.Masculin, DateTime.Parse("20/03/2009"), "0786240780", new Adresse("1 Route de la Couronne", 92000, "Nanterre"), true, 1400, DateTime.Parse("07/12/2019"), new InfoBancaire("FR7630006000011234567890189", "AGRIFRPP"), Classement.ValClassement.Quatre_Six, 10);
            Membre President = new Dirigeant("Duhamel", "Laurent", TypeSexe.Masculin, DateTime.Parse("02/02/1970"), "0661468541", new Adresse("7 Boulevard des Pins", 92400, "Courbevoie"), TypeDirigeant.President, TypeMembre.Personnel, 2500, DateTime.Parse("22/01/2015"), new InfoBancaire("FR7610107001011234567890129", "BREDFRPPXXX"));
            Membre Secretaire = new Dirigeant("Desmoulins", "Clara", TypeSexe.Feminin, DateTime.Parse("18/04/1982"), "0645984101", new Adresse("19 Rue de la Place", 95100, "Argenteuil"), TypeDirigeant.Secretaire, TypeMembre.Personnel, 1900, DateTime.Parse("22/01/2015"), new InfoBancaire("FR7611315000011234567890138", "CEPAFRPP131"));
            Membre Tresorier = new Dirigeant("Duhamel", "Sandrine", TypeSexe.Feminin, DateTime.Parse("26/12/1970"), "0647896402", new Adresse("7 Boulevard des Pins", 92400, "Courbevoie"), TypeDirigeant.Tresorier, TypeMembre.Personnel, 1900, DateTime.Parse("22/01/2015"), new InfoBancaire("FR7610107001011234567890129", "BREDFRPPXXX"));


            List<Membre> adherents = new List<Membre> { Durand, Dupond, Laforge, Laforge2, Laforge3, Laforge4, Fournier, Fournier2, Garcia, Garcia2, Garcia3, Leroy, Leroy2 };
            List<Membre> personnel = new List<Membre> { Ace, Match, Double, President, Secretaire, Tresorier };
            List<EntraineurIndependant> independants = new List<EntraineurIndependant> { Lemur, Set, Service };

            this.adherents = adherents;
            this.personnel = personnel;
            this.independants = independants;
        }

        public override string ToString()
        {
            return Nom;
        }

        public void AjouterMembre(Membre membre)
        {
            if (membre.Type == TypeMembre.Adherent)
            {
                adherents.Add(membre);
            }
            else
            {
                personnel.Add(membre);
            }
        }

        public void EnleverMembre(Membre membre)
        {
            if (membre.Type == TypeMembre.Adherent)
            {
                adherents.Remove(membre);
            }
            else
            {
                personnel.Remove(membre);
            }
        }
    }
}
