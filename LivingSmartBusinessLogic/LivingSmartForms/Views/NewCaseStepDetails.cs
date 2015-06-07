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
using LivingSmartBusinessLogic.Entity;
using LivingSmartBusinessLogic.Model;
using LivingSmartForms.Classes;
using LivingSmartForms.DropIns;
using LivingSmartForms.UserControls;

namespace LivingSmartForms.Views
{
	public partial class NewCaseStepDetails : CaseStep
    {
		public NewCaseStepDetails(NewCaseDropIn baseView, Case cCase)
			: base(cCase)
        {
            InitializeComponent();

			if (cCase != null)
			{
				var lastRating = CaseController.Instance.GetLastRating();
				stbSystemRating.Text = lastRating.SystemValue.ToString();
				stbDetailsRating.Text = lastRating.EstateAgentValue.ToString();
				stbDetailsPublicEvaluation.Text = cCase.PublicRating.ToString();
				stbDetailsPrice.Text = cCase.NewestAskingPrice.ToString();

				stbDetailsDescription.Text = cCase.Description;

				foreach (var picture in CaseController.Instance.GetPictures())
				{
					Image image = Image.FromFile(picture.Location);
					clsPictures.AddControl(new DetailImage(this, image, picture));
				}

				foreach (var document in CaseController.Instance.GetDocuments())
				{
					clsDocuments.AddControl(new DetailDocument(this, document));
				}
			}
        }
		
		public override bool Save()
		{
			bool fielddataOk = ValidateFields();
			if (fielddataOk)
			{
				var systemValue = Convert.ToInt64(stbSystemRating.Text);
				var agentValue = (string.IsNullOrEmpty(stbDetailsRating.Text))?(long?) null:Convert.ToInt64(stbDetailsRating.Text);
				var lastRating = CaseController.Instance.GetLastRating();
				if (lastRating == null || lastRating.SystemValue != systemValue || lastRating.EstateAgentValue != agentValue)
					CaseController.Instance.MakeNewRating(systemValue, agentValue);

				if (cCase == null || stbDetailsPrice.Text != cCase.NewestAskingPrice.ToString())
					CaseController.Instance.MakeNewAskingPrice(Convert.ToInt64(stbDetailsPrice.Text));

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

			foreach (DetailDocument control in clsDocuments.Controls)
				fielddataOk &= control.Validate();

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
					var picture = CaseController.Instance.MakeNewPicture(filename);

					Image image = Image.FromFile(filename);
					clsPictures.AddControl(new DetailImage(this, image, picture));
				}
			}
		}
		public void RemovePicture(DetailImage detailImage)
		{
			CaseController.Instance.RemovePictureFromCase(detailImage.Picture);
			clsPictures.RemoveControl(detailImage);
		}

		#endregion


		#region Documents

		private void btnNewDocument_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Multiselect = true;
			var result = ofd.ShowDialog();

			if (result == DialogResult.OK)
			{
				foreach (var filename in ofd.FileNames)
				{
					var document = CaseController.Instance.MakeNewDocument("", 0, filename);
					clsDocuments.AddControl(new DetailDocument(this, document));
				}
			}
		}
		public void RemoveDocument(DetailDocument detailDocument)
		{
			CaseController.Instance.RemoveDocumentFromCase(detailDocument.Document);
			clsDocuments.RemoveControl(detailDocument);
		}

		#endregion

		private void btnGetNewRating_Click(object sender, EventArgs e)
		{
			var rating = CaseController.Instance.GetSystemRating();

			stbSystemRating.Text = rating.ToString();

			if (string.IsNullOrEmpty(stbDetailsPrice.Text))
				stbDetailsPrice.Text = rating.ToString();
		}
	}
}
