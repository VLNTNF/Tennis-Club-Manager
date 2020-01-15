using System;

namespace MenuNS {
    /// <summary>
    /// Class servant de support aux exercices présentés dans le menu
    /// </summary>
    public class Exercice : Fonction, IMenuItem {
        /// <summary>
        /// Nom de l'exercice
        /// </summary>
        public string Nom { get; private set; }

        /// <summary>
        /// Numéro de l'exercice (ex: 1-1.)
        /// </summary>
        public string Numero { get; private set; }
        public override string TexteMenu {
            get {
                return ToString();
            }
        }

        public Exercice(FonctionDele exo, string numero, string nom = null) : base(exo) {
            Nom = nom;
            Numero = numero;
        }

        /// <summary>
        /// Méthode permettant d'exécuter l'exercice
        /// </summary>
        public override void Run() {
            Console.Clear();
            base.Run();
        }

        public override string ToString() {
            string retour = $"Exercice {Numero}";

            if (!string.IsNullOrEmpty(Nom)) {
                retour += $": {Nom}";
            } 

            return retour;
        }
    }
}