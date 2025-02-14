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



        public void Jouer()
        {

            u.Titre("Puissance 4!");
            _grille.Afficher();
            while (!partieTerminee)
            {


                TraiterProchainCoup();
            }


                u.Pause();
            
        }
        void TraiterProchainCoup()
        {
            int numCol = SaisirColonne();
            _grille.InsererJeton(numCol, joueurActif);
            _grille.Afficher();

            if (joueurActif == "x") { joueurActif = "y"; }
            else { joueurActif = "x"; }
        }

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
            return 0; // a changer
        }






    }
}
