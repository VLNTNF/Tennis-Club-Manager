using System;
using System.Collections.Generic;
using System.Text;



namespace ClassesClubTennis
{
    public class Classement : Utility, IComparable<Classement>
    {
        public enum ValClassement
        {
            NC = 0,
            Quarante = 1,
            Trente_Cinq = 2,
            Trente_Quatre = 3,
            Trente_Trois = 4,
            Trente_Deux = 5,
            Trente_Un = 6,
            Trente = 7,
            Quinze_Cinq = 8,
            Quinze_Quatre = 9,
            Quinze_Trois = 10,
            Quinze_Deux = 11,
            Quinze_Un = 12,
            Quinze = 13,
            Cinq_Six = 14,
            Quatre_Six = 15,
            Trois_Six = 16,
            Deux_Six = 17,
            Un_Six = 18,
            Zero = 19,
            Moins_Deux_Six = 20,
            Moins_Quatre_Six = 21,
            Moins_Quinze = 22,
            TopCent = 23
        }


        public static readonly Dictionary<ValClassement, string> _nomClassement = new Dictionary<ValClassement, string>() {
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
        public ValClassement ValeurClassement { get; set; } = ValClassement.NC;

        /// <summary>
        /// String décrivant correctement le nom du classement
        /// </summary>
        public string Nom
        {
            get
            {
                string retour;
                _nomClassement.TryGetValue(ValeurClassement, out retour);
                return retour;
            }
        }
        #endregion

        #region Constructeurs
        /// <summary>
        /// Constructeur dans le cas où le compétiteur a déjà un classement
        /// </summary>
        /// <param name="classementInitial">Classement du compétiteur au moment de sa création</param>
        public Classement(ValClassement classementInitial = ValClassement.NC)
        {
            ValeurClassement = classementInitial;
        }
        #endregion

        #region Méthodes
        /// <summary>
        /// Méthode permettant de modifier le classement
        /// </summary>
        /// <param name="nouveauClassement">Nouveau classement à attribuer</param>
        public void ChangerClassement(ValClassement nouveauClassement)
        {
            ValeurClassement = nouveauClassement;
        }

        /// <summary>
        /// Méthode décrivant l'instance par un string
        /// </summary>
        /// <returns>String décrivant l'instance</returns>
        public override string ToString()
        {
            return Nom;
        }

        public int CompareTo(Classement other)
        {
            return ValeurClassement.CompareTo(other.ValeurClassement);
        }

        public static ValClassement SaisieClassement()
        {
            ValClassement classement = ValClassement.NC;
            string entree;
            bool test = true;
            do
            {
                entree = SaisieEntree("Classement (NC, 40, 30/5, ... , Top 100): ");
                switch (entree)
                {
                    case ("NC"):
                        classement = ValClassement.NC;
                        break;
                    case ("40"):
                        classement = ValClassement.Quarante;
                        break;
                    case ("30/5"):
                        classement = ValClassement.Trente_Cinq;
                        break;
                    case ("30/4"):
                        classement = ValClassement.Trente_Quatre;
                        break;
                    case ("30/3"):
                        classement = ValClassement.Trente_Trois;
                        break;
                    case ("30/2"):
                        classement = ValClassement.Trente_Deux;
                        break;
                    case ("30/1"):
                        classement = ValClassement.Trente_Un;
                        break;
                    case ("30"):
                        classement = ValClassement.Trente;
                        break;
                    case ("15/5"):
                        classement = ValClassement.Quinze_Cinq;
                        break;
                    case ("15/4"):
                        classement = ValClassement.Quinze_Quatre;
                        break;
                    case ("15/3"):
                        classement = ValClassement.Quinze_Trois;
                        break;
                    case ("15/2"):
                        classement = ValClassement.Quinze_Deux;
                        break;
                    case ("15/1"):
                        classement = ValClassement.Quinze_Un;
                        break;
                    case ("15"):
                        classement = ValClassement.Quinze;
                        break;
                    case ("5/6"):
                        classement = ValClassement.Cinq_Six;
                        break;
                    case ("4/6"):
                        classement = ValClassement.Quatre_Six;
                        break;
                    case ("3/6"):
                        classement = ValClassement.Trois_Six;
                        break;
                    case ("2/6"):
                        classement = ValClassement.Deux_Six;
                        break;
                    case ("1/6"):
                        classement = ValClassement.Un_Six;
                        break;
                    case ("0"):
                        classement = ValClassement.Zero;
                        break;
                    case ("-2/6"):
                        classement = ValClassement.Moins_Deux_Six;
                        break;
                    case ("-4/6"):
                        classement = ValClassement.Moins_Quatre_Six;
                        break;
                    case ("-15"):
                        classement = ValClassement.Moins_Quinze;
                        break;
                    case ("Top 100"):
                        classement = ValClassement.TopCent;
                        break;
                    default:
                        test = false;
                        break;

                }
            } while (test == false);
            return classement;
        }

        public static (bool, Classement) SaisieCompetiteur()
        {
            bool comp = false;
            Classement classement = new Classement();
            string entree;

            do
            {
                entree = SaisieEntree("Compétiteur (oui/non): ");
            } while ((entree != "oui") && (entree != "non"));
            if (entree == "oui")
            {
                comp = true;
            }

            if (comp)
            {
                classement.ChangerClassement(SaisieClassement());
            }
            else { classement.ChangerClassement(ValClassement.NC); }
            return (comp, classement);
        }
        #endregion
    }
}
