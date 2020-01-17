using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesClubTennis.Acteurs;

namespace ClassesClubTennis
{
    public class Club : Utility
    {
        private string nom;
        private string diminutif;
        private Adresse adresse;
        private List<Personne> adherents;
        private List<Personne> personnel;
        private List<Personne> independants;
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

        public List<Personne> Adherents
        {
            get { return adherents; }
            set { adherents = value; }
        }

        public List<Personne> Personnel
        {
            get { return personnel; }
            set { personnel = value; }
        }

        public List<Personne> Independants
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

        public Club(string nom, string diminutif, Adresse adresse, Dirigeant president = null, Dirigeant secretaire = null, Dirigeant tresorier = null, List<Personne> adherents = null,
            List<Personne> personnel = null, List<Personne> independants = null)
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

            Membre Durand = new Membre("Durand", "Philippe", TypeSexe.Masculin, DateTime.Parse("25/04/1956"), "0636457841", new Adresse("8 Rue des Marchés", 92400, "Courbevoie"), TypeMembre.Adherent, false, new Classement(Classement.ValClassement.NC));
            Membre Dupond = new Membre("Dupond", "Romain", TypeSexe.Masculin, DateTime.Parse("12/03/2000"), "0725745896", new Adresse("26 Chemin de Noisetier", 78000, "Versailles"), TypeMembre.Adherent, true, new Classement(Classement.ValClassement.Trente_Deux));
            Membre Laforge = new Membre("Laforge", "Claudine", TypeSexe.Feminin, DateTime.Parse("12/05/1980"), "0641101025", new Adresse("12 Chemin de Tonnerre", 92400, "Courbevoie"), TypeMembre.Adherent, true, new Classement(Classement.ValClassement.Quinze_Cinq));
            Membre Laforge2 = new Membre("Laforge", "Pierre", TypeSexe.Masculin, DateTime.Parse("15/10/1979"), "0625267889", new Adresse("12 Chemin de Tonnerre", 92400, "Courbevoie"), TypeMembre.Adherent, true, new Classement(Classement.ValClassement.Quinze));
            Membre Laforge3 = new Membre("Laforge", "Marie", TypeSexe.Feminin, DateTime.Parse("17/02/2007"), "0745966352", new Adresse("12 Chemin de Tonnerre", 92400, "Courbevoie"), TypeMembre.Adherent, false, new Classement(Classement.ValClassement.Trente_Cinq));
            Membre Laforge4 = new Membre("Laforge", "Paul", TypeSexe.Masculin, DateTime.Parse("20/03/2009"), "0721450014", new Adresse("12 Chemin de Tonnerre", 92400, "Courbevoie"), TypeMembre.Adherent, false, new Classement(Classement.ValClassement.Trente_Cinq));
            Membre Fournier = new Membre("Fournier", "Sylvie", TypeSexe.Feminin, DateTime.Parse("17/02/1980"), "0725267889", new Adresse("1 Rue de Vermillon", 95100, "Argenteuil"), TypeMembre.Adherent, true, new Classement(Classement.ValClassement.Quinze_Quatre));
            Membre Fournier2 = new Membre("Fournier", "Luc", TypeSexe.Masculin, DateTime.Parse("10/10/1978"), "0645751025", new Adresse("1 Rue de Vermillon", 95100, "Argenteuil"), TypeMembre.Adherent, true, new Classement(Classement.ValClassement.Quinze));
            Membre Garcia = new Membre("Garcia", "Sophie", TypeSexe.Feminin, DateTime.Parse("18/06/1980"), "0645751025", new Adresse("49 Voie du Cyprès", 92400, "Courbevoie"), TypeMembre.Adherent, true, new Classement(Classement.ValClassement.Trente_Deux));
            Membre Garcia2 = new Membre("Garcia", "Dominique", TypeSexe.Masculin, DateTime.Parse("11/11/1979"), "0628758452", new Adresse("49 Voie du Cyprès", 92400, "Courbevoie"), TypeMembre.Adherent, false, new Classement(Classement.ValClassement.Quatre_Six));
            Membre Garcia3 = new Membre("Garcia", "Marie", TypeSexe.Feminin, DateTime.Parse("17/03/2008"), "0782641245", new Adresse("49 Voie du Cyprès", 92400, "Courbevoie"), TypeMembre.Adherent, true, new Classement(Classement.ValClassement.NC));
            Membre Leroy = new Membre("Leroy", "Jean", TypeSexe.Masculin, DateTime.Parse("18/04/1978"), "0674851236", new Adresse("2 Rue des Fruitiers", 92000, "Nanterre"), TypeMembre.Adherent, true, new Classement(Classement.ValClassement.Quatre_Six));
            Membre Leroy2 = new Membre("Leroy", "Julie", TypeSexe.Feminin, DateTime.Parse("16/08/1980"), "0649614325", new Adresse("2 Rue des Fruitiers", 92000, "Nanterre"), TypeMembre.Adherent, true, new Classement(Classement.ValClassement.Quinze_Cinq));

            EntraineurIndependant Lemur = new EntraineurIndependant("Lemur", "Philippe", TypeSexe.Masculin, DateTime.Parse("25/04/1990"), "0788945844", new Adresse("3 Rue du Roi", 92400, "Courbevoie"), 2);
            EntraineurIndependant Set = new EntraineurIndependant("Set", "Claudine", TypeSexe.Feminin, DateTime.Parse("12/05/1980"), "0644102578", new Adresse("3 Voie des Près", 92000, "Nanterre"), 2);
            EntraineurIndependant Service = new EntraineurIndependant("Service", "Marie", TypeSexe.Feminin, DateTime.Parse("17/02/1995"), "0600124774", new Adresse("3 Boulevard des Belges", 92000, "Nanterre"), 2);

            EntraineurSalarie Ace = new EntraineurSalarie("Ace", "Romain", TypeSexe.Masculin, DateTime.Parse("25/04/1990"), "0782510896", new Adresse("3 Rue de l'Est", 92400, "Courbevoie"), true, 1500, DateTime.Parse("24/07/2019"), new InfoBancaire("FR7630001007941234567890185", "BDFEFRPPCCT"), new Classement(Classement.ValClassement.Un_Six), 10);
            EntraineurSalarie Match = new EntraineurSalarie("Match", "Pierre", TypeSexe.Masculin, DateTime.Parse("15/10/1979"), "0685198348", new Adresse("16 Rue des Gemmes", 92400, "Courbevoie"), true, 1400, DateTime.Parse("10/11/2019"), new InfoBancaire("FR7630004000031234567890143", "BNPAFRPPXXX"), new Classement(Classement.ValClassement.Quatre_Six), 10);
            EntraineurSalarie Double = new EntraineurSalarie("Double", "Paul", TypeSexe.Masculin, DateTime.Parse("20/03/2009"), "0786240780", new Adresse("1 Route de la Couronne", 92000, "Nanterre"), true, 1400, DateTime.Parse("07/12/2019"), new InfoBancaire("FR7630006000011234567890189", "AGRIFRPP"), new Classement(Classement.ValClassement.Quatre_Six), 10);
            Dirigeant President = new Dirigeant("Duhamel", "Laurent", TypeSexe.Masculin, DateTime.Parse("02/02/1970"), "0661468541", new Adresse("7 Boulevard des Pins", 92400, "Courbevoie"), TypeDirigeant.President, TypeMembre.Personnel, 2500, DateTime.Parse("22/01/2015"), new InfoBancaire("FR7610107001011234567890129", "BREDFRPPXXX"));
            Dirigeant Secretaire = new Dirigeant("Desmoulins", "Clara", TypeSexe.Feminin, DateTime.Parse("18/04/1982"), "0645984101", new Adresse("19 Rue de la Place", 95100, "Argenteuil"), TypeDirigeant.Secretaire, TypeMembre.Personnel, 1900, DateTime.Parse("22/01/2015"), new InfoBancaire("FR7611315000011234567890138", "CEPAFRPP131"));
            Dirigeant Tresorier = new Dirigeant("Duhamel", "Sandrine", TypeSexe.Feminin, DateTime.Parse("26/12/1970"), "0647896402", new Adresse("7 Boulevard des Pins", 92400, "Courbevoie"), TypeDirigeant.Tresorier, TypeMembre.Personnel, 1900, DateTime.Parse("22/01/2015"), new InfoBancaire("FR7610107001011234567890129", "BREDFRPPXXX"));


            List<Personne> adherents = new List<Personne> { Durand, Dupond, Laforge, Laforge2, Laforge3, Laforge4, Fournier, Fournier2, Garcia, Garcia2, Garcia3, Leroy, Leroy2 };
            List<Personne> personnel = new List<Personne> { President, Secretaire, Tresorier, Ace, Match, Double };
            List<Personne> independants = new List<Personne> { Lemur, Set, Service };

            this.president = President;
            this.secretaire = Secretaire;
            this.tresorier = Tresorier;
            this.adherents = adherents;
            this.personnel = personnel;
            this.independants = independants;
        }

        public override string ToString()
        {
            return Nom;
        }

        public void AfficherInfoPersonne()
        {
            Personne personne = SelectionnerPersonne();
            Type type = personne.GetType();

            if (type == typeof(Membre))
            {
                Membre membre = (Membre)personne;
                if (membre.Type == TypeMembre.Adherent)
                {
                    membre.Afficher();
                }
                else
                {
                    if (type == typeof(Dirigeant))
                    {
                        Dirigeant dirigeant = (Dirigeant)membre;
                        dirigeant.Afficher();
                    }
                    else if (type == typeof(EntraineurSalarie))
                    {
                        EntraineurSalarie entraineurSalarie = (EntraineurSalarie)membre;
                        entraineurSalarie.Afficher();
                    }
                }
            }
            else if (type == typeof(Dirigeant))
            {
                Dirigeant dirigeant = (Dirigeant)personne;
                dirigeant.Afficher();
            }
            else if (type == typeof(EntraineurSalarie))
            {
                EntraineurSalarie entraineurSalarie = (EntraineurSalarie)personne;
                entraineurSalarie.Afficher();
            }
            else if (type == typeof(EntraineurIndependant))
            {
                EntraineurIndependant entraineurIndependant = (EntraineurIndependant)personne;
                entraineurIndependant.Afficher();
            }
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

        public void AjouterIndependant(EntraineurIndependant inde)
        {
            independants.Add(inde);
        }

        public void EnleverIndependant(EntraineurIndependant inde)
        {
            independants.Remove(inde);
        }

        public void AfficherPersonnes()
        {
            int c = 0;
            Console.WriteLine("Adhérents:");
            List<Personne> list1 = Adherents;
            foreach (Membre m in list1)
            {
                string s = c + " " + m.ToString();
                if (m.EstCompetiteur)
                {
                    s += " : compétiteur";
                }
                Console.WriteLine(s);
                c++;
            }
            Console.WriteLine();
            Console.WriteLine("Personnel:");
            List<Personne> list2 = Personnel;
            foreach (Membre m in list2)
            {
                string s = c + " " + m.ToString();
                s += " : ";
                if (m.GetType() == typeof(Dirigeant))
                {
                    Dirigeant d = (Dirigeant)m;
                    if (d.TypeDirigeant == TypeDirigeant.President)
                    {
                        s += "président";
                    }
                    else if ((d.TypeDirigeant == TypeDirigeant.Secretaire))
                    {
                        s += "secrétaire";
                    }
                    else if ((d.TypeDirigeant == TypeDirigeant.Tresorier))
                    {
                        s += "trésorier";
                    }
                }
                else
                {
                    s += "entraineur salarié";
                }
                Console.WriteLine(s);
                c++;
            }
            Console.WriteLine();
            Console.WriteLine("Indépendants:");
            foreach (EntraineurIndependant e in Independants)
            {
                Console.WriteLine(c + " " + e + " : entraineur indépendant");
                c++;
            }
        }

        public void AfficherMembres()
        {
            int c = 0;
            Console.WriteLine("Membres:");
            Console.WriteLine("- adhérents:");
            List<Personne> list1 = Adherents;
            foreach (Membre m in list1)
            {
                string s = c + " " + m.ToString();
                if (m.EstCompetiteur)
                {
                    s += " : compétiteur";
                }
                Console.WriteLine(s);
                c++;
            }
            Console.WriteLine();
            Console.WriteLine("- personnel:");
            List<Personne> list2 = Personnel;
            foreach (Membre m in list2)
            {
                string s = c + " " + m.ToString();
                s += " : ";
                if (m.GetType() == typeof(Dirigeant))
                {
                    Dirigeant d = (Dirigeant)m;
                    if (d.TypeDirigeant == TypeDirigeant.President)
                    {
                        s += "président";
                    }
                    else if ((d.TypeDirigeant == TypeDirigeant.Secretaire))
                    {
                        s += "secrétaire";
                    }
                    else if ((d.TypeDirigeant == TypeDirigeant.Tresorier))
                    {
                        s += "trésorier";
                    }
                }
                else
                {
                    s += "entraineur salarié";
                }
                Console.WriteLine(s);
                c++;
            }
        }

        public void AfficherIndependants()
        {
            int c = 0;
            Console.WriteLine("Indépendants:");
            foreach (EntraineurIndependant e in Independants)
            {
                Console.WriteLine(c + " " + e + " : entraineur indépendant");
                c++;
            }
        }

        public Personne SelectionnerPersonne()
        {
            AfficherPersonnes();
            Console.WriteLine();
            int x = SaisiePositive("Numéro: ");
            Personne p = new Personne();
            if (x < Adherents.Count)
            {
                p = Adherents[x];
            }
            else if (x < Adherents.Count + Personnel.Count)
            {
                p = Personnel[x - Adherents.Count];
            }
            else if (x < Adherents.Count + Personnel.Count + Independants.Count)
            {
                p = Independants[x - Adherents.Count - Personnel.Count];
            }
            else
            {
                p = Independants.Last();
            }
            return p;
        }

        public Personne SelectionnerMembre()
        {
            AfficherMembres();
            Console.WriteLine();
            int x = SaisiePositive("Numéro: ");
            Personne p = new Personne();
            if (x < Adherents.Count)
            {
                p = Adherents[x];
            }
            else if (x < Adherents.Count + Personnel.Count)
            {
                p = Personnel[x - Adherents.Count];
            }
            else
            {
                p = Personnel.Last();
            }
            return p;
        }

        public Personne SelectionnerIndependant()
        {
            AfficherIndependants();
            Console.WriteLine();
            int x = SaisiePositive("Numéro: ");
            Personne p = new Personne();
            if (x < Independants.Count)
            {
                p = Independants[x];
            }
            else
            {
                p = Independants.Last();
            }
            return p;
        }

        public void AfficherCotisations()
        {
            List<Personne> list = Adherents;
            foreach (Membre m in list)
            {
                string s = m.ToString() + " : " + m.Cotisation;
                if (!m.ARegleCotisation)
                {
                    s += " / non payée";
                }
                Console.WriteLine(s);
            }
        }

        public void ValiderCotisation(Membre membre)
        {
            membre.ARegleCotisation = true;
        }

        public void AffichageLoisirComp()
        {
            List<Personne> comp = new List<Personne>();
            List<Personne> loisir = new List<Personne>();
            foreach (Membre m in adherents)
            {
                if (m.EstCompetiteur)
                {
                    comp.Add(m);
                }
                else
                {
                    loisir.Add(m);
                }
            }
            foreach (Membre m in personnel)
            {
                if (m.EstCompetiteur)
                {
                    comp.Add(m);
                }
                else
                {
                    loisir.Add(m);
                }
            }
            Console.WriteLine("Compétiteurs:");
            foreach(Membre p in comp)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();
            Console.WriteLine("Loisirs:");
            foreach (Membre p in loisir)
            {
                if (p.Type == TypeMembre.Adherent)
                {
                    Console.WriteLine(p);
                }
            }
        }

        public List<Membre> TrierPar(string s)
        {
            List<Personne> membres = adherents.Concat(personnel).ToList();
            List<Membre> membresM = new List<Membre>();
            foreach(Personne p in membres) { membresM.Add((Membre)p); }
            switch (s)
            {
                case "nom":
                    membresM.Sort((x, y) => x.Nom.CompareTo(y.Nom));
                    break;
                case "classement":
                    membresM.Sort((x, y) => x.Classement.CompareTo(y.Classement));
                    break;
                default:
                    break;
            }
            return membresM;
        }
    }
}
