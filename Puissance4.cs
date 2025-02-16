using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Connect4;

namespace AtelierOO_102.TP1
{
    internal class Puissance4
    {
        public static readonly int LARGEUR_GRILLE = 7;
        public const int DECALAGE_TITRE = 10;
        public const int HAUTEUR_GRILLE = 6;

        Grille _grille = new();
        Util u = new();
        bool partieTerminee = false;
        string joueurActif = "x";

        /// <Entete>
        /// 
        /// <Entete>

        public void Jouer()
        {

            u.Titre("Puissance 4!");
            u.Sep("Programmé par David Dumas-Desgagné");
            _grille.Afficher();

            while (!partieTerminee)
            {


                TraiterProchainCoup();

                if (_grille.VerifierVictoire(joueurActif))
                {
                    Console.WriteLine($"Le joueur {joueurActif} a gagné!");
                    partieTerminee=true;
                    break;
                }

                if (GrilleEstPleine())
                {
                    Console.WriteLine("Égalité des deux joueurs!");
                    partieTerminee = true;
                    break;
                }
            }


                u.Pause();
            
        }

        /// <Entete>
        /// 
        /// <Entete>
        /// 

        // verifie si il y a la place dans la grille
        public bool GrilleEstPleine()
        {
            foreach (var colonne in _grille.ObtenirColonnes())  
            {
                if (!colonne.EstPleine()) 
                {
                    return false;
                }
            }
            return true;
        }

        /// <Entete>
        /// 
        /// <Entete>
        void TraiterProchainCoup()
        {
            int numCol = -1;
            while (numCol == -1)
            {
                numCol = SaisirColonne();

                if (numCol == -1)
                {
                    Console.Write("Invalide, ");
                }

            }
            _grille.InsererJeton(numCol, joueurActif);
            _grille.Afficher();

            if (joueurActif == "x") { joueurActif = "y"; }
            else { joueurActif = "x"; }
        }
        /// <Entete>
        /// 
        /// <Entete>
        int SaisirColonne()
        {
            Console.WriteLine("Votre choix: ");
            char choix = u.SaisirChar();

            switch(choix)
            {
                case 'a':
                case 'A':
                    return 0;
                case 'B':
                case 'b':
                    return 1;
                case 'c':
                case 'C':
                    return 2;
                case 'd':
                case 'D':
                    return 3;
                case 'e':
                case 'E':
                    return 4;
                case 'F':
                case 'f':
                    return 5;
                case 'G':
                case 'g':
                    return 6;
                default:
                    break;

            }
            return -1; // a changer
        }






    }
}
