/*
        Programmeur:        Yvan Zacharie Kouemegni &  Yves Ndoky

        Date:               novembre

        Solution:           ServiceDeVoiture.sln
        Projet:             ServiceDeVoiture.csproj
        Class:              ServiceVenteDeVoitureGeneralClass

        But:                Manipulation  de la classe generale
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ce = ServiceDeVoitureNS.ServiceVenteDeVoitureGeneralClass.CodeErreurs;


namespace ServiceDeVoitureNS
{
    /// <summary>
    /// Classe generale dans la couche de presentation
    /// </summary>
    /// <remarks>Projet: ServiceDeVoiture</remarks>
    class ServiceVenteDeVoitureGeneralClass
    {
        #region Enumeration
        public enum CodeErreurs
        {
            CEErreurIndeterminee
        }
        #endregion

        #region Declaration
        #endregion

        #region Initialisation

        public static string[] tMessagesErreursString = new string[13];

        // Initialisation de mes messages d'erreur

        public static void InitialiserMessagesErreurs()
        {
            tMessagesErreursString[(int)ce.CEErreurIndeterminee] = "Une erreur indeterminee s'est produite, veuillez contacter la personne ressource";

        }
        #endregion
    }
}
