using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuNS {
    public class Fonction : IMenuItem {
        #region Propriétés
        public virtual string TexteMenu { get; private set; }
        public FonctionDele FonctionExe { get; set; } 
        #endregion

        #region Constructeurs
        protected Fonction(FonctionDele fonction) {
            FonctionExe = fonction;
            TexteMenu = null;
        }

        public Fonction(FonctionDele fonction, string texteMenu) {
            FonctionExe = fonction;
            TexteMenu = texteMenu;
        }
        #endregion

        #region Méthodes
        public virtual void Run() {
            FonctionExe();
        }

        public override string ToString() {
            return TexteMenu;
        } 
        #endregion
    }

    /// <summary>
    /// Délégué permettant d'exécuter les fonctions
    /// </summary>
    public delegate void FonctionDele();
}