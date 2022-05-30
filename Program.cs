using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boat_Rental
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Initialisation des différents formulaires

            Form1 form = new Form1();
            FormManager manager = new FormManager();
            FormManagerUser managerUser = new FormManagerUser();

            Application.Run(form);

            // Si c'est un super-admin, lance le menu avec toutes les options
            if (form.SuperAdmin)
            {
                Application.Run(manager);
            }
            // Sinon si c'est un admin, lance le menu avec moins d'options
            else if (form.Authentified)
            {
                Application.Run(managerUser);
            }
            // Sinon rien
            else
            {
                return;
            }
        }
    }
}
