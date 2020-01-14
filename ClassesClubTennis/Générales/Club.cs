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

        public Club(string nom, string diminutif, Adresse adresse, Dirigeant president, List<Membre> adherents=null,List<Membre> personnel=null)
        {
            this.nom = nom;
            this.diminutif = diminutif;
            this.adresse = adresse;
        }

        public Club()
        {
            this.nom = "Tennis Club de Courbevoie";
            this.diminutif = "TCC";
            this.adresse = new Adresse("8 rue Gervais", 92400, "Courbevoie");
        }
        
        public override string ToString()
        {
            return Diminutif;
        }

        public void AjouterMembre(Membre membre)
        {
            if(membre.Type == TypeMembre.Adherent)
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
