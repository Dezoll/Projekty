using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engineer.Classes;



namespace Engineer
{
    public static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        public static void Main(string[] args)
        {
            if (args.Length >= 2)
            {
                string klucz = args[0];
                string id = args[1];

                LoginFormHandler handler = new LoginFormHandler();
                handler.HandleLogin(klucz, id);
            }
            else
            {
                Console.WriteLine("Please provide 'klucz' and 'id' as command-line arguments.");
            }
        }
    }
}
