namespace MenuNS {
    /// <summary>
    /// Interface permettant de définir les classes qui peuvent être affichées dans le menu
    /// </summary>
    public interface IMenuItem {
        /// <summary>
        /// Méthode permettant d'afficher ou exécuter l'item du menu
        /// </summary>
        void Run();
    }
}