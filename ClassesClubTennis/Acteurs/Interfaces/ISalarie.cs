using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesClubTennis.Acteurs {
    public interface ISalarie {
        double Salaire { get; set; }
        DateTime DateEntreeClub { get; set; }
        InfoBancaire InformationsBancaires { get; set; }
    }

    public struct InfoBancaire {
        public string IBAN {
            get => default;
            set {
            }
        }

        public string BIC {
            get => default;
            set {
            }
        }

        public InfoBancaire(string iban, string bic)
        {
            IBAN = iban;
            BIC = bic;
        }
    }
}
