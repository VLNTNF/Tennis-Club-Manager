using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassesClubTennis;

namespace Generales_Tests {
    [TestClass]
    public class Classement_Tests {
        [TestMethod]
        public void ConstructeurVide_GenereClassementNC() {
            Classement classement = new Classement();
            Classement.ValClassement actual = classement.ValeurClassement;

            Classement.ValClassement expected = Classement.ValClassement.NC;

            Assert.AreEqual(expected, actual);
        }
    }
}
