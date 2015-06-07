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
	/// <summary>
	/// Base class for alle sider
	/// </summary>
	/// <author>Mathias Petersen</author>
	public partial class BasePage : UserControl
	{
		protected BaseForm baseForm;

		protected BasePage(BaseForm baseForm)
		{
			this.baseForm = baseForm;
			AutoScaleMode = AutoScaleMode.None;

			InitializeComponent();
		}

		private BasePage() { }

		/// <summary>
		/// Kaldes når siden bliver vist
		/// </summary>
		public virtual void OnShow() { }
		/// <summary>
		/// Kaldes når siden bliver skjult
		/// </summary>
		public virtual void OnHide() { }
	}
}
