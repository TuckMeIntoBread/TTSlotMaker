using System;
using System.IO;
using System.Windows.Forms;

namespace TTSlotMaker
{
    static class Program
    {
        public static string BasePath => AppDomain.CurrentDomain.BaseDirectory;

        public static string ModPackPath => Path.Combine(BasePath, "Base.modpack");

        public static string SavedPath => Path.Combine(BasePath, "Base_Modpack.ttmp2");

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SlotMakerForm());
        }
    }
}