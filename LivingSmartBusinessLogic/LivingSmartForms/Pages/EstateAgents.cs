using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using LivingSmartBusinessLogic.Controller;
using LivingSmartBusinessLogic.Model;
using LivingSmartForms.Classes;
using LivingSmartForms.DropIns;
using LivingSmartForms.Views;

namespace LivingSmartForms.Pages
{
	public partial class EstateAgents : BasePage
	{
        string timestamp;
        string print;
        string printType;

		public EstateAgents(BaseForm baseForm)
			: base(baseForm)
		{
			InitializeComponent();
            timestamp = DateTime.Now.ToString("ddMMyyyy");
            stbYear.Text = DateTime.Now.ToString("yyyy");
		}
		private void UpdateList()
		{
			clsEstateAgents.SuspendLayout();

			clsEstateAgents.ClearList();
			var estateAgents = EstateAgentController.Instance.GetEstateAgents();
			foreach (var estateAgent in estateAgents)
			{
				var control = new EstateAgentLine(baseForm, estateAgent) {Margin = Padding.Empty};
				clsEstateAgents.AddControl(control, true);
			}
			sblActiveCases.Text = estateAgents.Count.ToString();

			clsEstateAgents.ResumeLayout();
		}

		public override void OnShow()
		{
			UpdateList();
		}

		private void NewEstateAgentAdded(EstateAgent estateAgent)
		{
			var control = new EstateAgentLine(baseForm, estateAgent) { Margin = Padding.Empty };
			clsEstateAgents.AddControl(control);
			sblActiveCases.Text = clsEstateAgents.Controls.Count.ToString();
		}

		private void btnNewEstateAgents_Click(object sender, EventArgs e)
		{
			baseForm.ShowDropIn(new NewEstateAgentDropIn(baseForm, NewEstateAgentAdded));
		}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <author>Maja Olesen</author>
        private void btnAllStatistics_Click(object sender, EventArgs e)
        {
            printType = "Statistik-Alt_";         

            print = PrintStatistics.CreatePrintAll();

            PrintFile();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <author>Maja Olesen</author>
        private void btnStatisticsPrEstateAgent_Click(object sender, EventArgs e)
        {
            if (!stbYear.Validate())
                return;
            
            int agentId = baseForm.DefaultEstateAgent.Id;
            string agentShort = baseForm.DefaultEstateAgent.Name.Replace(' ', '-');
            printType = "Statistik_" + agentShort + "_";

            int year = Convert.ToInt32(stbYear.Text);

            print = PrintStatistics.CreatePrintEstateAgent(agentId, year);

            PrintFile();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <author>Mathias Petersen</author>
        private void PrintFile ()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = printType + timestamp + ".txt";
            sfd.Filter = "Text File | *.txt";
            sfd.DefaultExt = "txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(sfd.OpenFile());
                writer.Write(print);
			    writer.Close();
                Process.Start(sfd.FileName);
            }
        }

        private void stbYear_TextChanged(object sender, EventArgs e)
        {
            btnStatisticsPrEstateAgent.Enabled = stbYear.Validate();
        }
	}
}
