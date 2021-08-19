/*
        Programmeur:        Yvan Zacharie Kouemegni &  Yves Ndoky

        Date:               novembre

        Solution:           ServiceDeVoiture.sln
        Projet:             Voiture.csproj
        Class:              TypeClass

        But:                Initialisation des Marques  de voitures et de la consomation a 
````````````````````````````partir d'une enumeration
        
        Phase F
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace TypesNS
{
    public class Types
    {
        #region champs privee

        private string[] modePaiement;
        private string[] marquePrefere;
        private void InitModePaiement()
        {
            modePaiement = new string[] { "Carte de Credit ", "Carte de debit", "Paiement comptant", "e-tranfert", "Echange" };
    
        }

        private void InitMarque()
        {
            marquePrefere = new string[] { "Mazda", "Chevrolet", "Toyota", "YvesD" };
        }

        #endregion

        #region enumeration 
        /// <summary>
        /// Enumration de consomation et de marque
        /// </summary>
        public enum CodeTypes
        {
            modePaiellement,
            marque
        };
        #endregion

        #region Champs public , obtention de la consomation et de la marque de Vehicule

        /// <summary>
        /// Obtenir le mode de paiment et la marque prefer
        /// </summary>
        /// <param name="ct"></param>
        /// <returns>le tableau de paiement ou le tableau de marque prefere</returns>
        public string[] obtentionmodePaiellementMarque(CodeTypes ct)
        {
            string[] tableauInit;

            switch (ct)
            {
                case CodeTypes.modePaiellement:
                    tableauInit = modePaiement;
                    break;

                case CodeTypes.marque:
                    tableauInit = marquePrefere;
                    break;

                default:
                    tableauInit = modePaiement;
                    break;
            }

            return tableauInit;
        }
        #endregion

        #region Constructeur

        /// <summary>
        /// Constructeur de la classe TypeClass
        /// </summary>
        public Types()
        {
            InitModePaiement();
            InitMarque();
        }

        #endregion
    }
}
