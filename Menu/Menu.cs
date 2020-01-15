using System;
using System.Collections.Generic;

namespace MenuNS {
    /// <summary>
    /// Classe servant à créer un menu dans la console
    /// </summary>
    public class Menu : IMenuItem {
        private bool _overrideNom;

        /// <summary>
        /// Nom du menu
        /// </summary>
        public string Texte { get; set; }

        /// <summary>
        /// Liste des composants du menu (Exercice ou sous menu)
        /// </summary>
        public List<IMenuItem> Items { get; private set; }

        /// <summary>
        /// Constructeur du menu
        /// </summary>
        /// <param name="nom">Nom du menu</param>
        /// <param name="items">Liste des composants du menu (Exercice ou sous menu)</param>
        public Menu(List<IMenuItem> items, string texte, bool overrideNom = false) {
            Items = items;
            Texte = texte;
            _overrideNom = overrideNom;
        }

        /// <summary>
        /// Méthode permettant d'afficher et exécuter le menu
        /// </summary>
        public void Run() {
            ConsoleKeyInfo cki = default;
            ConsoleKey retour = default;

            do {
                Console.Clear();

                int item = SaisieMenu();
                retour = ExecuterChoix(item);

                if (retour != ConsoleKey.Escape && (Items[item - 1] is Exercice || item == 0)) {
                    Console.WriteLine("\nAppuyez sur Echap pour sortir du menu\n" +
                                      "ou\n" +
                                      "Appuyez sur Entrée pour revenir au menu");
                    cki = Console.ReadKey();
                }
            } while (cki.Key != ConsoleKey.Escape && retour != ConsoleKey.Escape);
        }

        /// <summary>
        /// Méthode servant à afficher le menu et récupérer le choix de l'utilisateur
        /// </summary>
        /// <returns>La valeur correspondant à l'item dans le menu (1 à n) et 0 si l'utilisateur veut sortir du menu</returns>
        private int SaisieMenu() {
            AfficherMenu();

            return SaisieNombre(0, Items.Count);
        }

        /// <summary>
        /// Méthode d'affichage du menu
        /// </summary>
        private void AfficherMenu() {
            Console.WriteLine(this);

            for (int i = 0; i < Items.Count; i++) {
                Console.WriteLine($"{i + 1}) {Items[i]}");
            }

            Console.WriteLine("0) Sortie");
        }

        /// <summary>
        /// Méthode servant à demander à l'utilisateur son choix
        /// </summary>
        /// <param name="borneMin">Valeur minimum que l'utilisateur peut rentrer</param>
        /// <param name="borneMax">Valeur maximum que l'utilisateur peut rentrer</param>
        /// <returns>Valeur choisie par l'utilisateur</returns>
        private static int SaisieNombre(int borneMin, int borneMax) {
            int input = -1, compteurErreurs = 0;
            bool estUneValeurValide = false;
            string retour = null;

            do {
                ResetLigneSiMauvaiseEntree(input, compteurErreurs, estUneValeurValide, retour);

                Console.Write($"Entrez un nombre entier compris entre {borneMin} et {borneMax} (inclus): ");
                estUneValeurValide = int.TryParse(retour = Console.ReadLine(), out input);
                compteurErreurs++;
            } while (input < borneMin || borneMax < input || !estUneValeurValide);

            Console.WriteLine();

            return input;
        }

        /// <summary>
        /// Méthode servant à supprimer les lignes d'entrée et d'erreur si l'utilisateur a rentré des valeurs érronées
        /// </summary>
        /// <param name="input">Valeur entrée par l'utilisateur ou 0 si la valeur était érronée</param>
        /// <param name="compteurErreurs">Nombre d'erreurs de l'utilisateur</param>
        /// <param name="estUneValeurValide">Booléen indiquant si l'entrée est valide</param>
        /// <param name="retour">Valeur entrée par l'utilisateur (valide ou non)</param>
        private static void ResetLigneSiMauvaiseEntree(int input, int compteurErreurs, bool estUneValeurValide, string retour) {
            if (input == 0 && !estUneValeurValide) {
                SupprimerLignePrecedente();
                if (compteurErreurs > 1)
                    SupprimerLignePrecedente();
                Console.WriteLine($"La valeur précédente \"{retour}\" n'est pas valide.");
            }
        }

        /// <summary>
        /// Méthode servant à supprimer la ligne précédante dans la console 
        /// </summary>
        public static void SupprimerLignePrecedente() {
            int ligneActuelle = Console.CursorTop;

            Console.SetCursorPosition(0, ligneActuelle - 1);
            ligneActuelle = Console.CursorTop;

            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, ligneActuelle);
        }

        /// <summary>
        /// Méthode servant à déterminer si le choix de l'utilisateur est d'exécuter un item ou de sortir d'un menu
        /// </summary>
        /// <param name="item">Numéro de l'item</param>
        /// <returns>Retourne une touche du clavier, Echap si l'utilisateur souhaite sortir du menu ou rien (0) si un item a été exécuté</returns>
        private ConsoleKey ExecuterChoix(int item) {
            ConsoleKey retour = default;

            if (item != 0)
                LancerItem(item - 1);
            else
                retour = ConsoleKey.Escape;

            return retour;
        }

        /// <summary>
        /// Méthode d'exécution de l'item
        /// </summary>
        /// <param name="item">Numéro de l'item</param>
        private void LancerItem(int item) {
            Items[item].Run();
        }

        public override string ToString() {
            string retour;

            if (_overrideNom) {
                retour = Texte;
            }
            else {
                retour = $"Menu {Texte}";
            }

            return retour;
        }
    }
}
