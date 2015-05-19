using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LivingSmartForms.Classes;
using SmartControls;

namespace LivingSmartForms.DropIns
{
	public partial class NewCaseDropIn : BaseDropIn
	{
		public NewCaseDropIn(BaseForm baseForm) : base(baseForm)
		{
			InitializeComponent();
		}

		private void smartButton1_Click(object sender, EventArgs e)
		{
		}

		private void smartButton2_Click(object sender, EventArgs e)
		{
			stepIndicator.CurrentStep--;
		}

		private void smartButton3_Click(object sender, EventArgs e)
		{
			stepIndicator.CurrentStep++;
		}
	}
}
