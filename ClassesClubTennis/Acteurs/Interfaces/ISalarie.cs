﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesClubTennis.Acteurs {
    interface ISalarie {
        double Salaire { get; set; }
        DateTime DateEntreeClub { get; set; }
        InfoBancaire InformationsBancaires { get; set; }
    }

    struct InfoBancaire {
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
    }
}
