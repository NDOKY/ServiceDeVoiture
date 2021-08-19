using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ServiceDeVoitureNS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            VoitureForm.oLog.WriteEntry(System.Environment.UserName + "a démarré VoitureForm a " + DateTime.Now.ToString());

            Application.ApplicationExit += Application_ApplicationExit;

             Application.Run(new VoitureForm());
        }

        private static void Application_ApplicationExit(object sender, EventArgs e)
        {
            VoitureForm.oLog.WriteEntry(System.Environment.UserName + "a quitté VoitureForm a " +
                DateTime.Now.ToString() + "apres "+ VoitureNS.Voiture.idInt + " transactions");
        }
    }
}
