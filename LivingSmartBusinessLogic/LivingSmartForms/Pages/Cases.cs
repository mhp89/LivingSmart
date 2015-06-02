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
using LivingSmartForms.DropIns;

namespace LivingSmartForms.Pages
{
	public partial class Cases : BasePage
	{
		public Cases(BaseForm baseForm) : base(baseForm)
		{
			InitializeComponent();
		}


		private void btnNewCase_Click(object sender, EventArgs e)
		{
			baseForm.ShowDropIn(new NewCaseDropIn(baseForm));
		}

        private void btnArrangeOpenHouse_Click(object sender, EventArgs e)
        {

        }
	}
}
