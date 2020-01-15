using System;

namespace MenuNS {
    /// <summary>
    /// Délégué permettant d'exécuter les exercices
    /// </summary>
    public delegate void ExecExercice();

    /// <summary>
    /// Class servant de support aux exercices présentés dans le menu
    /// </summary>
    public class Exercice : IMenuItem {
        /// <summary>
        /// Nom de l'exercice
        /// </summary>
        public string Nom { get; private set; }

        /// <summary>
        /// Numéro de l'exercice (ex: 1-1.)
        /// </summary>
        public string Numero { get; private set; }

        /// <summary>
        /// Méthode de l'exercice
        /// </summary>
        public ExecExercice Exo { get; private set; }

        /// <summary>
        /// Constructeur de l'exercice
        /// </summary>
        /// <param name="nom">Nom de l'exercice</param>
        /// <param name="numero">Numéro de l'exercice</param>
        /// <param name="exo">Méthode de l'exercice</param>
        public Exercice(ExecExercice exo, string numero, string nom = null) {
            Nom = nom;
            Numero = numero;
            Exo = exo;
        }

        /// <summary>
        /// Méthode permettant d'exécuter l'exercice
        /// </summary>
        public void Run() {
            Console.Clear();
            Exo();
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