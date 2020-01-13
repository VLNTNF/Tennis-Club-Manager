using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesClubTennis.Evenements {
    interface IEvenement {
        DateTime Date { get; set; }
        TimeSpan Duree { get; set; }
        string Nom { get; set; }
    }
}
