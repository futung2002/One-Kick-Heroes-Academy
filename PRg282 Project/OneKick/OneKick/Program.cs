using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using OneKick.BusinessLogicLayer;
using OneKick.DataLayer;
using System.IO;

namespace OneKick
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            try
            {
                File.Create("summary.txt");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                File.Create("superheroes.txt");
            }
            catch (Exception e) 
            { 
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
