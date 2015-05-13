using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LivingSmartForms.Classes
{
	public partial class BaseDropIn : UserControl
	{
		protected BaseForm baseForm;
		public BaseDropIn(BaseForm baseForm)
		{
			this.baseForm = baseForm;
			AutoScaleMode = AutoScaleMode.None;

			InitializeComponent();
		}
	}
}
