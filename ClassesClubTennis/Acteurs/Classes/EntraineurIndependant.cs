using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesClubTennis.Acteurs
{
    public sealed class EntraineurIndependant : Personne, IEntraineur
    {
        public int NombreDeCoursAEffectuer { get; set; }

        public EntraineurIndependant(string nom, string prenom, TypeSexe sexe, DateTime dateNaissance, string numeroTelephone, Adresse adresse, int nombreDeCoursAEffectuer = 0) : base(nom, prenom, sexe, dateNaissance, numeroTelephone, adresse)
        {
            NombreDeCoursAEffectuer = nombreDeCoursAEffectuer;
        }

        public void Afficher()
        {
            Console.WriteLine("Type: Entraineur independant");
            Console.WriteLine("Nom: " + Nom);
            Console.WriteLine("Prénom: " + Prenom);
            Console.WriteLine("Sexe: " + Sexe);
            Console.WriteLine("Naissance: " + DateNaissance);
            Console.WriteLine("Téléphone: " + NumeroTelephone);
            Console.WriteLine("Adresse: " + Adresse);
            Console.WriteLine("Nombre de cours: " + NombreDeCoursAEffectuer);
        }

        public static EntraineurIndependant Creation()
        {
            string nom = SaisieEntree("Nom: ");
            string prenom = SaisieEntree("Prénom: ");
            TypeSexe sexe = SaisieSexe("Sexe (H/M): ");
            DateTime dateNaissance = SaisieDate("Naissance JJ/MM/AAAA: ");
            string numeroTelephone = SaisieEntree("Téléphone: ");
            Adresse adresse = Adresse.SaisieAdresse();
            int nbCours = SaisiePositive("Nombre de cours: ");
            return new EntraineurIndependant(nom, prenom, sexe, dateNaissance, numeroTelephone, adresse, nbCours);
        }
    }
}
