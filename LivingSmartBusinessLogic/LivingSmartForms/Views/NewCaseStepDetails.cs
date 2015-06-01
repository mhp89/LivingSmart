using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LivingSmartBusinessLogic.Controller;
using LivingSmartForms.Classes;
using LivingSmartForms.UserControls;

namespace LivingSmartForms.Views
{
	public partial class NewCaseStepDetails : CaseStep
    {
        public NewCaseStepDetails(BaseForm baseForm)
        {
            InitializeComponent();
        }

		public override bool Save()
		{
			bool fielddataOk = ValidateFields();
			if (fielddataOk)
			{
				var systemValue = Convert.ToInt64(stbSystemRating.Text);
				var agentValue = Convert.ToInt64(stbDetailsRating.Text);
				var lastRating = CaseController.Instance.GetLastRating();
				if (lastRating.SystemValue != systemValue || lastRating.EstateAgentValue != agentValue)
				{
					var rating = CaseController.Instance.MakeNewRating();
					//TODO: Set rating
				}

				CaseController.Instance.SetPublicRating(Convert.ToInt64(stbDetailsPublicEvaluation.Text));
				CaseController.Instance.SetDescription(stbDetailsDescription.Text);
			}
			return fielddataOk;
		}

		private bool ValidateFields()
		{
			bool fielddataOk = true;
			fielddataOk &= stbDetailsPublicEvaluation.Validate();
			fielddataOk &= stbSystemRating.Validate();
			fielddataOk &= stbDetailsRating.Validate();
			fielddataOk &= stbDetailsPrice.Validate();
			fielddataOk &= stbDetailsDescription.Validate();
			return fielddataOk;
		}

		#region Images

		private void btnAddImage_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "Image Files (*.bmp, *.jpg)|*.bmp;*.jpg";
			ofd.Multiselect = true;
			var result = ofd.ShowDialog();

			if (result == DialogResult.OK)
			{
				foreach (var filename in ofd.FileNames)
				{
					Image image = Image.FromFile(filename);
					clsImages.AddControl(new DetailImage(this, image));

					var picture = CaseController.Instance.MakeNewPicture(filename, "");
					CaseController.Instance.AddPictureToCase(picture);
				}
			}
		}
		public void RemoveImage(DetailImage detailImage)
		{
			clsImages.RemoveControl(detailImage);
		}

		#endregion

		private void btnGetNewRating_Click(object sender, EventArgs e)
		{
			var rating = CaseController.Instance.MakeNewRating();

			stbSystemRating.Text = rating.SystemValue.ToString();
		}
	}
}
