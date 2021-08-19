/*
        Programmeur:        Yvan Zacharie Kouemegni &  Yves Ndoky

        Date:               Novembre

        Solution:           ServiceDeVoiture.sln
        Projet:             ServiceDeVoiture.csproj
        Class:              VoitureForm

        But:                Manipulation de la class VoitureForm
    
        Phase F
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VoitureNS;
using System.Configuration;
using g = ServiceDeVoitureNS.ServiceVenteDeVoitureGeneralClass;
using ce = ServiceDeVoitureNS.ServiceVenteDeVoitureGeneralClass.CodeErreurs;
using ct = TypesNS.Types.CodeTypes;

using Microsoft.VisualBasic.Logging;

namespace ServiceDeVoitureNS
{
    /// <summary>
    /// Saisie des informations d'une vente
    /// </summary>
    /// <remarks>Tous droits réservés: Yves et Zacharie Inc. 2025</remarks>
    /// 
    public partial class VoitureForm : Form
    {
        #region Constructeur

        /// <summary>
        /// Constructeur
        /// </summary>
        public VoitureForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Champs privés
        Voiture oVoiture ;
        TypesNS.Types oTypes;

       public static Log oLog = new Log();

        #endregion

        #region Initialisation: Erreurs, Zones et Poids
        private void VoitureForm_Load(object sender, EventArgs e)
        {

            try
            {
                //oLog = new Log();
                g.InitialiserMessagesErreurs();

                oVoiture = new Voiture();
                oTypes = new TypesNS.Types();

                consommationComboBox.Items.AddRange(oVoiture.ObtenirConsommation());
                marqueComboBox.Items.AddRange(oVoiture.ObtenirMarques());

                modePaiementComboBox.Items.AddRange(oTypes.obtentionmodePaiellementMarque(ct.modePaiellement));
                voiturePrefereComboBox.Items.AddRange(oTypes.obtentionmodePaiellementMarque(ct.marque));


                consommationComboBox.SelectedIndex = 0;
                marqueComboBox.SelectedIndex = 0;
                modePaiementComboBox.SelectedIndex = 0;
                voiturePrefereComboBox.SelectedIndex = 0;

                string formatInfo = "Usager : {0}, Début du formulaire: {1}, Application: {2}";

                oLog.WriteEntry(string.Format(formatInfo, System.Security.Principal.WindowsIdentity.GetCurrent().Name,
                    DateTime.Now, GetType().Assembly.GetName().Name));
            }
     
            catch (Exception)
            {
                MessageBox.Show(g.tMessagesErreursString[(int)ce.CEErreurIndeterminee]);
            }
        }

        #endregion

        #region Validations et saisie des données
        private void reservationDateTimePicker_Validating(object sender, CancelEventArgs e)
        {
            DateTime dateCourante;

            if (DateTime.TryParse(reservationDateTimePicker.Text, out dateCourante))
            {
                reservationDateTimePicker.Text = dateCourante.ToLongDateString();
            }
            else
                reservationDateTimePicker.Text = DateTime.Now.ToLongTimeString();
        }
        #endregion

        #region Déterminer et afficher le prix du service de livraison selon la catégorie de consommation et de la marque
        private void ConsoMarque_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (consommationComboBox.SelectedIndex != -1 && marqueComboBox.SelectedIndex != -1)
                {
                    // prixLabel.Text = oVoiture.ObtenirPrix(consommationComboBox.SelectedIndex, marqueComboBox.SelectedIndex).ToString("c2");
                   prixLabel.Text = oVoiture.ObtenirPrix(consommationComboBox.SelectedItem.ToString(), marqueComboBox.SelectedItem.ToString()).ToString("C2");

                }

            }
            catch (ArgumentOutOfRangeException rangeException)
            {
                oLog.WriteException(rangeException);
                MessageBox.Show(rangeException.Message);
            }
            catch (ArgumentException argumentException)
            {
                oLog.WriteException(argumentException);
                MessageBox.Show(argumentException.Message);
            }
            catch (Exception indetemineException)
            {
                oLog.WriteException(indetemineException);
                MessageBox.Show(g.tMessagesErreursString[(int)ce.CEErreurIndeterminee]);
            }

           
        }


        #endregion

        #region Enregistrer la transaction d'expédition de colis courante
        private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Voiture oVoiture = new Voiture();

            try
            {
                this.ValidateChildren();

                // 1)  Transmettre données Projet Principal  Projet Transaction en passant par le constructeur

                //oVoiture = new Voiture(nomMaskedTextBox.Text, adresseMaskedTextBox.Text, villeMaskedTextBox.Text,
                //    provinceMaskedTextBox.Text, codePostalMaskedTextBox.Text, telephoneMaskedTextBox.Text,
                //    modePaiementComboBox.SelectedItem.ToString(), voiturePrefereComboBox.SelectedItem.ToString(),
                //    consommationComboBox.SelectedItem.ToString(), marqueComboBox.SelectedItem.ToString(),
                //   decimal.Parse(prixLabel.Text,System.Globalization.NumberStyles.Currency), reservationDateTimePicker.Value);

                //oVoiture.Enregistrer();


                ////2): Transmettre données Projet Principal  Projet Transaction en passant par les propriétés

                oVoiture.Nom = nomMaskedTextBox.Text;
                oVoiture.Addresse = adresseMaskedTextBox.Text;
                oVoiture.Ville = villeMaskedTextBox.Text;
                oVoiture.Province = provinceMaskedTextBox.Text;
                oVoiture.CodePostal = codePostalMaskedTextBox.Text;
                oVoiture.Telephone = telephoneMaskedTextBox.Text;
                oVoiture.ModePaiment = modePaiementComboBox.SelectedItem.ToString();
                oVoiture.VoiturePrefe = voiturePrefereComboBox.SelectedItem.ToString();
                oVoiture.Consomation = consommationComboBox.SelectedItem.ToString();
                oVoiture.Marque = marqueComboBox.SelectedItem.ToString();
                oVoiture.Prix = decimal.Parse(prixLabel.Text, System.Globalization.NumberStyles.Currency);
                oVoiture.DateReservation = reservationDateTimePicker.Value;


                oVoiture.Enregistrer();

                // 3) : Transmettre données Projet Principal  Projet Transaction en passant par Enregistrer avec paramètres


                //    oVoiture.Enregistrer(nomMaskedTextBox.Text, adresseMaskedTextBox.Text, villeMaskedTextBox.Text,
                //         provinceMaskedTextBox.Text, codePostalMaskedTextBox.Text, telephoneMaskedTextBox.Text,
                //         modePaiementComboBox.SelectedItem.ToString(), voiturePrefereComboBox.SelectedItem.ToString(),
                //         consommationComboBox.SelectedItem.ToString(), marqueComboBox.SelectedItem.ToString(),
                //        decimal.Parse(prixLabel.Text, System.Globalization.NumberStyles.Currency), reservationDateTimePicker.Value.Date);

                
                paiementDuLabel.Text = oVoiture.DateLivraison.ToLongDateString();
            }
            catch (NullReferenceException nullRefException)
            {
                oLog.WriteException(nullRefException);
                MessageBox.Show(nullRefException.Message);
            }
            catch (ArgumentNullException nullArgException)
            {
                oLog.WriteException(nullArgException);
                MessageBox.Show(nullArgException.Message);
            }
            catch(FormatException formatException)
            {
                oLog.WriteException(formatException);
                MessageBox.Show(formatException.Message);
            }
            catch (ArgumentOutOfRangeException rangeException)
            {
                oLog.WriteException(rangeException);
                MessageBox.Show(rangeException.Message);
            }
            catch (ArgumentException argumentException)
            {
                oLog.WriteException(argumentException);
                MessageBox.Show(argumentException.Message);
            }
            catch (Exception indetermineException)
            {
                oLog.WriteException(indetermineException);
                MessageBox.Show(g.tMessagesErreursString[(int)ce.CEErreurIndeterminee]);
            }
        }
        #endregion

        #region Enter
        private void MaskedTextBox_Enter(object sender, EventArgs e)
        {
            (sender as MaskedTextBox).SelectAll();
        }

        #endregion

        #region Impression de la liste de prix et de la facture

        #endregion

        #region Méthodes privées générales

        #endregion

        #region A propos de 
        private void aproposDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                serviceVoitureAboutBox oService = new serviceVoitureAboutBox();

                oService.ShowDialog();
            }
            catch(Exception)
            {
                MessageBox.Show(g.tMessagesErreursString[(int)ce.CEErreurIndeterminee]);
            }
          
        }

        #endregion

        #region  Quitter 
        private void quitterButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void VoitureForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            oLog.WriteEntry(System.Environment.UserName + "a mis fin au formulaire a : " + DateTime.Now.ToString());
        }
        #endregion

    }
}
