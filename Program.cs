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
            Form1 form = new Form1();
            FormManager manager = new FormManager();
            FormManagerUser managerUser = new FormManagerUser();
            FormMember member = new FormMember();
            FormBoat boat = new FormBoat();
            FormCustomer customer = new FormCustomer();
            Application.Run(form);

            if (form.SuperAdmin)
                Application.Run(manager);
            if (form.Authentified)
                Application.Run(managerUser);
            if (manager.AddMember)
                Application.Run(member);
            if (manager.AddBoat)
                Application.Run(boat);
            if (manager.AddCustomer)
                Application.Run(customer);
            if (manager.AddCommand)
                Application.Run();
            if (manager.CustomerList)
                Application.Run();
            if (manager.CommandList)
                Application.Run();
        }
    }
}
