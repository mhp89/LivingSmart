using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using LivingSmartBusinessLogic;
using LivingSmartBusinessLogic.Entity;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartForms.Classes
{
	/// <summary>
	/// Handler til opstart af form som nyt program
	/// </summary>
	/// <author>Mathias Petersen</author>
	public static class FormHandler
	{
		public static void ShowLoginForm()
		{
			Thread loginThread = new Thread(RunLogin);//Kalder metoden RunLogin i en ny tråd
			loginThread.SetApartmentState(ApartmentState.STA);//Indstiller tråden til at køre med en enkelt tråd
			loginThread.Start();
		}
		private static void RunLogin()
		{
			Application.Run(new Login());//Starter en ny applikation med formen Login
		}

        public static void ShowBaseForm(EstateAgent estateAgent)
		{
			Thread loginThread = new Thread(RunBaseForm);//Kalder metoden RunLogin i en ny tråd
			loginThread.SetApartmentState(ApartmentState.STA);//Indstiller tråden til at køre med en enkelt tråd
			loginThread.Start(estateAgent);//Starter tråden med en parameter
		}
		private static void RunBaseForm(object estateAgent)
		{
			Application.Run(new BaseForm((EstateAgent) estateAgent));//Starter en ny applikation med formen MainForm
		}
	}
}
