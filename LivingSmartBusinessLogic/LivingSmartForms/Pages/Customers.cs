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
using LivingSmartForms.Views;

namespace LivingSmartForms.Pages
{
	public partial class Customers : BasePage
	{
        public Customers(BaseForm baseForm)
            : base(baseForm)
		{
			InitializeComponent();

			for (int i = 0; i < 10; i++)
			{
				var control = new CustomerLine();
				control.Margin = Padding.Empty;
				controlList1.AddControl(control);
			}
		}

		public override void OnShow()
		{
			base.OnShow();
		}
	}
}
