using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LivingSmartBusinessLogic;
using LivingSmartBusinessLogic.Entity;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartForms.Classes
{
	/// <summary>
	/// Base klasse for steps til ny sag
	/// </summary>
	/// <author>Mathias Petersen</author>
	public partial class CaseStep : UserControl
	{
		protected Case cCase;

		public CaseStep(Case cCase)
		{
			this.cCase = cCase;
			InitializeComponent();
		}

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
