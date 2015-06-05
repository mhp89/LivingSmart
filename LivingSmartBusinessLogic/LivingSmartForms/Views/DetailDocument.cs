using System;
using System.Drawing;
using System.Windows.Forms;
using LivingSmartBusinessLogic.Controller;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartForms.Views
{
	public partial class DetailDocument : UserControl
	{
		private NewCaseStepDetails baseView;
		public Document Document { get; private set; }

		public DetailDocument(NewCaseStepDetails baseView, Document document)
		{
			this.baseView = baseView;
			Document = document;

			InitializeComponent();

			stbType.Text = Document.Type;
			stbPrice.Text = Document.Price.ToString();
			lblFile.Text = Document.Location;
		}

		public bool Validate()
		{
			bool fielddataOk = true;
			fielddataOk &= stbPrice.Validate();
			fielddataOk &= stbType.Validate();

			return fielddataOk;
		}

		private void btnRemove_Click(object sender, System.EventArgs e)
		{
			baseView.RemoveDocument(this);
		}

		private void stbPrice_TextChanged(object sender, System.EventArgs e)
		{
			var price = (string.IsNullOrEmpty(stbPrice.Text))?0:Convert.ToInt32(stbPrice.Text);
			CaseController.Instance.SetDocumentPrice(Document, price);
		}

		private void stbType_TextChanged(object sender, EventArgs e)
		{
			CaseController.Instance.SetDocumentType(Document, stbType.Text);
		}
	}
}
