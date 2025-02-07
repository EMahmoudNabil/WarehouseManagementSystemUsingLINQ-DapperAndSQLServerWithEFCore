using ProjectEntity_Dapper.Invoice;
using ProjectEntity_Dapper.Invoices;
using ProjectEntity_Dapper.Products;
using ProjectEntity_Dapper.Products_Form;
using ProjectEntity_Dapper.user;

namespace ProjectEntity_Dapper
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frm_Login());
        }
    }
}