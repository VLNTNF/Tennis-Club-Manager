using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesClubTennis.Evenements {
    class Competition : IEvenement {
        public NiveauCompetition Niveau {
            get => default;
            set {
            }
        }

        public int NbJoueursMin {
            get => default;
            set {
            }
        }

        public Classement ClassementMax {
            get => default;
            set {
            }
        }

        public List<Equipe> ListeEquipes {
            get => default;
            set {
            }
        }

        public TypeCompetition TypeCompetition {
            get => default;
            set {
            }
        }
    }

    enum NiveauCompetition {
        Departemental,
        Regional,
        National
    }

    enum TypeCompetition {
        Homme,
        Femme,
        Junior
    }
}
