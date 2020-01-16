using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesClubTennis
{
    public struct Adresse
    {
        public string NumeroEtNomDeVoie { get; private set; }
        public int CodePostal { get; private set; }
        public string Ville { get; private set; }

        public Adresse(string numeroEtNomDeVoie, int codePostal, string ville)
        {
            NumeroEtNomDeVoie = numeroEtNomDeVoie;
            CodePostal = codePostal;
            Ville = ville;
        }

        #region Méthodes
        /// <summary>
        /// Méthode permettant de déménager dans une autre ville
        /// </summary>
        /// <param name="numeroEtNomDeVoie">Nouvelle voie</param>
        /// <param name="codePostal">Nouveau code postal</param>
        /// <param name="ville">Nouvelle ville</param>
        public void Demenager(string numeroEtNomDeVoie, int codePostal, string ville)
        {
            NumeroEtNomDeVoie = numeroEtNomDeVoie;
            CodePostal = codePostal;
            Ville = ville;
        }

        /// <summary>
        /// Méthode permettant de déménager dans la même ville
        /// </summary>
        /// <param name="numeroEtNomDeVoie">Nouvelle voie</param>
        public void Demenager(string numeroEtNomDeVoie)
        {
            NumeroEtNomDeVoie = numeroEtNomDeVoie;
        }

        /// <summary>
        /// Méthode permettant de comparer si deux adresses sont dans la même ville
        /// </summary>
        /// <param name="adresse">Adresse à comparer à l'instance présente</param>
        /// <returns>Booléen indiquant si l'adresse est dans la même ville</returns>
        public bool AMemeVille(Adresse adresse)
        {
            return Ville.Equals(adresse.Ville);
        }

        public static string SaisieEntree(string entree)
        {
            string res;
            do
            {
                Console.Write(entree);
                res = Console.ReadLine();
            } while ((res == "") || (res == " "));
            return res;
        }

        public static Adresse SaisieAdresse()
        {
            string nomRue = SaisieEntree("N° et nom de rue: ");
            int codePostal = Convert.ToInt32(SaisieEntree("Code postal: "));
            string ville = SaisieEntree("Ville: ");
            return new Adresse(nomRue, codePostal, ville);
        }

        public override string ToString()
        {
            return NumeroEtNomDeVoie + " " + CodePostal + " " + Ville;
        }

        #endregion
    }
}
