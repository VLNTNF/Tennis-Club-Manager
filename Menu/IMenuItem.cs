namespace MenuNS {
    /// <summary>
    /// Interface permettant de définir les classes qui peuvent être affichées dans le menu
    /// </summary>
    public interface IMenuItem {
        /// <summary>
        /// Texte affiché dans l'entrée du menu
        /// </summary>
        string TexteMenu { get; }

        /// <summary>
        /// Méthode permettant d'afficher ou exécuter l'item du menu
        /// </summary>
        void Run();
    }
}