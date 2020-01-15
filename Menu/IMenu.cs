using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuNS {
    interface IMenu : IMenuItem {
        int SaisieMenu();
        void AfficherMenu();
        int SaisieNombre(int borneMin, int borneMax);
    }
}
