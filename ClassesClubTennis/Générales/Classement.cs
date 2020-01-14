using System;
using System.Collections.Generic;
using System.Text;



namespace ClassesClubTennis {
    public class Classement : IComparable<Classement> {
        public enum ValClassement
        {
            NC,
            Quarante,
            Trente_Cinq,
            Trente_Quatre,
            Trente_Trois,
            Trente_Deux,
            Trente_Un,
            Trente,
            Quinze_Cinq,
            Quinze_Quatre,
            Quinze_Trois,
            Quinze_Deux,
            Quinze_Un,
            Quinze,
            Cinq_Six,
            Quatre_Six,
            Trois_Six,
            Deux_Six,
            Un_Six,
            Zero,
            Moins_Deux_Six,
            Moins_Quatre_Six,
            Moins_Quinze,
            TopCent
        }


        private static readonly Dictionary<ValClassement, string> _nomClassement = new Dictionary<ValClassement, string>() {
            {ValClassement.NC, "Non classé"},
            {ValClassement.Quarante, "40"},
            {ValClassement.Trente_Cinq, "30/5"},
            {ValClassement.Trente_Quatre, "30/4"},
            {ValClassement.Trente_Trois, "30/3"},
            {ValClassement.Trente_Deux, "30/2"},
            {ValClassement.Trente_Un, "30/1"},
            {ValClassement.Trente, "30"},
            {ValClassement.Quinze_Cinq, "15/5"},
            {ValClassement.Quinze_Quatre, "15/4"},
            {ValClassement.Quinze_Trois, "15/3"},
            {ValClassement.Quinze_Deux, "15/2"},
            {ValClassement.Quinze_Un, "15/1"},
            {ValClassement.Quinze, "15"},
            {ValClassement.Cinq_Six, "5/6"},
            {ValClassement.Quatre_Six, "4/6"},
            {ValClassement.Trois_Six, "3/6"},
            {ValClassement.Deux_Six, "2/6"},
            {ValClassement.Un_Six, "1/6"},
            {ValClassement.Zero, "0"},
            {ValClassement.Moins_Deux_Six, "-2/6"},
            {ValClassement.Moins_Quatre_Six, "-4/6"},
            {ValClassement.Moins_Quinze, "-15"},
            {ValClassement.TopCent, "Top 100"}
        };

        #region Propriétés
        /// <summary>
        /// Valeur de l'enum correspondant au classement
        /// </summary>
        public ValClassement ValeurClassement { get; private set; } = ValClassement.NC;

        /// <summary>
        /// String décrivant correctement le nom du classement
        /// </summary>
        public string Nom {
            get {
                string retour;
                _nomClassement.TryGetValue(ValeurClassement, out retour);
                return retour;
            }
        } 
        #endregion

        #region Constructeurs
        /// <summary>
        /// Constructeur vide (Classement par défaut est "non classé")
        /// </summary>
        public Classement() { }

        /// <summary>
        /// Constructeur dans le cas où le compétiteur a déjà un classement
        /// </summary>
        /// <param name="classementInitial">Classement du compétiteur au moment de sa création</param>
        public Classement(ValClassement classementInitial) {
            ValeurClassement = classementInitial;
        }
        #endregion

        #region Méthodes
        /// <summary>
        /// Méthode permettant de modifier le classement
        /// </summary>
        /// <param name="nouveauClassement">Nouveau classement à attribuer</param>
        public void ChangerClassement(ValClassement nouveauClassement) {
            ValeurClassement = nouveauClassement;
        }

        /// <summary>
        /// Méthode décrivant l'instance par un string
        /// </summary>
        /// <returns>String décrivant l'instance</returns>
        public override string ToString() {
            return Nom;
        }

        public int CompareTo(Classement other) {
            return ValeurClassement.CompareTo(other.ValeurClassement);
        }
        #endregion
    }
}
