using System;
using System.Collections.Generic;
using System.Text;

namespace Personnes
{
    class Personne
    {
        private string nom;
        private string prenom;
        private int age;
        private static int nbPersonnes;

        static Personne()
        {
            nbPersonnes = 0;
        }


        public Personne(string nom, string prenom, int age)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
            nbPersonnes++;
        }

        public void Afficher()
        {
            Console.WriteLine("[Affichager les informations de la personne]");
            Console.WriteLine("Nom : " + nom);
            Console.WriteLine("Prénom : " + prenom);
            Console.WriteLine("Age : " + age);
        }

        public int Combien()
        {
            return nbPersonnes;
        }
    }
}