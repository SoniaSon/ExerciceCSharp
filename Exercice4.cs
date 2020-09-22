﻿using System;

namespace Exercice4
{
    public enum TypeArticleEnum
    {
        Alimentaire,
        Droguerie,
        Habillement,
        Loisir
    }
    public struct ArticleType
    {
        private string nomArticle;
        private double prixArticle;
        private int quantiteArticle;
        private TypeArticleEnum _typeArticleEnum;

        public ArticleType(string nomArticle, double prixArticle, int quantiteArticle, TypeArticleEnum typeArticleEnum)
        {
            this.nomArticle = nomArticle;
            this.prixArticle = prixArticle;
            this.quantiteArticle = quantiteArticle;
            this._typeArticleEnum = typeArticleEnum;
        }


        public void Afficher()
        {
            Console.WriteLine("[Affichager l'article]");
            Console.WriteLine("Nom de l'article : " + nomArticle);
            Console.WriteLine("Prix de l'article : " + prixArticle + " euros");
            Console.WriteLine("Quantité de l'Article : " + quantiteArticle);

            if (_typeArticleEnum == TypeArticleEnum.Alimentaire)
            {
                Console.WriteLine("Type de l'article : Alimentaire");
            }

            if (_typeArticleEnum == TypeArticleEnum.Droguerie)
            {
                Console.WriteLine("Type de l'article : Droguerie");
            }

            if (_typeArticleEnum == TypeArticleEnum.Habillement)
            {
                Console.WriteLine("Type de l'article : Habillement");
            }

            if (_typeArticleEnum == TypeArticleEnum.Loisir)
            {
                Console.WriteLine("Type de l'article : Loisir");
            }


            Console.WriteLine(Environment.NewLine);
        }

        public void Ajouter()
        {
            quantiteArticle++;
            Console.WriteLine("[Ajout Article]");
            Console.WriteLine("Ajoutez un article, il y a " + quantiteArticle + " d'article " + nomArticle);
            Console.WriteLine(Environment.NewLine);
        }

        public void Retirer()
        {
            if (quantiteArticle != 0)
            {
                quantiteArticle--;
                Console.WriteLine("[Suppression Article]");
                Console.WriteLine("Supprimez un article, il reste " + quantiteArticle + " d'article " + nomArticle);
                Console.WriteLine(Environment.NewLine);
            }
            else
            {
                Console.WriteLine("[Suppression Article]");
                Console.WriteLine("Erreur : Il y a déjà 0 article");
                Console.WriteLine(Environment.NewLine);
            }

        }



    }

}
