﻿using System;

namespace Exercice1
{

    public class Article
    {
        protected string designation;
        protected double prix;

        public Article(string designation, double prix)
        {
            this.designation = designation;
            this.prix = prix;
        }

        public void acheter()
        {
            Console.Write("Achetez l'article " + designation + " avec le prix de " + prix + " euros");
        }

    }

    public class Livre : Article
    {
        protected string isbn;
        protected int nbPages;


        public Livre(string designation, double prix, string isbn, int nbPages) : base(designation, prix)
        {
            this.isbn = isbn;
            this.nbPages = nbPages;
        }
    }

    public class Poche : Livre
    {
        private string categorie;

        public Poche(string designation, double prix, string isbn, int nbPages, string categorie) : base(designation, prix, isbn, nbPages)
        {
            this.categorie = categorie;
        }
    }

    public class Broche : Livre
    {
        public Broche(string designation, double prix, string isbn, int nbPages) : base(designation, prix, isbn, nbPages)
        {
        }
    }

    public class Disque : Article
    {
        protected string label;

        public Disque(string designation, double prix, string label) : base(designation, prix)
        {
            this.label = label;

        }

        public void ecouter()
        {
            Console.WriteLine("Ecoutez le disque : " + designation + " du label " + label);
        }


    }

    public class Video : Article
    {
        protected string duree;

        public Video(string designation, double prix, string duree) : base(designation, prix)
        {
            this.duree = duree;
        }

        public void afficher()
        {
            Console.WriteLine("Regardez la vidéo : " + designation + " avec une durée de " + duree);

        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[Article]");
            Article newArticle = new Article("AR", 500.00);
            newArticle.acheter();

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("[Livre]");
            Article newLivre = new Livre("livreA", 5.00, "abc-hyhs-1235-0", 500);
            newLivre.acheter();

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("[Poche]");
            Article newPoche = new Poche("Paroles", 5.00, "500-3-16-148410-0", 100, "Title");
            newPoche.acheter();

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("[Broche]");
            Article newBroche = new Broche("N'importe quel livre", 5.00, "abc-25jh-1235-0", 100);
            newBroche.acheter();

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("[Disque]");
            Disque newDisque = new Disque("Nom disque", 20.00, "Hello");
            newDisque.ecouter();
            newDisque.acheter();

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("[Video]");
            Video newVideo = new Video("video test", 15.00, "1 heures");
            newVideo.afficher();
            newDisque.acheter();

            Console.WriteLine(Environment.NewLine + Environment.NewLine);



        }
    }
}
