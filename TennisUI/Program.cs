using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuNS;
using ClassesClubTennis;
using ClassesClubTennis.Acteurs;
using ClassesClubTennis.Evenements;

namespace TennisUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Club club = new Club();
            //Membre membre = Membre.Creation();
            //club.AjouterMembre(membre);
            //Console.WriteLine();
            //membre.Afficher();
            club.AfficherPersonnes();
            Console.ReadKey();

            /*
            Club club = new Club();

            Menu menuMembre = new Menu(
                new List<IMenuItem>() {
                    new Fonction(CreationMembre(club), "Créer un membre"),
                    new Fonction(CreationSalarie(), "Créer un salarié"),
                    new Fonction(SupprimerMembre(), "Supprimer un membre"),
                    new Fonction(SupprimerSalarie(), "Supprimer un salarié"),
                    new Fonction(ModifierAdresse(), "Modifier une adresse"),
                    new Fonction(ModifierTelephone(), "Modifier un numéro de téléphone"),
                    new Fonction(VerificationCotisations(), "Vérifier les cotisations"),
                    new Fonction(AffichageMembre(), "Afficher les membres")
                }, "Module Membre", true);

            Menu menuCompet = new Menu(
                new List<IMenuItem>()
                {

                }, "Module Compétitions", true);

            Menu menuStats = new Menu(
                new List<IMenuItem>()
                {

                }, "Module Statistiques", true);

            Menu menuProjet = new Menu(
                new List<IMenuItem>() {
                    menuMembre,
                    menuCompet,
                    menuStats
                }, "Menu général", true);

            menuProjet.Run();
            */
            
        }
        
        #region Méthodes Menu Membre
        private static FonctionDele AffichageMembre()
        {
            throw new NotImplementedException();
        }

        private static FonctionDele VerificationCotisations()
        {
            throw new NotImplementedException();
        }

        private static FonctionDele ModifierTelephone()
        {
            throw new NotImplementedException();
        }

        private static FonctionDele ModifierAdresse()
        {
            throw new NotImplementedException();
        }

        private static FonctionDele SupprimerSalarie()
        {
            throw new NotImplementedException();
        }

        private static FonctionDele SupprimerMembre()
        {
            throw new NotImplementedException();
        }

        private static FonctionDele CreationSalarie()
        {
            throw new NotImplementedException();
        }

        private static FonctionDele CreationMembre(Club club)
        {
            /*
            Membre membre = new Membre();
            club.AjouterMembre(Membre.Creation());
            */
            throw new NotImplementedException();
        }
        #endregion
        
    }
}
