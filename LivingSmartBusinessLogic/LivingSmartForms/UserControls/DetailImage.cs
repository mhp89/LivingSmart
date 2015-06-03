using System.Drawing;
using System.Windows.Forms;
using LivingSmartBusinessLogic.Model;
using LivingSmartForms.Views;

namespace LivingSmartForms.UserControls
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
		}


		private void btnRemove_Click(object sender, System.EventArgs e)
		{
			baseView.RemoveImage(this);
		}
	}
}
