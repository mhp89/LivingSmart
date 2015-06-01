using System.Drawing;
using System.Windows.Forms;
using LivingSmartForms.Views;

namespace LivingSmartForms.UserControls
{
	public partial class DetailImage : UserControl
	{
		private NewCaseStepDetails baseView;
		public DetailImage(NewCaseStepDetails baseView, Image image)
		{
			this.baseView = baseView;
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
