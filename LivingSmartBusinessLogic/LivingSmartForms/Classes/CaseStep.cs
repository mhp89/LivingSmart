using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LivingSmartBusinessLogic;

namespace LivingSmartForms.Classes
{
	public partial class CaseStep : UserControl
	{
		public CaseStep()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Saving step to case.
		/// </summary>
		/// <returns>Success of save</returns>
		public virtual bool Save()
		{
			return false;
		}
	}
}
