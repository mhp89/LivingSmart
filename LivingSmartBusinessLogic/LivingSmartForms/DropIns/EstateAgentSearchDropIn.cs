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
using LivingSmartBusinessLogic.Controller;
using LivingSmartBusinessLogic.Entity;
using LivingSmartBusinessLogic.Model;
using LivingSmartForms.Classes;
using LivingSmartForms.Views;
using SmartControls;

namespace LivingSmartForms.DropIns
{
	public partial class EstateAgentSearchDropIn : BaseDropIn
	{
		public EstateAgentSearchDropIn() : base(null) { }

		private EstateAgentSearchCallback callback;

		private EstateAgentLineSearch selectedEstateAgent;

		
		public delegate void EstateAgentSearchCallback(EstateAgent estateAgent);

		protected override void Closing()
		{
			FinishSearch(null);
		}

		public override string GetDropInId()
		{
			return "EstateAgentSearch";
		}

		private void Initialize(BaseForm baseForm, EstateAgentSearchCallback callback)
		{
			this.baseForm = baseForm;
			this.callback = callback;
			
			InitializeComponent();

			btnSelect.Enabled = false;

			baseForm.ShowDropIn(this);
		}

		public static void Show(BaseForm baseForm, EstateAgentSearchCallback callback)
		{
			EstateAgentSearchDropIn dropIn = new EstateAgentSearchDropIn();
			dropIn.Initialize(baseForm, callback);
		}


		private void FinishSearch(EstateAgent estateAgent)
		{
			baseForm.CloseDropIn(this);
			callback(estateAgent);
		}
		private void btnCancel_Click(object sender, EventArgs e)
		{
			FinishSearch(null);
		}
		private void btnSelect_Click(object sender, EventArgs e)
		{
			FinishSearch(selectedEstateAgent.EstateAgent);
		}

		#region Search

		public void SelectEstateAgent(EstateAgentLineSearch estateAgent)
		{
			if (selectedEstateAgent != null)
				selectedEstateAgent.BackColor = default(Color);
			estateAgent.BackColor = SmartColor.DarkA10;
			selectedEstateAgent = estateAgent;
			btnSelect.Enabled = true;
		}

		public void FastSelectEstateAgent(EstateAgentLineSearch estateAgent)
		{
			FinishSearch(estateAgent.EstateAgent);
		}

		private void Search(object sender, EventArgs e)
		{
			selectedEstateAgent = null;
			btnSelect.Enabled = false;
			UpdateResult();
		}

		private void UpdateResult()
		{
			clsResult.ClearList();

			var id = (string.IsNullOrEmpty(stbId.Text)) ? -1 : Convert.ToInt32(stbId.Text);
			var name = (string.IsNullOrEmpty(stbName.Text)) ? null : stbName.Text;
			var phone = (string.IsNullOrEmpty(stbPhone.Text)) ? null : stbPhone.Text;
			var email = (string.IsNullOrEmpty(stbEmail.Text)) ? null : stbEmail.Text;

			if(id == -1 && name == null && phone == null && email == null)
				return;

			var result = EstateAgentController.Instance.SearchEstateAgents(id, name, phone, email);

			clsResult.SuspendLayout();
			
			foreach (var estateAgent in result)
				clsResult.AddControl(new EstateAgentLineSearch(this, estateAgent));

			clsResult.ResumeLayout();
		}

		#endregion

	}
}
