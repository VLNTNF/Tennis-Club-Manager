﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesClubTennis.Acteurs {
    public sealed class Adversaire : Personne, ICompetiteur 
    {
        public Classement Classement { get; set; }

        public Club Club { get; set; }

        public Adversaire(string nom, string prenom, TypeSexe sexe, DateTime dateNaissance, string numeroTelephone, Adresse adresse, Club club) : base(nom, prenom, sexe, dateNaissance, numeroTelephone, adresse) 
        {
            Club = club;
        }

        public int CompareTo(ICompetiteur competiteur)
        {
            return Classement.CompareTo(competiteur.Classement);
        }

        public void Afficher()
        {
            Console.WriteLine("Type: Adversaire");
            Console.WriteLine("Nom: " + Nom);
            Console.WriteLine("Prénom: " + Prenom);
            Console.WriteLine("Sexe: " + Sexe);
            Console.WriteLine("Naissance: " + DateNaissance);
            Console.WriteLine("Téléphone: " + NumeroTelephone);
            Console.WriteLine("Adresse: " + Adresse);
            Console.WriteLine("Club: " + Club);
        }
    }
}
