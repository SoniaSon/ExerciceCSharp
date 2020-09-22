using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice2
{
    public struct Article
    {
        private string nomArticle;
        private double prixArticle;
        private int quantiteArticle;

        public Article(string nomArticle, double prixArticle, int quantiteArticle)
        {
            this.nomArticle = nomArticle;
            this.prixArticle = prixArticle;
            this.quantiteArticle = quantiteArticle;
        }


        public void Afficher()
        {
            Console.WriteLine("[Affichager les Article]");
            Console.WriteLine("Nom de l'article : " + nomArticle);
            Console.WriteLine("Prix de l'article : " + prixArticle + " euros");
            Console.WriteLine("Quantité de l'Article : " + quantiteArticle);
            Console.WriteLine(Environment.NewLine);
        }

        public void Ajouter()
        {
            quantiteArticle++;
            Console.WriteLine("[Ajouter un Article]");
            Console.WriteLine("Vous avez ajoutez un article, il y a " + quantiteArticle + "d'article " + nomArticle);
            Console.WriteLine(Environment.NewLine);
        }

        public void Retirer()
        {
            if (quantiteArticle != 0)
            {
                quantiteArticle--;
                Console.WriteLine("[Supprimer un Article]");
                Console.WriteLine("Vous avez supprimez un article, il reste " + quantiteArticle + " d''article " + nomArticle);
                Console.WriteLine(Environment.NewLine);
            }
            else
            {
                Console.WriteLine("[Supprimer l'article]");
                Console.WriteLine("Il  n'y pas d'article");
                Console.WriteLine(Environment.NewLine);
            }

        }



    }
}
