using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesClubTennis.Acteurs
{
    sealed class EntraineurIndependant : Personne, IEntraineur
    {
        public int NombreDeCoursAEffectuer { get; set; }

        public EntraineurIndependant(string nom, string prenom, TypeSexe sexe, DateTime dateNaissance, int nombreDeCoursAEffectuer = 0) : base(nom, prenom, sexe, dateNaissance)
        {
            NombreDeCoursAEffectuer = nombreDeCoursAEffectuer;
        }
    }
}
