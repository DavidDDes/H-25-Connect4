using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Connect4;

namespace AtelierOO_102.TP1
{
    internal class Grille
    {

        Colonne[] _colonnes = new Colonne[Puissance4.LARGEUR_GRILLE];



        /// <Entete>
        /// 
        /// <Entete>
        public Grille()
        {
            for (int i = 0; i < Puissance4.LARGEUR_GRILLE; i++)
            {
                _colonnes[i] = new Colonne(i);
            }
        }
        /// <Entete>
        /// 
        /// <Entete>
        public void Afficher()
        {
            Console.SetCursorPosition(0, Puissance4.DECALAGE_TITRE);
            Console.WriteLine("  A    B    C    D    E    F    G");
            foreach (Colonne uneColonne in _colonnes)
            {
                uneColonne.Afficher();
            }
        }
        /// <Entete>
        /// 
        /// <Entete>
        /// 


        public void InsererJeton(int col, string contenu)
        {
            _colonnes[col].InsererJeton(contenu);
        }
        /// <Entete>
        /// 
        /// <Entete>
        public bool EstPleine(int col)
        {
            return _colonnes[col].EstPleine();
        }
        /// <Entete>
        /// 
        /// <Entete>
        public Colonne[] ObtenirColonnes()
        {
            return _colonnes;
        }

        /// <Entete>
        /// 
        /// <Entete>
        public bool VerifierVictoire(string s)
        {

            // le s est le symbole

            // Horizontale
            for (int i = 0; i < Puissance4.HAUTEUR_GRILLE; i++)
            {
                for (int j = 0; j < Puissance4.LARGEUR_GRILLE - 3; j++)
                {
                    if (_colonnes[j].ObtCase(i).Contenu == s &&
                        _colonnes[j + 1].ObtCase(i).Contenu == s &&
                        _colonnes[j + 2].ObtCase(i).Contenu == s &&
                        _colonnes[j + 3].ObtCase(i).Contenu == s)
                    {
                       // Console.WriteLine("H");
                      //  Console.ReadKey(true);

                        return true;
                    }


                } // for largeur grille
            } // for hauteur grille

            //Verticale
            for (int j = 0; j < Puissance4.LARGEUR_GRILLE; j++)
            {
                for (int i = 0; i < Puissance4.HAUTEUR_GRILLE - 3; i++)
                {
                    if (_colonnes[j].ObtCase(i).Contenu == s &&
                        _colonnes[j].ObtCase(i + 1).Contenu == s &&
                        _colonnes[j].ObtCase(i + 2).Contenu == s &&
                        _colonnes[j].ObtCase(i + 3).Contenu == s)
                    {
                       // Console.Write("V");
                        //Console.ReadKey(true);


                        return true;
                    }
                }
            }
            // return false;
            // Diagonales > \ <

            for (int i = 0; i < Puissance4.HAUTEUR_GRILLE - 3; i++)
            {
                for (int j = 0; j < Puissance4.LARGEUR_GRILLE - 3; j++)
                {
                    if (_colonnes[j].ObtCase(i).Contenu == s &&
                        _colonnes[j + 1].ObtCase(i + 1).Contenu == s &&
                        _colonnes[j + 2].ObtCase(i + 2).Contenu == s &&
                        _colonnes[j + 3].ObtCase(i + 3).Contenu == s)
                    {
                      //  Console.WriteLine("D1");
                      //  Console.ReadKey(true);


                        return true;
                    }
                }
            }

            // Diagonales > / <

            for (int i = 0; i < Puissance4.HAUTEUR_GRILLE - 3; i++)
            {
                for (int j = 3; j < Puissance4.LARGEUR_GRILLE; j++)
                {
                    if (_colonnes[j].ObtCase(i).Contenu == s &&
                        _colonnes[j - 1].ObtCase(i + 1).Contenu == s &&
                        _colonnes[j - 2].ObtCase(i + 2).Contenu == s &&
                        _colonnes[j - 3].ObtCase(i + 3).Contenu == s)
                    {
                       // Console.WriteLine("D2");
                       // Console.ReadKey(true);


                        return true;
                    }
                }
            }


            return false;
        }// fin verif victoire



    }//
}//
