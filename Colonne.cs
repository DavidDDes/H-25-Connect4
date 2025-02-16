using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtelierOO_102.TP1;

namespace Connect4
{
    internal class Colonne
    {
        Case[] _cases = new Case[Puissance4.HAUTEUR_GRILLE];
        /// <Entete>
        /// 
        /// <Entete>
        public Colonne(int numCol)
        {
            for (int i = 0; i < Puissance4.HAUTEUR_GRILLE; i++)
            {
                _cases[i] = new Case(numCol, i);
            }
        }
        /// <Entete>
        /// 
        /// <Entete>
        public void Afficher()
        {
            foreach (Case uneCase in _cases)
            {
                uneCase.Afficher();
            }

        }
        /// <Entete>
        /// 
        /// <Entete>
        public void InsererJeton(string symbole)
        {
            for (int i = Puissance4.HAUTEUR_GRILLE - 1; i >= 0; i--)
            {
                if (_cases[i].Contenu == "_") 
                {
                    _cases[i].Contenu = symbole;
                    break; 
                }
            }
        }
        /// <Entete>
        /// 
        /// <Entete>
        public Case ObtCase(int index)
        {
            return _cases[index];  
        }
        /// <Entete>
        /// 
        /// <Entete>
        public bool EstPleine()
        {
            return _cases[0].Contenu != "_";
        }






    }//
}//

