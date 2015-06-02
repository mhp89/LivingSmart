using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LivingSmartBusinessLogic;
using LivingSmartBusinessLogic.Controller;
using LivingSmartBusinessLogic.Model;
using LivingSmartForms.Classes;

namespace LivingSmartForms
{
	/// <summary>
	/// Form til h�ndtering af log ind
	/// </summary>
	/// <auther>Mathias Petersen</auther>
	public partial class Login : Form
	{
		/// <summary>
		/// Indikere om der bliver skiftet form, eller brugeren �nsker at lukke programmet.
		/// </summary>
		private bool formShift;

		public Login()
		{
			InitializeComponent();
		}

		#region Form

		private void Login_Load(object sender, EventArgs e)
		{
			//Logger automatisk ind hvis brugeroplysningerne er gemt
			if (Convert.ToBoolean(RegistryWrapper.RegKey.GetValue("AutomaticLoginActive", false)))
			{
				chbAutoLogin.Checked = true;
				PerformAutoLogin();
			}
		}
		private void Login_SizeChanged(object sender, EventArgs e)
		{
			//Gentegner hele formen for at sikre korrekt design
			Refresh();
		}
		private void Login_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!formShift)
				Environment.Exit(Environment.ExitCode);
		}

		#endregion

		private void btnLogin_Click(object sender, EventArgs e)
		{
			PerformLogin();
		}

		private void tbLogin_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				PerformLogin();
		}

		private void PerformLogin()
		{
			//Hvis input er gyldig, pr�v at logge ind
			if (stbUsername.Validate() && stbPassword.Validate())
			{
				string username = stbUsername.Text;
				string password = stbPassword.Text;

				EstateAgent estateAgent = EstateAgentController.Instance.LoginEstateAgent(username, password);

				//Hvis estateAgent ikke er null, var login'et korrekt
				if (estateAgent != null)
				{
					if (chbAutoLogin.Checked)
						SaveAutomaticLogin(username, password);

					OpenMainForm(estateAgent);
				}
				else
				{
					MessageBox.Show("Forkerte log ind oplysninger", "Living Smart", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		private void PerformAutoLogin()
		{
			string username = Convert.ToString(RegistryWrapper.RegKey.GetValue("AutomaticLoginEstateAgentId", null));
			string password = Convert.ToString(RegistryWrapper.RegKey.GetValue("AutomaticLoginPassword", null));

			EstateAgent estateAgent = EstateAgentController.Instance.LoginEstateAgent(username, password);

			if (estateAgent != null)
			{
				OpenMainForm(estateAgent);
			}
			else
			{
				ClearAutomaticLogin();
				MessageBox.Show("Forkerte log ind oplysninger", "Living Smart", MessageBoxButtons.OK, MessageBoxIcon.Error);
				stbUsername.Text = username;
			}
		}

		/// <summary>
		/// Gemmer login oplysninger for m�gleren
		/// </summary>
		/// <param name="estateAgentId">Id'et p� m�gleren</param>
		/// <param name="password">Adgangskoden for m�gleren</param>
		private void SaveAutomaticLogin(string username, string password)
		{
			RegistryWrapper.RegKey.SetValue("AutomaticLoginActive", true);
			RegistryWrapper.RegKey.SetValue("AutomaticLoginEstateAgentId", username);
			RegistryWrapper.RegKey.SetValue("AutomaticLoginPassword", password);
		}
		
		/// <summary>
		/// Rydder autologin oplysninger
		/// </summary>
		public static void ClearAutomaticLogin()
		{
			RegistryWrapper.RemoveKey("AutomaticLoginActive");
			RegistryWrapper.RemoveKey("AutomaticLoginEstateAgentId");
			RegistryWrapper.RemoveKey("AutomaticLoginPassword");
		}



		private void OpenMainForm(EstateAgent estateAgent)
		{
			formShift = true;
			FormHandler.ShowBaseForm(estateAgent);
			Close();//Lukker Login formen
		}

	}
}
