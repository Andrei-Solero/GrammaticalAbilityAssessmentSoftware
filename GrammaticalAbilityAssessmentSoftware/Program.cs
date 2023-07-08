using DataAccessLibrary;
using System.Configuration;

namespace GrammaticalAbilityAssessmentSoftware
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ConnectionString.Connection = ConfigurationManager.ConnectionStrings["GAAS_DB"].ConnectionString;

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new SelectRole());
        }
    }
}