using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesClubTennis.Acteurs {
    public interface ICompetiteur : IComparable<ICompetiteur> {
        Classement.ValClassement Classement { get; set; }
    }
}
