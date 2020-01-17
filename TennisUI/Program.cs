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
        static Club club = new Club();

        static void Main(string[] args)
        {
        

            Menu menuMembre = new Menu(
                new List<IMenuItem>() {
                    new Fonction(CreationMembre, "Créer un membre"),
                    new Fonction(CreationIndependant, "Créer un indépendant"),
                    new Fonction(SupprimerMembre, "Supprimer un membre"),
                    new Fonction(SupprimerIndependant, "Supprimer un indépendant"),
                    new Fonction(ModifierAdresse, "Modifier une adresse"),
                    new Fonction(ModifierTelephone, "Modifier un numéro de téléphone"),
                    new Fonction(ValidationCotisation, "Valider une cotisation"),
                    new Fonction(VerificationCotisations, "Vérifier les cotisations"),
                    new Fonction(AffichagePersonnes, "Afficher les membres et indépendants"),
                    new Fonction(AffichageInfo, "Afficher les informations d'une personne")
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
            
        }

        #region Méthodes Menu Membre
        private static void ValidationCotisation()
        {
            club.ValiderCotisation((Membre)club.SelectionnerMembre());
            Console.WriteLine("\nEffectué !");
            Console.ReadKey();
        }

        private static void AffichageInfo()
        {
            club.AfficherInfoPersonne();
            Console.ReadKey();
        }

        private static void AffichagePersonnes()
        {
            club.AfficherPersonnes();
            Console.ReadKey();
        }

        private static void VerificationCotisations()
        {
            club.AfficherCotisations();
            Console.ReadKey();
        }

        private static void ModifierTelephone()
        {
            club.SelectionnerPersonne().ModifierNumeroTelephone(Utility.SaisieEntree("Téléphone: "));
            Console.WriteLine("\nEffectué !");
            Console.ReadKey();
        }

        private static void ModifierAdresse()
        {
            club.SelectionnerPersonne().Adresse.Demenager(Adresse.SaisieAdresse());
            Console.WriteLine("\nEffectué !");
            Console.ReadKey();
        }

        private static void SupprimerIndependant()
        {
            club.EnleverIndependant((EntraineurIndependant)club.SelectionnerIndependant());
            Console.WriteLine("\nEffectué !");
            Console.ReadKey();
        }

        private static void SupprimerMembre()
        {
            club.EnleverMembre((Membre)club.SelectionnerMembre());
            Console.WriteLine("\nEffectué !");
            Console.ReadKey();
        }

        private static void CreationIndependant()
        {
            club.AjouterIndependant(EntraineurIndependant.Creation());
            Console.WriteLine("\nEffectué !");
            Console.ReadKey();
        }

        private static void CreationMembre()
        {
            TypeMembre typeMembre = Membre.SaisieTypeMembre();
            if (typeMembre == TypeMembre.Adherent)
            {
                club.AjouterMembre(Membre.Creation());
            }
            else
            {
                club.AjouterMembre(EntraineurSalarie.Creation());
            }
            Console.WriteLine("\nEffectué !");
            Console.ReadKey();
        }
        #endregion
        
    }
}
