using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LivingSmartBusinessLogic;
using LivingSmartBusinessLogic.Controller;

namespace LivingSmartForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*CaseController caseController = new CaseController();
			CustomerController customerController = new CustomerController();
			EstateAgentController estateAgentController = new EstateAgentController();*/

	        CityController.Instance.GetCity(0);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Login());
        }
    }
}
