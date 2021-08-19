/*
        Programmeur:        Yvan Zacharie Kouemegni &  Yves Ndoky

        Date:               novembre

        Solution:           ServiceDeVoiture.sln
        Projet:             Voiture.csproj
        Class:              Voiture

        But:                Manipulation  de la classe Voiture

        Phase F
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Text.RegularExpressions; //Pour utiliser expression reguliere

namespace VoitureNS
{
    /// <summary>
    /// Objet métier: Classe Voiture
    /// </summary>
    /// <remarks>Tous droits réservés: Yves et Zacharie Inc. 2025</remarks>
    /// 
    public class Voiture
    {
        #region Declaration des variables privée

        private string[] tConsommationStr;
        private string[] tMarques;
        private decimal[,] tPrixDecimal;
        private string nomStr;
        private string addresseStr;
        private string villeStr;
        private string provinceStr;
        private string codePostalStr;
        private string telephoneStr;
        private string modePaiementStr;
        private string voiturePrefStr;
        private string consomationStr;
        private string marqueStr;
        private decimal prixDecimal;
        private DateTime dateReservation;
        private DateTime dateLivraison;

        /// <summary>
        /// 
        /// </summary>
        public static int idInt;

        private const string CODE_POSTAL_MODELE_Str = "^([ABCEGHJKLMNPRSTVXY]\\d[ABCEGHJKLMNPRSTVWXYZ])\\ {0,1}(\\d[ABCEGHJKLMNPRSTVWXYZ]\\d)$";

        private const string TELEPHONE_MODELE_Str = "^(\\([2-9]\\d{2}\\)|[2-9]\\d{2})[- .]?\\d{3}[- .]?\\d{4}$";

        #endregion

        #region Declaration des enumrerations , tableaux d'erreurs

        private enum CodesErreurs
        {
            NomObligatoire,
            AdresseObligatoire,
            VilleObligatoire,
            ProvinceObligatoire,
            CodePostalObligatoire,
            CodePostalInvalide,
            TelephoneObligatoire,
            TelephoneInvalide,
            ModePaiementObligatoire,
            VoiturePreferetObligatoire,
            ComsomatiionInvalide,
            MarqueInvalide,
            DateLivraisonInvalide,
            ErreurIndeterminee,
            prixOutRange,
            ConsomationMarqueNull


        }

        private string[] tMessagesErreurs = new string[20];

        private  void initialisationMessageErreurs()
        {
            tMessagesErreurs[(int)CodesErreurs.NomObligatoire] = "Le nom du client est obligatoire";
            tMessagesErreurs[(int)CodesErreurs.AdresseObligatoire] = "L'addresse du client est obligatoire";
            tMessagesErreurs[(int)CodesErreurs.VilleObligatoire] = "La ville du client est obligatoire";
            tMessagesErreurs[(int)CodesErreurs.ProvinceObligatoire] = "La province du client est obligatoire";
            tMessagesErreurs[(int)CodesErreurs.CodePostalObligatoire] = "Le codePostal du client est obligatoire";
            tMessagesErreurs[(int)CodesErreurs.CodePostalInvalide] = "Le codePostal du client est invalide";
            tMessagesErreurs[(int)CodesErreurs.TelephoneObligatoire] = "Le telephone du client est obligatoire";
            tMessagesErreurs[(int)CodesErreurs.TelephoneInvalide] = "Le telephone du client est invalide";
            tMessagesErreurs[(int)CodesErreurs.ModePaiementObligatoire] = "Le mode de paiement du client est obligatoire";
            tMessagesErreurs[(int)CodesErreurs.VoiturePreferetObligatoire] = "La voiture prefere  du client est obligatoire";
            tMessagesErreurs[(int)CodesErreurs.ComsomatiionInvalide] = "La consomation du client est invalide";
            tMessagesErreurs[(int)CodesErreurs.MarqueInvalide] = "La marque du client est invalide";
            tMessagesErreurs[(int)CodesErreurs.DateLivraisonInvalide] = "La date de livraison est invalide";
            tMessagesErreurs[(int)CodesErreurs.ErreurIndeterminee] = "Erreur indeterminer veuillez contacter la personne resource";
            tMessagesErreurs[(int)CodesErreurs.prixOutRange] = "Le prix est en dehors des limites demander ";
            tMessagesErreurs[(int)CodesErreurs.ConsomationMarqueNull] = "La consomation et la marque sont null , impossible d'avoir un prix ";
        }


        #endregion

        #region Propriete

        /// <summary>
        /// Id de la trasaction
        /// </summary>
        public int Id
        {
            get { return idInt; }
        }
        /// <summary>
        /// Nom
        /// </summary>
        public string Nom
        {
            get
            {
                return nomStr;
            }
            set
            {

                if (value != null)  // verifier si null
                {
                    value = value.Trim();
                    if (value != String.Empty)  // verifier si  vide
                        nomStr = value;
                    else
                        throw new ArgumentOutOfRangeException(Nom,tMessagesErreurs[(int)CodesErreurs.NomObligatoire]);
                }
                else
                    throw new ArgumentNullException(tMessagesErreurs[(int)CodesErreurs.NomObligatoire]);
            }
        }

        /// <summary>
        /// Adress
        /// </summary>
        public string Addresse
        {
            get
            {
                return addresseStr;
            }
            set
            {
                if (value != null)  // verifier si null
                {
                    value = value.Trim();
                    if (value != String.Empty)  // verifier si  vide
                        addresseStr = value;
                    else
                        throw new ArgumentOutOfRangeException(Addresse, tMessagesErreurs[(int)CodesErreurs.AdresseObligatoire]);
                }
                else
                    throw new ArgumentNullException(tMessagesErreurs[(int)CodesErreurs. AdresseObligatoire]);
            }
        }

        /// <summary>
        /// Ville
        /// </summary>
        public string Ville
        {
            get
            {
                return villeStr;
            }
            set
            {
                if (value != null)  // verifier si null
                {
                    value = value.Trim();
                    if (value != String.Empty)  // verifier si  vide
                        villeStr = value;
                    else
                        throw new ArgumentOutOfRangeException(Ville,tMessagesErreurs[(int)CodesErreurs.VilleObligatoire]);
                }
                else
                    throw new ArgumentNullException(tMessagesErreurs[(int)CodesErreurs.VilleObligatoire]);
            }
        }

        /// <summary>
        /// Province
        /// </summary>
        public string Province
        {
            get
            {
                return provinceStr;
            }
            set
            {
                if (value != null)  // verifier si null
                {
                    value = value.Trim();
                    if (value != String.Empty)  // verifier si  vide
                        provinceStr = value;
                    else
                        throw new ArgumentOutOfRangeException(Province, tMessagesErreurs[(int)CodesErreurs.ProvinceObligatoire]);
                }
                else
                    throw new ArgumentNullException(tMessagesErreurs[(int)CodesErreurs.ProvinceObligatoire]);
            }
        }

        /// <summary>
        /// CodePostal
        /// </summary>
        public string CodePostal //Ne capte pas la bonne erreur
        {
            get
            {
                return codePostalStr;
            }
            set
            {
                if (value != null)  // verifier si null
                {
                    value = value.Trim();
                    if (value != String.Empty) {
                        if (Regex.IsMatch(value, CODE_POSTAL_MODELE_Str, RegexOptions.IgnoreCase))
                        {
                            codePostalStr = value;
                        }
                        else
                            throw new FormatException(tMessagesErreurs[(int)CodesErreurs.CodePostalInvalide]);
                    }
                    else
                        throw new ArgumentOutOfRangeException(CodePostal, tMessagesErreurs[(int)CodesErreurs.CodePostalInvalide]);
                }
                else
                    throw new ArgumentNullException(tMessagesErreurs[(int)CodesErreurs.CodePostalObligatoire]);
            }
        }

        /// <summary>
        /// Telephone
        /// </summary>
        public string Telephone
        {
            get
            {
                return telephoneStr;
            }
            set
            {
                if (value != null)  // verifier si null
                {
                    value = value.Trim();
                    if (value != String.Empty) {
                        if (Regex.IsMatch(value, TELEPHONE_MODELE_Str, RegexOptions.IgnoreCase))
                        {
                            telephoneStr = value;
                        }
                        else
                            throw new FormatException(tMessagesErreurs[(int)CodesErreurs.TelephoneInvalide]);
                    }
                    else
                        throw new ArgumentOutOfRangeException(Telephone,tMessagesErreurs[(int)CodesErreurs.TelephoneObligatoire]);
                }
                else
                    throw new ArgumentNullException(tMessagesErreurs[(int)CodesErreurs.TelephoneObligatoire]);
            }
        }

        /// <summary>
        /// Mode Paiment
        /// </summary>
        public string ModePaiment
        {
            get
            {
                return modePaiementStr;
            }
            set
            {
                if (value != null)  // verifier si null
                {
                    value = value.Trim();
                    if (value != String.Empty)  // verifier si  vide
                        modePaiementStr = value;
                    else
                        throw new ArgumentOutOfRangeException(ModePaiment, tMessagesErreurs[(int)CodesErreurs.ModePaiementObligatoire]);
                }
                else
                    throw new NullReferenceException(tMessagesErreurs[(int)CodesErreurs.ModePaiementObligatoire]);
            }
        }

        /// <summary>
        /// VoiturePrefere
        /// </summary>
        public string VoiturePrefe
        {
            get
            {
                return voiturePrefStr;
            }
            set
            {
                if (value != null)  // verifier si null
                {
                    value = value.Trim();

                    if (value != String.Empty)  // verifier si  vide
                        voiturePrefStr = value;
                    else
                        throw new ArgumentOutOfRangeException(VoiturePrefe, tMessagesErreurs[(int)CodesErreurs.VoiturePreferetObligatoire]);
                }
                else
                    throw new NullReferenceException(tMessagesErreurs[(int)CodesErreurs.VoiturePreferetObligatoire]);
            }
        }

        /// <summary>
        /// Consomation
        /// </summary>
        public string Consomation
        {
            get
            {
                return consomationStr;
            }
            set
            {

                if (value != null)  // verifier si null
                {
                    value = value.Trim();
                    if (Array.IndexOf(tConsommationStr, value) != -1 )  //Verifier si la donner qui a ete entre a ete retouver dans le tableau  de consomation
                        consomationStr = value;
                    else
                        throw new ArgumentOutOfRangeException(Consomation,tMessagesErreurs[(int)CodesErreurs.ComsomatiionInvalide]);
                }
                else
                    throw new ArgumentNullException(tMessagesErreurs[(int)CodesErreurs.ComsomatiionInvalide]);
            }
        }

        /// <summary>
        /// Marque de la voiture
        /// </summary>
        public string Marque
        {
            get
            {
                return marqueStr;
            }
            set
            {

                if (value != null)  // verifier si null
                {
                    value = value.Trim();
                    if (Array.IndexOf(tMarques, value) != -1)  //Verifier si la donner qui a ete entre a ete retouver dans le tableau  de Marques
                        marqueStr = value;
                    else
                        throw new ArgumentOutOfRangeException(Marque,tMessagesErreurs[(int)CodesErreurs.MarqueInvalide]);
                }
                else
                    throw new ArgumentNullException(tMessagesErreurs[(int)CodesErreurs.MarqueInvalide]);
            }
        }

        /// <summary>
        /// Prix
        /// </summary>
        public decimal Prix
        {
            get
            {
                return prixDecimal;
            }
            set
            {
                if (value > 0)
                {
                    if (Consomation != String.Empty && Marque != String.Empty)
                    {
                        int indiceConsomation = Array.IndexOf(tConsommationStr, Consomation);   // indice recu au niveau de la consomation
                        int indiiceMarque = Array.IndexOf(tMarques, Marque);                     // indice recu au de la marques.

                        if (tPrixDecimal[indiceConsomation, indiiceMarque] == value)                  //On verifie si le prix correspond bell et bien a la valeur du tableau. 
                        {
                            prixDecimal = value;
                        }
                        else
                            throw new ArgumentException(tMessagesErreurs[(int)CodesErreurs.ErreurIndeterminee]);
                    }
                    else
                        throw new ArgumentNullException(tMessagesErreurs[(int)CodesErreurs.ConsomationMarqueNull]);

                }
                else
                    throw new ArgumentOutOfRangeException("Prix", tMessagesErreurs[(int)CodesErreurs.prixOutRange]);

            }
        }


        /// <summary>
        /// Date de la consomation
        /// </summary>
        public DateTime DateReservation
        {
            get
            {
                return dateReservation;
            }
            set
            {
                DateTime debut = DateTime.Now.AddDays(-15);
                DateTime fin = DateTime.Now.AddDays(15);

                if (debut <= value && value <= fin)
                {
                    dateReservation = value;
                    dateLivraison = DateReservation.AddDays(30);  // si la date entrer fait du sens , alors augmente la date de livraison de 30
                }
                else
                    throw new ArgumentOutOfRangeException(tMessagesErreurs[(int)CodesErreurs.DateLivraisonInvalide]);
            }
        }
        /// <summary>
        /// Date de livraison
        /// </summary>

        public DateTime DateLivraison
        {
            get
            { 
                return dateLivraison; 
            }

        }
        #endregion

        #region Initialisation des tableaux
        private void InitTableau()
        {
            tConsommationStr = new string[5] { "1 litre", "3 litres", "5 litres", "10 litres", "> 10 litres" };
            tMarques = new string[4] { "Mazda", "Chevrolet", "Toyota", "YvesD" };

            tPrixDecimal = new decimal[,]
            {
                {10M,25M,13M,54M },
                {15M,26M,17M,28M},
                {19M,11M,11M,12M},
                {13.5M,14M,15M,16M },
                {27M,38M,35M,60M }
            };

        }
        #endregion

        #region Constructeur
        /// <summary>
        /// Constructeur classe Voiture
        /// </summary>
        public Voiture()
        {
            InitTableau();
            initialisationMessageErreurs();
        }

        /// <summary>
        /// Constructeur avec parametre
        /// </summary>
        /// <param name="nomForm"></param>
        /// <param name="addresseStrFom"></param>
        /// <param name="villeStrForm"></param>
        /// <param name="provinceStrForm"></param>
        /// <param name="codePostalStrForm"></param>
        /// <param name="telephoneStrForm"></param>
        /// <param name="modePaiementStrForm"></param>
        /// <param name="voiturePrefStrForm"></param>
        /// <param name="consomationStrForm"></param>
        /// <param name="marqueStrForm"></param>
        /// <param name="prixDecimalForm"></param>
        /// <param name="dateReservationForm"></param>
        public Voiture(string nomForm, string addresseStrFom, string villeStrForm,
            string provinceStrForm, string codePostalStrForm, string telephoneStrForm,
            string modePaiementStrForm, string voiturePrefStrForm, string consomationStrForm,
            string marqueStrForm, decimal prixDecimalForm, DateTime dateReservationForm) : this()
        {
            Nom = nomForm;
            Addresse = addresseStrFom;
            Ville = villeStrForm;
            Province = provinceStrForm;
            CodePostal = codePostalStrForm;
            Telephone = telephoneStrForm;
            ModePaiment = modePaiementStrForm;
            VoiturePrefe = voiturePrefStrForm;
            Consomation = consomationStrForm;
            Marque = marqueStrForm;
            Prix = prixDecimalForm;
            DateReservation = dateReservationForm;

        }
        #endregion

        #region Consommation d'essences

        /// <summary>
        /// Tableau de consomation
        /// </summary>
        /// <returns>Le tableau de consomation (string)</returns>
        /// 
        public string[] ObtenirConsommation()
        {
            return tConsommationStr; //combobox.Items.AddRange
        }
        #endregion

        #region Marques de voiture
        /// <summary>
        /// Tableau des marques
        /// </summary>
        /// <returns>Le tableau des marques (string)</returns>
        /// 
        public string[] ObtenirMarques()
        {
            return tMarques;
;
        }
        #endregion

        #region Prix des voitures
        /// <summary>
        /// Tableau des prix
        /// </summary>
        /// <param name="indiceConsommation"></param>
        /// <param name="indiceMarques"></param>
        /// <returns>Le prix specifique a une consomation et une marque</returns>
        public decimal ObtenirPrix(int indiceConsommation, int indiceMarques)
        {

            if(indiceConsommation >=0  && indiceConsommation <= tPrixDecimal.GetUpperBound(0))
            {

                if (indiceMarques >= 0 && indiceMarques <= tPrixDecimal.GetUpperBound(0))
                {
                    return tPrixDecimal[indiceConsommation, indiceMarques];
                }
                else
                {
                    throw new ArgumentOutOfRangeException("l'indice de Marques est hors de limite");
                }
                    
            }
            else
            {
                throw new ArgumentOutOfRangeException("l'indice de consomation est hors de limite");
            }
                 
        }


        /// <summary>
        /// Tableau des prix
        /// </summary>
        /// <param name="consomation">une  valeur de type string qui determine la consomation du vehicule</param>
        /// <param name="marque"> la marque de la voiture</param>
        /// <returns>Le prix specifique a une consomation et une marque</returns>
        public decimal ObtenirPrix(string consomation, string marque)
        {
            int positionMarque = Array.IndexOf(tMarques, marque);
            int positionConsomation = Array.IndexOf(tConsommationStr, consomation);

            if (positionConsomation >= 0 && positionConsomation <= tPrixDecimal.GetUpperBound(0))
            {

                if (positionMarque >= 0 && positionMarque <= tPrixDecimal.GetUpperBound(0))
                {
                    return tPrixDecimal[positionConsomation, positionMarque];
                }
                else
                {
                    throw new ArgumentException("l'indice de Marques est hors de limite ou la valeur n'a pas ete bien entrer");
                }

            }
            else
            {
                throw new ArgumentException("l'indice de consomation est hors de limite ou la valeur n'a pas ete bien entrer");
            }


        }

        #endregion

        #region Methode public Enregistrer

        /// <summary>
        /// Enregistrement des donnes de la  trasaction
        /// </summary>
        public void Enregistrer()
        {
            Voiture.idInt++;

            Console.WriteLine(Id + Environment.NewLine + Nom + Environment.NewLine + Addresse + Environment.NewLine +
               Ville + Environment.NewLine + Province + Environment.NewLine + CodePostal + Environment.NewLine +
             Telephone + Environment.NewLine + ModePaiment + Environment.NewLine + VoiturePrefe + Environment.NewLine +
            Consomation + Environment.NewLine + Marque + Environment.NewLine + Prix + Environment.NewLine +
           DateLivraison + Environment.NewLine);

        }

        /// <summary>
        /// Methode enregistre
        /// </summary>
        /// <param name="nomForm"></param>
        /// <param name="addresseStrFom"></param>
        /// <param name="villeStrForm"></param>
        /// <param name="provinceStrForm"></param>
        /// <param name="codePostalStrForm"></param>
        /// <param name="telephoneStrForm"></param>
        /// <param name="modePaiementStrForm"></param>
        /// <param name="voiturePrefStrForm"></param>
        /// <param name="consomationStrForm"></param>
        /// <param name="marqueStrForm"></param>
        /// <param name="prixDecimalForm"></param>
        /// <param name="dateReservationForm"></param>
   
        public void Enregistrer(string nomForm, string addresseStrFom, string villeStrForm,
            string provinceStrForm, string codePostalStrForm, string telephoneStrForm,
            string modePaiementStrForm, string voiturePrefStrForm, string consomationStrForm,
            string marqueStrForm, decimal prixDecimalForm, DateTime dateReservationForm)
        {
            this.Nom = nomForm;
            this.Addresse = addresseStrFom;
            this.Ville = villeStrForm;
            this.Province = provinceStrForm;
            this. CodePostal = codePostalStrForm;
            this.Telephone = telephoneStrForm;
            this.ModePaiment = modePaiementStrForm;
            this. VoiturePrefe = voiturePrefStrForm;
            this.Consomation = consomationStrForm;
            this.Marque = marqueStrForm;
            this.Prix = prixDecimalForm;
            this.DateReservation = dateReservationForm;

            Enregistrer();
        }
        #endregion

    }
}
