using System.Drawing;
using System.Windows.Forms;
using LivingSmartBusinessLogic.Controller;
using LivingSmartBusinessLogic.Entity;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartForms.Views
{
	public partial class DetailImage : UserControl
	{
		private NewCaseStepDetails baseView;
		public Picture Picture { get; private set; }

		public DetailImage(NewCaseStepDetails baseView, Image image, Picture picture)
		{
			this.baseView = baseView;
			Picture = picture;

			InitializeComponent();

			pcbImage.Image = image;
			pcbImage.SizeMode = PictureBoxSizeMode.Zoom;

			stbDescription.Text = Picture.Description;
		}


		private void btnRemove_Click(object sender, System.EventArgs e)
		{
			baseView.RemovePicture(this);
		}

		private void stbDescription_TextChanged(object sender, System.EventArgs e)
		{
			CaseController.Instance.SetPictureDescription(Picture, stbDescription.Text);
		}
	}
}
